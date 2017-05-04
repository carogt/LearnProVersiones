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
    public partial class SigueInt : Form
    {
        public SigueInt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Global.entrada == 1)
            {
                this.Hide();
                FacilMat f = new FacilMat();
                f.ShowDialog();
            }
            else if (Global.entrada == 2)
            {
                this.Hide();
                MedioMat m = new MedioMat();
                m.ShowDialog();
            }
            else if (Global.entrada == 3)
            {
                this.Hide();
                DificilMat d = new DificilMat();
                d.ShowDialog();
            }


        }
    }
}
