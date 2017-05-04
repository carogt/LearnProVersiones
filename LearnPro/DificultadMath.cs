using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnPro
{
    public partial class DificultadMath : Form
    {
        public DificultadMath()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacilMat Fmat = new FacilMat();
            Fmat.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedioMat Mmat = new MedioMat();
            Mmat.ShowDialog();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DificilMat Mmat = new DificilMat();
            Mmat.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modulos Mmat = new Modulos();
            Mmat.ShowDialog();
            this.Close();
        }
    }
}
