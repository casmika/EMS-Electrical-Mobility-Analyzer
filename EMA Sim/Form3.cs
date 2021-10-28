using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EMA_Sim
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private double PDF_Normal(double x, double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            for (int i = 0; i < mode; i++)
            {
                result += A[i] * Math.Exp(-Math.Pow((x - mu[i]) / sg[i], 2) / 2);
            }
            return result;
        }
        private double PDF_LogNormal(double x, double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            for (int i = 0; i < mode; i++)
            {
                result += A[i] * Math.Exp(-Math.Pow((Math.Log10(x) - Math.Log10(mu[i])) / Math.Log10(sg[i]), 2) / 2);
            }
            return result;
        }

        private double Sum_PDF_Normal(double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            double step = (maximum - minimum) / 1e4;
            for (double x = minimum; x < maximum; x += step)
            {
                result += PDF_Normal(x, mu, sg, A, mode);
            }
            return result;
        }

        private double Sum_PDF_LogNormal(double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            double step = (maximum - minimum) / 1e4;
            for (double x = minimum; x < maximum; x += step)
            {
                result += PDF_LogNormal(x, mu, sg, A, mode);
            }
            return result;
        }

        private double x_form_CDF_Normal(double rand, double sum, double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            double step = (maximum - minimum) / 1e4;
            double x = 0;
            while (result <= rand * sum)
            {
                x += step;
                result += PDF_Normal(x, mu, sg, A, mode);
            }
            return x;
        }

        private double x_form_CDF_LogNormal(double rand, double sum, double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            double step = (maximum - minimum) / 1e4;
            double x = 0;
            while (result <= rand * sum)
            {
                x += step;
                result += PDF_LogNormal(x, mu, sg, A, mode);
            }
            return x;
        }


        double[] amplitude;
        double[] std;
        double[] mean;
        double[] data;
        double[] dataOut;

        int num_mode;
        int N = 0;
        double minimum = 0;
        double maximum = 0;
        string text_out1 = "";
        string text_out2 = "";

        double Ri, Ro, L, D, Qs, Qa, Vdma;
        double dQs, dQa, dVdma;
        double stepV = 1, Vmax;
        double Dia_min, Dia_max;
        private void button1_Click(object sender, EventArgs e)
        {
            Vdma = double.Parse(textBox7.Text);
            dVdma = double.Parse(textBox17.Text);
            Ri = double.Parse(textBox1.Text) * 1e-3; // mm to m
            Ro = double.Parse(textBox2.Text) * 1e-3; // mm to m
            L = double.Parse(textBox3.Text) * 1e-3; // mm to m
            D = double.Parse(textBox4.Text) * 1e-3; // mm to m
            Qs = double.Parse(textBox5.Text) * 1.66667e-5; // L/min to m3/s
            dQs = double.Parse(textBox15.Text) * 1.66667e-5; // L/min to m3/s
            Qa = double.Parse(textBox6.Text) * 1.66667e-5; // L/min to m3/s
            dQa = double.Parse(textBox16.Text) * 1.66667e-5; // L/min to m3/s

            if (checkBox1.Checked)
            {
                Dia_min = double.Parse(textBox11.Text) * 1e-9;
                double Kn = Get_Knudsen(lambda, Dia_min);
                double Cc = Get_Cunningham(Kn, alpha, beta, gamma);
                double mobility = Get_Mobility_from_Diameter(1, e_charge, Cc, viscos, Dia_min);
                Vdma = Get_Voltage_from_Mobility(Qs, Ri, Ro, L, mobility);

                Dia_max = double.Parse(textBox10.Text) * 1e-9; ;
                textBox7.Text = Vdma.ToString();

                stepV = (Dia_max - Dia_min) / double.Parse(textBox19.Text);
            }

            isSimulate = true;
            this.backgroundWorker1.RunWorkerAsync(100);

            if (checkBox1.Checked)
            {
                if(textBox20.Text != "")
                {
                    if (sw == null) sw = new StreamWriter(textBox20.Text);
                    else
                    {
                        sw.Close();
                        sw = new StreamWriter(textBox20.Text);
                    }
                }
                textBox14.Text = "";
                textBox8.Text = "";
                timer1.Enabled = true;
                timer1.Start();
            }
        }
        bool isSimulate = false;
        StreamWriter sw = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isSimulate)
            {
                Vdma = double.Parse(textBox7.Text);
                dVdma = double.Parse(textBox17.Text);
                isSimulate = true;
                this.backgroundWorker1.RunWorkerAsync(100);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            int arg = (int)e.Argument;
            e.Result = TimeConsumingOperation(bw, arg);
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        private int TimeConsumingOperation(BackgroundWorker bw, int arg)
        {
            int progress = 1;
            backgroundWorker1.ReportProgress(progress);

            char[] sparator = { ';', '&' };
            string[] in_mean = textBox13.Text.Split(sparator);
            string[] in_std = textBox12.Text.Split(sparator);
            string[] in_amplitude = textBox9.Text.Split(sparator);

            num_mode = in_mean.Length;

            amplitude = new double[num_mode];
            std = new double[num_mode];
            mean = new double[num_mode];

            double out_type;
            if (num_mode == in_std.Length && num_mode == in_amplitude.Length)
            {
                for (int i = 0; i < num_mode; i++)
                {
                    if (!double.TryParse(in_amplitude[i], out out_type)) return 0;
                    if (!double.TryParse(in_std[i], out out_type)) return 0;
                    if (!double.TryParse(in_mean[i], out out_type)) return 0;

                    amplitude[i] = double.Parse(in_amplitude[i]);
                    std[i] = double.Parse(in_std[i]);
                    mean[i] = double.Parse(in_mean[i]);
                }
            }

            minimum = double.Parse(textBox11.Text);
            maximum = double.Parse(textBox10.Text);
            N = Convert.ToInt32(numericUpDown1.Value);
            data = new double[N];
            dataOut = new double[N];

            Random rand = new Random();

            double sum_pdf = Sum_PDF_Normal(mean, std, amplitude, num_mode);
            int frac = N / 100;
            text_coba = "";
            for (int i = 0; i < N; i++)
            {
                if (checkBox3.Checked) data[i] = 6.0 * (double)i / (double)N;
                else data[i] = x_form_CDF_Normal(rand.NextDouble(), sum_pdf, mean, std, amplitude, num_mode);

                double rx = particleSelected(data[i]);
                if (L - D / 2 < rx && L + D / 2 > rx) dataOut[i] = data[i];
                else dataOut[i] = 0;

                text_coba += rx.ToString() + "\r\n";
                if (i % frac == 0)
                {
                    progress = 100 * i / N;
                    backgroundWorker1.ReportProgress(progress);
                }
            }
            return progress;
        }

        myRandom randomV = new myRandom();
        myRandom randomQs = new myRandom();
        myRandom randomQa = new myRandom();

        string text_coba = "";
        private double particleSelected(double diameter)
        {
            diameter = diameter * 1e-9;
            double ry = Ro;
            double rx = 0;
            double vx = 0;
            double vy = -randomQs.NextGaussian(Qa, dQa); ;
            double ax = 0;
            double ay = 0;
            double dt = 1e-8;
            double mass = Massa(diameter);

            double V_DMA = randomV.NextGaussian(Vdma, dVdma);
            if (V_DMA < 0) V_DMA = Vdma;

            double QS = randomQs.NextGaussian(Qs, dQs);
            if (QS < 0) QS = Qs;
            double vs = QS / (Math.PI * (Math.Pow(Ro, 2) - Math.Pow(Ri, 2))); 

            while (true) {
                // Gaya-gaya
                double Fx = F_Drag(diameter, vs-vx);
                double Fy = -F_Elect(1, ry, V_DMA);

                ax = Fx / mass;
                ay = Fy / mass;
                vx = vx + ax * dt;
                vy = vy + ay * dt;
                rx = rx + vx * dt;
                ry = ry + vy * dt;
                if (ry < Ri) break;
            }
            return rx*1000;
        }


        double viscos = 1.83245e-5;
        double lambda = 67.3e-9;
        double alpha = 1.142;
        double beta = 0.558;
        double gamma = 0.999;
        double e_charge = 1.6021766208e-19;

 
        double massa_jenis = 1000; // kg/m3
        private double Massa(double Dp)
        {
            double volume = 4 * Math.PI * Math.Pow(Dp, 3) / 3;
            return massa_jenis * volume;
        }

        private double Get_Knudsen(double L, double Dp)
        {
            double Kn = 2 * L / Dp;
            return Kn;
        }

        private double Get_Cunningham(double Kn, double alfa, double beta, double gama)
        {
            double Cc = 1 + Kn * (alfa + beta * Math.Exp(-gama / Kn));
            return Cc;
        }

        // Drag Force
        double F_Drag(double dp, double v)
        {
            double Kn = Get_Knudsen(lambda, dp);
            double Cc = Get_Cunningham(Kn, alpha, beta, gamma);
            double F = 3 * Math.PI * viscos * v * dp / Cc;
            return F;
        }

        private void textBox20_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text File|*.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                textBox20.Text = sf.FileName;
            }
        }

        // Electric Force
        double F_Elect(int n, double r, double V)
        {
            double F = n * e_charge * V / (r * Math.Log(Ro/Ri));
            return F;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            chart1.Series["Input"].Points.Clear();
            chart1.Series["Output"].Points.Clear();

            int NOut = 0;
            for(int i = 0; i< N; i++)
            {
                if (dataOut[i] != 0) NOut++;
            }




            // Sorting
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (data[i] > data[j])
                    {
                        double tempD = data[i];
                        data[i] = data[j];
                        data[j] = tempD;
                    }
                }
            }




            double bup = (data[N - 1] - data[0]) / (1 + Math.Sqrt(N));

            double start = data[0] % bup;
            double end = data[N - 1] % bup;
            int indexCek = 0;

            text_out1 = "";
            for (double xx = data[0] - start; xx <= data[N - 1] + bup - end; xx += bup)
            {
                int freq = 0;
                for (int i = indexCek; i < N; i++)
                {
                    if (data[i] < xx + bup)
                    {
                        freq++;
                        indexCek++;
                    }
                    else
                    {
                        double xi = xx + bup / 2;
                        text_out1 += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Input"].Points.AddXY(xi, freq);
                        break;
                    }
                    if (indexCek == N)
                    {
                        double xi = xx + bup / 2;
                        text_out1 += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Input"].Points.AddXY(xi, freq);
                    }
                }
                
            }

            if (NOut < 1)
            {
                if (checkBox1.Checked)
                {
                    double mobility = Get_Mobility_from_Voltage(Qs, Ri, Ro, L, Vdma);
                    double diameter = Mobiliy_to_Diameter(1, e_charge, lambda, viscos, alpha, beta, gamma, mobility);

                    string dataSave = Vdma.ToString() + "\t" + diameter.ToString() + "\t" + 0.ToString() + "\r\n";
                    diameter *= 1e-9;
                    textBox14.Text += dataSave;
                    if (sw != null) sw.Write(dataSave);

                    diameter += stepV;
                    double Kn = Get_Knudsen(lambda, diameter);
                    double Cc = Get_Cunningham(Kn, alpha, beta, gamma);
                    mobility = Get_Mobility_from_Diameter(1, e_charge, Cc, viscos, diameter);
                    Vdma = Get_Voltage_from_Mobility(Qs, Ri, Ro, L, mobility);

                    if (diameter > Dia_max)
                    {
                        timer1.Stop();
                        timer1.Enabled = false;
                        textBox8.Text += "\r\n#" + textBox7.Text + "\r\n" + text_out1;
                        if (sw != null)
                        {
                            sw.Write(textBox8.Text);
                            sw.Close();
                            sw = null;
                        }
                    }
                    else textBox7.Text = Vdma.ToString();
                    isSimulate = false;
                    return;
                }
                else MessageBox.Show("No Result");
                return;
            }

            double[] new_dataOut = new double[NOut];
            int indexOut = 0;
            for (int i = 0; i < N; i++)
            {
                if (dataOut[i] != 0)
                {
                    new_dataOut[indexOut] = dataOut[i];
                    indexOut++;
                }
            }
            for (int i = 0; i < NOut; i++)
            {
                for (int j = i; j < NOut; j++)
                {
                    if (new_dataOut[i] > new_dataOut[j])
                    {
                        double tempD = new_dataOut[i];
                        new_dataOut[i] = new_dataOut[j];
                        new_dataOut[j] = tempD;
                    }
                }
            }

            double bupOut = (new_dataOut[NOut - 1] - new_dataOut[0]) / (1 + Math.Sqrt(NOut));

            double startOut = new_dataOut[0] % bupOut;
            double endOut = new_dataOut[NOut - 1] % bupOut;
            int indexCekOut = 0;

            text_out2= "";
            int totalFreq = 0;
            for (double xx = new_dataOut[0] - startOut; xx <= new_dataOut[NOut - 1] + bupOut - endOut; xx += bupOut)
            {
                int freq = 0;
                for (int i = indexCekOut; i < NOut; i++)
                {
                    if (new_dataOut[i] < xx + bupOut)
                    {
                        freq++;
                        indexCekOut++;
                    }
                    else
                    {
                        double xi = xx + bupOut / 2;
                        text_out2 += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Output"].Points.AddXY(xi, freq);
                        break;
                    }
                    if (indexCekOut == NOut)
                    {
                        double xi = xx + bupOut / 2;
                        text_out2 += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Output"].Points.AddXY(xi, freq);
                    }
                }
                totalFreq += freq;
            }


            if (checkBox1.Checked)
            {
                double mobility = Get_Mobility_from_Voltage(Qs, Ri, Ro, L, Vdma);
                double diameter = Mobiliy_to_Diameter(1, e_charge, lambda, viscos, alpha, beta, gamma, mobility);
                string dataSave = Vdma.ToString() + "\t" + diameter.ToString() + "\t" + totalFreq.ToString() + "\r\n";
                textBox14.Text += dataSave;
                diameter *= 1e-9;
                textBox8.Text += "\r\n#" + textBox7.Text + "\r\n" + text_out2;
                if (sw != null) sw.Write(dataSave);

                diameter += stepV;
                double Kn = Get_Knudsen(lambda, diameter);
                double Cc = Get_Cunningham(Kn, alpha, beta, gamma);
                mobility = Get_Mobility_from_Diameter(1, e_charge, Cc, viscos, diameter);
                Vdma = Get_Voltage_from_Mobility(Qs, Ri, Ro, L, mobility);
                
                if (diameter > Dia_max)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    textBox8.Text += "\r\n#" + textBox7.Text + "\r\n" + text_out1;
                    if (sw != null)
                    {
                        sw.Write(textBox8.Text);
                        sw.Close();
                        sw = null;
                    }
                }
                else textBox7.Text = Vdma.ToString();
                isSimulate = false;
                return;
            }
            else
            {
                textBox8.Text = text_out1;
                textBox14.Text = text_out2;
            }
        }

        private double Mobiliy_to_Diameter(double n, double e, double lambda, double mu, double alfa, double beta, double gama, double Zp)
        {
            double Dp = 0;
            double Kn;
            double Cc;
            double DpCal;
            double err_tol = 1e-11;
            do
            {
                Dp += err_tol / 2;
                Kn = Get_Knudsen(lambda, Dp);
                Cc = Get_Cunningham(Kn, alfa, beta, gama);
                DpCal = Get_Diameter_from_Mobility(n, e, Cc, mu, Zp);
            }
            while (Math.Abs(Dp - DpCal) > err_tol);

            return Dp * 1e9;
        }

        // Voltage to Mobility
        double pi = Math.PI;
        private double Get_Mobility_from_Voltage(double Qs, double R1, double R2, double L, double V)
        {
            double Zp = Qs * Math.Log(R2 / R1) / (2 * pi * L * V);
            return Zp;
        }
        private double Get_Voltage_from_Mobility(double Qs, double R1, double R2, double L, double Zp)
        {
            double V = Qs * Math.Log(R2 / R1) / (2 * pi * L * Zp);
            return V;
        }
        private double Get_Diameter_from_Mobility(double n, double e, double Cc, double mu, double Zp)
        {
            double Dp = n * e * Cc / (3 * pi * mu * Zp);
            return Dp;
        }
        private double Get_Mobility_from_Diameter(double n, double e, double Cc, double mu, double Dp)
        {
            double Zp = n * e * Cc / (3 * pi * mu * Dp);
            return Zp;
        }
    }
}
