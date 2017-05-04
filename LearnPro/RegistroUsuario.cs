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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Debe Llenar los Campos");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Las Contraseñas deben coincidir");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (textBox2.Text == textBox3.Text && textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != "")
            {
                if (UsuarioDal.CrearCuentas(textBox1.Text, textBox2.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada Con Exito");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Hubo Un Error");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login Log = new Login();
            Log.ShowDialog();
            this.Close();
        }


     
       
    }
}
