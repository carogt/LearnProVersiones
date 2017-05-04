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
    public partial class Recamara : Form
    {
        public Recamara()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Global.Cama = true;
            Global.Recamara = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Global.Cajonera = true;
            Global.Recamara = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Global.Ventana = true;
            Global.Recamara = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Global.Buro = true;
            Global.Recamara = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void Recamara_Load(object sender, EventArgs e)
        {
            Global.Cocina = false;
            Global.Sala = false;
            Global.Recamara = true;
            Global.Baño = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa RU = new Casa();
            RU.ShowDialog();
            this.Close();
        }
    }
}
