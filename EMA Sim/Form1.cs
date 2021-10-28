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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 particleGenerator = null;
        private void particleGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (particleGenerator == null)
            {
                particleGenerator = new Form2();
                particleGenerator.MdiParent = this;
                particleGenerator.FormClosed += ParticleGenerator_FormClosed;
                particleGenerator.Show();
            }
            {
                particleGenerator.Activate();
            }
        }

        private void ParticleGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            particleGenerator = null;
        }

        Form3 movParticle = null;
        private void movingParticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movParticle == null)
            {
                movParticle = new Form3();
                movParticle.MdiParent = this;
                movParticle.FormClosed += MovParticle_FormClosed;
                movParticle.Show();
            }
            {
                movParticle.Activate();
            }
        }

        private void MovParticle_FormClosed(object sender, FormClosedEventArgs e)
        {
            movParticle = null;
        }
    }
}
