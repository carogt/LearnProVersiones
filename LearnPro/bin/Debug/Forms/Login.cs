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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin12")
            {
                this.Hide();
                RegistroUsuario RU = new RegistroUsuario();
                RU.ShowDialog();
                this.Close();
            }
            else
            {
                if (UsuarioDal.Autentificar(TextBox1.Text, TextBox2.Text) > 0)
                {
                    this.Hide();
                    Modulos Mo = new Modulos();
                    Mo.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esta mal el usuario y/o la contraseña");
                }
            }
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
     


       
    }
}
