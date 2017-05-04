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
    public partial class Sala : Form
    {
        public Sala()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Global.Control = true;
            Global.Sala = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Global.Sofa = true;
            Global.Sala = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Global.MesaC = true;
            Global.Sala = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Global.TV = true;
            Global.Sala = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa RU = new Casa();
            RU.ShowDialog();
            this.Close();
        }

        private void Sala_Load(object sender, EventArgs e)
        {
            Global.Cocina = false;
            Global.Sala = true;
            Global.Recamara = false;
            Global.Baño = false;
        }
    }
}
