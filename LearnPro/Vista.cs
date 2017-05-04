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
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Global.Cocina == true)
            {
                Global.Cocina = false;
                this.Hide();
                Cocina Coc = new Cocina();
                Coc.ShowDialog();
                this.Close();
            }
            else if (Global.Baño == true)
            {

                Global.Baño = false;
                this.Hide();
                Baño Ban = new Baño();
                Ban.ShowDialog();
                this.Close();
            }
            else if (Global.Recamara == true)
            {
                Global.Recamara = false;
                this.Hide();
                Recamara Ban = new Recamara();
                Ban.ShowDialog();
                this.Close();
            }
            else if (Global.Sala == true)
            {
                Global.Sala = false;
                this.Hide();
                Sala Ban = new Sala();
                Ban.ShowDialog();
                this.Close();
            }

        }
        public void Actualizar()
        {
            if (Global.refri == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\refrig.jpg");
                label1.Text = "Refrigerador";
                Global.refri = false;
            }
            else if (Global.micro == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\micro.jpg");
                label1.Text = "Microondas";
                Global.micro = false;
            }
            else if (Global.LavaPla == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Lava Platos.jpg");
                label1.Text = "Lava Platos";
                Global.LavaPla = false;
            }
            else if (Global.estufa == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\estufa.jpg");
                label1.Text = "Estufa";
                Global.estufa = false;
            }
            else if (Global.cuchillo == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\cuchillo.jpg");
                label1.Text = "Cuchillo";
                Global.cuchillo = false;
            }
            else if (Global.Inodoro == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Inodoro.png");
                label1.Text = "Inodoro";
                Global.Inodoro = false;
            }
            else if (Global.LavaMan == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\LavaMan.png");
                label1.Text = "Lava Manos";
                Global.LavaMan = false;
            }
            else if (Global.Tina == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Tina.png");
                label1.Text = "Tina";
                Global.Tina = false;
            }
            else if (Global.Regadera == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Regadera.png");
                label1.Text = "Regadera";
                Global.Regadera = false;
            }
            else if (Global.Espejo == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Espejo.png");
                label1.Text = "Espejo";
                Global.Espejo = false;
            }
            else if (Global.Ventana == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Ventana.png");
                label1.Text = "Ventana";
                Global.Ventana = false;
            }
            else if (Global.LavaPla == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Lava Platos.jpg");
                label1.Text = "Lava Platos";
                Global.LavaPla = false;
            }
            else if (Global.Cuchara == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\cuchara.png");
                label1.Text = "Cuchara";
                Global.Cuchara = false;
            }
            else if (Global.tenedor == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\tenedor.png");
                label1.Text = "Tenedor";
                Global.tenedor = false;
            }
            else if (Global.olla == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\olla.png");
                label1.Text = "Olla";
                Global.olla = false;
            }
            else if (Global.Cama == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\cama.png");
                label1.Text = "Cama";
                Global.Cama = false;
            }
            else if (Global.Buro == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Buro.png");
                label1.Text = "Buro";
                Global.Buro = false;
            }
            else if (Global.Cajonera == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\cajonera.png");
                label1.Text = "Cajonera";
                Global.Cajonera = false;
            }
            else if (Global.TV == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\TV.png");
                label1.Text = "Television";
                Global.TV = false;
            }
            else if (Global.Sofa == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Sofa.png");
                label1.Text = "Sofa";
                Global.Sofa = false;
            }
            else if (Global.MesaC == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\MesaCafe.png");
                label1.Text = "Mesa de Cafe";
                Global.MesaC = false;
            }
            else if (Global.Control == true)
            {
                this.pictureBox1.Image = System.Drawing.Image.FromFile(@"Resources\Control.png");
                label1.Text = "Control Remoto";
                Global.Control = false;
            }
           
        }
    }
}
