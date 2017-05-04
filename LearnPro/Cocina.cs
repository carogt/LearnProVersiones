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
    public partial class Cocina : Form
    {
        public Cocina()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Global.refri == false){
                Global.refri = true;
                Global.Cocina = true;
            }
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Global.micro == false)
            {
                Global.micro = true;
                Global.Cocina = true;
            }
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Global.estufa == false)
            {
                Global.estufa = true;
                Global.Cocina = true;
            }
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Global.silla == false)
            {
                Global.silla = true;
                Global.Cocina = true;
            }
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Global.cuchillo == false)
            {
                Global.cuchillo = true;
                Global.Cocina = true;
            }
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void Cocina_Load(object sender, EventArgs e)
        {
            Global.Cocina = true;
            Global.Sala = false;
            Global.Recamara = false;
            Global.Baño = false;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Global.LavaPla = true;
            Global.Cocina = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Global.tenedor = true;
            Global.Cocina = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Global.Cuchara = true;
            Global.Cocina = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Global.olla = true;
            Global.Cocina = true;
            this.Hide();
            Vista RU = new Vista();
            RU.ShowDialog();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa RU = new Casa();
            RU.ShowDialog();
            this.Close();
        }
    }
}
