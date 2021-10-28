using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMA_Sim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerReportsProgress = true;
        }

        private void normal_Click(object sender, EventArgs e)
        {

        }

        double[] yCFD;
        double[] xCFD;
        int indexCFD;


        double[] amplitude;
        double[] std;
        double[] mean;
        double[] data;
        int num_mode;
        int N = 0;
        double minimum = 0;
        double maximum = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync(100);
        }

        private double PDF_Normal(double x, double[] mu, double[] sg, double[] A, int mode)
        {
            double result = 0;
            for(int i = 0; i < mode; i++)
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
            for (double x = minimum; x < maximum; x+=step)
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

        string text_out = "";
        private int TimeConsumingOperation(BackgroundWorker bw, int arg)
        {
            int progress = 1;
            backgroundWorker1.ReportProgress(progress);

            char[] sparator = { ';', '&' };
            string[] in_mean = textBox2.Text.Split(sparator);
            string[] in_std = textBox3.Text.Split(sparator);
            string[] in_amplitude = textBox4.Text.Split(sparator);

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
            maximum = double.Parse(textBox12.Text);
            N = Convert.ToInt32(numericUpDown1.Value);
            data = new double[N];
            Random rand = new Random();

            double sum_pdf = Sum_PDF_Normal(mean, std, amplitude, num_mode);
            int frac = N / 100;
            for (int i = 0; i < N; i++)
            {
                data[i] = x_form_CDF_Normal(rand.NextDouble(), sum_pdf, mean, std, amplitude, num_mode);
                if (i % frac == 0)
                {
                    progress = 100 * i / N;
                    backgroundWorker1.ReportProgress(progress);
                }
            }

            return progress;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            chart1.Series["Data"].Points.Clear();

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

            double bup = (data[N-1] - data[0]) / (1+Math.Sqrt(N));
            
            double start = data[0] % bup;
            double end = data[N - 1] % bup;
            int indexCek = 0;

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
                        text_out += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Data"].Points.AddXY(xi, freq);
                        break;
                    }
                    if (indexCek == N)
                    {
                        double xi = xx + bup / 2;
                        text_out += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Data"].Points.AddXY(xi, freq);
                    }
                }
            }

            textBox5.Text = text_out;

            chart1.Series["Function"].Points.Clear();
            string text_out2 = "";
            for (double yy = minimum; yy < maximum; yy += 0.01)
            {
                double rr = PDF_Normal(yy, mean, std, amplitude, num_mode);
                text_out2 += rr.ToString() + "\r\n";
                chart1.Series["Function"].Points.AddXY(yy, rr);
            }

            progressBar1.Value = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.backgroundWorker2.RunWorkerAsync(100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            int arg = (int)e.Argument;
            e.Result = TimeConsumingOperation2(bw, arg);
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        private int TimeConsumingOperation2(BackgroundWorker bw, int arg)
        {
            int progress = 1;
            
            backgroundWorker2.ReportProgress(progress);

            char[] sparator = { ';', '&' };
            string[] in_mean = textBox9.Text.Split(sparator);
            string[] in_std = textBox8.Text.Split(sparator);
            string[] in_amplitude = textBox7.Text.Split(sparator);

            num_mode = in_mean.Length;

            amplitude = new double[num_mode];
            std = new double[num_mode];
            mean = new double[num_mode];

            minimum = double.Parse(textBox6.Text);
            maximum = double.Parse(textBox10.Text);
            N = Convert.ToInt32(numericUpDown2.Value);
            
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


            data = new double[N];
            Random rand = new Random();

            double sum_pdf = Sum_PDF_LogNormal(mean, std, amplitude, num_mode);
            int frac = N / 100;
            for (int i = 0; i < N; i++)
            {
                data[i] = x_form_CDF_LogNormal(rand.NextDouble(), sum_pdf, mean, std, amplitude, num_mode);
                if (i % frac == 0)
                {
                    progress = 100 * i / N;
                    backgroundWorker2.ReportProgress(progress);
                }
            }
            
            return progress;
        }


        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            chart1.Series["Data"].Points.Clear();

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
                        text_out += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Data"].Points.AddXY(xi, freq);
                        break;
                    }
                    if (indexCek == N)
                    {
                        double xi = xx + bup / 2;
                        text_out += xi.ToString() + "\t" + freq.ToString() + "\r\n";
                        chart1.Series["Data"].Points.AddXY(xi, freq);
                    }
                }
            }

            textBox13.Text = text_out;

            chart1.Series["Function"].Points.Clear();
            string text_out2 = "";
            for (double yy = minimum; yy < maximum; yy += 0.01)
            {
                double rr = PDF_LogNormal(yy, mean, std, amplitude, num_mode);
                text_out2 += rr.ToString() + "\r\n";
                chart1.Series["Function"].Points.AddXY(yy, rr);
            }

            progressBar2.Value = 100;
        }
    }
}
