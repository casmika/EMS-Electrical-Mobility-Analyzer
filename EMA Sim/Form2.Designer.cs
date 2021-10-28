namespace EMA_Sim
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.normal = new System.Windows.Forms.TabPage();
            this.Lognormal = new System.Windows.Forms.TabPage();
            this.Manual = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.normal.SuspendLayout();
            this.Lognormal.SuspendLayout();
            this.Manual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(294, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 48);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open Distribution";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.normal);
            this.tabControl1.Controls.Add(this.Lognormal);
            this.tabControl1.Controls.Add(this.Manual);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(276, 341);
            this.tabControl1.TabIndex = 1;
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.SystemColors.Control;
            this.normal.Controls.Add(this.label10);
            this.normal.Controls.Add(this.textBox11);
            this.normal.Controls.Add(this.label11);
            this.normal.Controls.Add(this.textBox12);
            this.normal.Controls.Add(this.textBox5);
            this.normal.Controls.Add(this.progressBar1);
            this.normal.Controls.Add(this.numericUpDown1);
            this.normal.Controls.Add(this.button4);
            this.normal.Controls.Add(this.label2);
            this.normal.Controls.Add(this.button3);
            this.normal.Controls.Add(this.textBox2);
            this.normal.Controls.Add(this.button2);
            this.normal.Controls.Add(this.label1);
            this.normal.Controls.Add(this.textBox3);
            this.normal.Controls.Add(this.label4);
            this.normal.Controls.Add(this.label3);
            this.normal.Controls.Add(this.textBox4);
            this.normal.Location = new System.Drawing.Point(4, 22);
            this.normal.Name = "normal";
            this.normal.Padding = new System.Windows.Forms.Padding(3);
            this.normal.Size = new System.Drawing.Size(268, 315);
            this.normal.TabIndex = 0;
            this.normal.Text = "Normal";
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // Lognormal
            // 
            this.Lognormal.BackColor = System.Drawing.SystemColors.Control;
            this.Lognormal.Controls.Add(this.label12);
            this.Lognormal.Controls.Add(this.textBox6);
            this.Lognormal.Controls.Add(this.label13);
            this.Lognormal.Controls.Add(this.textBox10);
            this.Lognormal.Controls.Add(this.textBox13);
            this.Lognormal.Controls.Add(this.progressBar2);
            this.Lognormal.Controls.Add(this.button5);
            this.Lognormal.Controls.Add(this.button6);
            this.Lognormal.Controls.Add(this.button7);
            this.Lognormal.Controls.Add(this.numericUpDown2);
            this.Lognormal.Controls.Add(this.label5);
            this.Lognormal.Controls.Add(this.textBox7);
            this.Lognormal.Controls.Add(this.label6);
            this.Lognormal.Controls.Add(this.textBox8);
            this.Lognormal.Controls.Add(this.label7);
            this.Lognormal.Controls.Add(this.textBox9);
            this.Lognormal.Controls.Add(this.label8);
            this.Lognormal.Location = new System.Drawing.Point(4, 22);
            this.Lognormal.Name = "Lognormal";
            this.Lognormal.Padding = new System.Windows.Forms.Padding(3);
            this.Lognormal.Size = new System.Drawing.Size(268, 315);
            this.Lognormal.TabIndex = 1;
            this.Lognormal.Text = "Lognormal";
            // 
            // Manual
            // 
            this.Manual.BackColor = System.Drawing.SystemColors.Control;
            this.Manual.Controls.Add(this.label14);
            this.Manual.Controls.Add(this.textBox14);
            this.Manual.Controls.Add(this.label15);
            this.Manual.Controls.Add(this.textBox15);
            this.Manual.Controls.Add(this.textBox16);
            this.Manual.Controls.Add(this.progressBar3);
            this.Manual.Controls.Add(this.numericUpDown3);
            this.Manual.Controls.Add(this.label9);
            this.Manual.Controls.Add(this.button1);
            this.Manual.Controls.Add(this.textBox1);
            this.Manual.Controls.Add(this.button8);
            this.Manual.Controls.Add(this.button9);
            this.Manual.Controls.Add(this.button10);
            this.Manual.Location = new System.Drawing.Point(4, 22);
            this.Manual.Name = "Manual";
            this.Manual.Padding = new System.Windows.Forms.Padding(3);
            this.Manual.Size = new System.Drawing.Size(268, 315);
            this.Manual.TabIndex = 2;
            this.Manual.Text = "Manual";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(186, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(186, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(186, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Run";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(68, 10);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown2.TabIndex = 22;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "N";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(68, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(102, 20);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "1;3;2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Amplitude";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(68, 62);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(102, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.Text = "1.2; 1.1; 1.05";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Geo. Std.";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(68, 36);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(102, 20);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "1;5; 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Geo. Mean";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(186, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(186, 60);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 23);
            this.button9.TabIndex = 24;
            this.button9.Text = "Stop";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(186, 34);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 23);
            this.button10.TabIndex = 23;
            this.button10.Text = "Run";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 195);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(246, 113);
            this.textBox5.TabIndex = 27;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 23);
            this.progressBar1.TabIndex = 26;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mean";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "1; 2; 3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Std. Dev.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "0.1; 0.15; 0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amplitude";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "1; 3; 2";
            // 
            // chart1
            // 
            chartArea15.AxisX.MajorGrid.Enabled = false;
            chartArea15.AxisY.MajorGrid.Enabled = false;
            chartArea15.AxisY2.MajorGrid.Enabled = false;
            chartArea15.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea15);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.DockedToChartArea = "ChartArea1";
            legend15.Name = "Legend1";
            this.chart1.Legends.Add(legend15);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            series29.BorderColor = System.Drawing.Color.Black;
            series29.ChartArea = "ChartArea1";
            series29.Color = System.Drawing.Color.Gray;
            series29.CustomProperties = "PointWidth=1";
            series29.Legend = "Legend1";
            series29.Name = "Data";
            series29.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series30.BorderWidth = 3;
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series30.Color = System.Drawing.Color.Red;
            series30.Legend = "Legend1";
            series30.Name = "Function";
            this.chart1.Series.Add(series29);
            this.chart1.Series.Add(series30);
            this.chart1.Size = new System.Drawing.Size(579, 318);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(78, 8);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown3.TabIndex = 29;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "N";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Minimum";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(68, 114);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(102, 20);
            this.textBox11.TabIndex = 29;
            this.textBox11.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Maximum";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(68, 140);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(102, 20);
            this.textBox12.TabIndex = 31;
            this.textBox12.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Minimum";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(102, 20);
            this.textBox6.TabIndex = 35;
            this.textBox6.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Maximum";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(68, 140);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(102, 20);
            this.textBox10.TabIndex = 37;
            this.textBox10.Text = "10";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(13, 195);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(246, 113);
            this.textBox13.TabIndex = 33;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(13, 166);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(246, 23);
            this.progressBar2.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Minimum";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(68, 114);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(102, 20);
            this.textBox14.TabIndex = 35;
            this.textBox14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Maximum";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(68, 140);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(102, 20);
            this.textBox15.TabIndex = 37;
            this.textBox15.Text = "10";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(13, 195);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(246, 113);
            this.textBox16.TabIndex = 33;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(13, 166);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(246, 23);
            this.progressBar3.TabIndex = 32;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 364);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Particle Generator";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.normal.ResumeLayout(false);
            this.normal.PerformLayout();
            this.Lognormal.ResumeLayout(false);
            this.Lognormal.PerformLayout();
            this.Manual.ResumeLayout(false);
            this.Manual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage normal;
        private System.Windows.Forms.TabPage Lognormal;
        private System.Windows.Forms.TabPage Manual;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}