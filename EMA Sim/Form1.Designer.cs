namespace EMA_Sim
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.particleGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movingParticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.particleGeneratorToolStripMenuItem,
            this.movingParticleToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(90, 22);
            this.toolStripSplitButton1.Text = "Simulator";
            // 
            // particleGeneratorToolStripMenuItem
            // 
            this.particleGeneratorToolStripMenuItem.Name = "particleGeneratorToolStripMenuItem";
            this.particleGeneratorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.particleGeneratorToolStripMenuItem.Text = "Particle Generator";
            this.particleGeneratorToolStripMenuItem.Click += new System.EventHandler(this.particleGeneratorToolStripMenuItem_Click);
            // 
            // movingParticleToolStripMenuItem
            // 
            this.movingParticleToolStripMenuItem.Name = "movingParticleToolStripMenuItem";
            this.movingParticleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.movingParticleToolStripMenuItem.Text = "Moving Particle";
            this.movingParticleToolStripMenuItem.Click += new System.EventHandler(this.movingParticleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 462);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "EMS :: Electrical Mobility Analyzer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem particleGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movingParticleToolStripMenuItem;
    }
}

