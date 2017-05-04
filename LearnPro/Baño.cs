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
    public partial class Baño : Form
    {
        public Baño()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Global.Baño = true;
            Global.Inodoro = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Global.Baño = true;
            Global.Inodoro = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Global.Baño = true;
            Global.LavaMan = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Global.Baño = true;
            Global.Tina = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Global.Regadera = true;
            Global.Baño = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Global.Espejo = true;
            Global.Baño = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void Baño_Load(object sender, EventArgs e)
        {
            Global.Baño = true;
            Global.Sala = false;
            Global.Recamara = false;
            Global.Cocina = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa Casa = new Casa();
            Casa.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Transparent;
        }
    }
}
