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
            if (textBox2.Text == textBox3.Text)
            {
                if (UsuarioDal.CrearCuentas(textBox1.Text, textBox2.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada Con Exito");
                }
                else
                {
                    MessageBox.Show("Hubo Un Error");
                }
            }
            else
            {
                MessageBox.Show("Contraseñas No Coinciden");
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
