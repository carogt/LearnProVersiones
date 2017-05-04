using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace LearnPro
{
    public partial class DificilMat : Form
    {
        private string path;

        public DificilMat()
        {
            InitializeComponent();
        }

        public DificilMat(string path)
        {
            // TODO: Complete member initialization
            this.path = path;
        }

        private void DificilMat_Load(object sender, EventArgs e)
        {
            
            Random r = new Random();
            float resultadomul;
            float resultadodiv;
            float aleatorio1 = r.Next(1, 10);
            string con1 = aleatorio1.ToString();
            float aleatorio2 = r.Next(1, 10);
            string con3 = aleatorio2.ToString();
            float aleatorio3 = r.Next(1, 3);
            float aleatorio4 = r.Next(1, 100);
            string Error1 = aleatorio4.ToString();
            float  aleatorio5 = r.Next(1, 100);
            string Error2 = aleatorio5.ToString();
            resultadomul = aleatorio1 * aleatorio2;
            float aleatorio6 = r.Next(1, 10);
            if (aleatorio6 >= 1 && aleatorio6 <= 5)
            {
                label2.Text = "*";
                label1.Text = con1;
                label3.Text = con3;
                Global.result = resultadomul.ToString();
            }
            else if (aleatorio6 >= 6 && aleatorio6 <= 10)
            {
                label2.Text = "/";
                label1.Text = con1;
                label3.Text = con3;
                if (aleatorio1 >= aleatorio2)
                {
                    resultadodiv = aleatorio1 / aleatorio2;
                    aleatorio4 = aleatorio4 / 2;
                    Error1 = aleatorio4.ToString();
                    aleatorio5 = aleatorio4 / 3;
                    Error2 = aleatorio5.ToString();
                    label1.Text = con1;
                    label3.Text = con3;
                    Global.result = resultadodiv.ToString();
                }
                else if (aleatorio2 >= aleatorio1)
                {
                    resultadodiv = aleatorio2 / aleatorio1;
                    aleatorio4 = aleatorio4 / 2;
                    Error1 = aleatorio4.ToString();
                    aleatorio5 = aleatorio4 / 3;
                    Error2 = aleatorio5.ToString();
                    label1.Text = con3;
                    label3.Text = con1;
                    Global.result = resultadodiv.ToString();
                }
            }
            Global.txresult = Global.result;
            if (aleatorio3 == 1)
            {
                while (Error1 == Global.result || Error2 == Global.result)
                {
                    if (Error1 == Global.result)
                    {
                        aleatorio4 = r.Next(1, 100);
                        aleatorio4 = aleatorio4 / 2;
                        Error1 = aleatorio4.ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 100);
                        aleatorio5 = aleatorio4 / 3;
                        Error2 = aleatorio5.ToString();
                    }
                    label5.Text = Error1;
                    label6.Text = Error2;
                }
                label5.Text = Error1;
                label4.Text = Global.result;
                label6.Text = Error2;
            }
            else if (aleatorio3 == 2)
            {

                label5.Text = Global.result;

                while (Error1 == Global.result || Error2 == Global.result)
                {
                    if (Error1 == Global.result)
                    {
                        aleatorio4 = r.Next(1, 20);
                        Error1 = aleatorio4.ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 20);
                        Error2 = aleatorio5.ToString();
                    }
                    label4.Text = Error1;
                    label6.Text = Error2;
                }
                label4.Text = Error1;
                label6.Text = Error2;

            }
            else if (aleatorio3 == 3)
            {

                label6.Text = Global.result;
                while (label5.Text == Global.result || label6.Text == Global.result)
                {
                    if (Error1 == Global.result)
                    {
                        aleatorio4 = r.Next(1, 20);
                        Error1 = aleatorio4.ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 20);
                        Error2 = aleatorio5.ToString();
                    }
                    label5.Text = Error1;
                    label4.Text = Error2;
                }
                label5.Text = Error1;
                label4.Text = Error2;
            }
        }
        private void playSimpleSound()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Recursos\BuenTrabajo.wav");
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
            MessageBox.Show("Bien Hecho");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Global.txresult == label4.Text)
            {
                playSimpleSound();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms\DificilMat.cs");
                path = Path.GetFullPath(path);
                StreamReader Obj = new StreamReader(path);
                Obj.Read();
            }
            else
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms\DificilMat.cs");
                DificilMat ner = new DificilMat(path);
                ner.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (Global.txresult == label5.Text)
            {
                playSimpleSound();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms\DificilMat.cs");
                path = Path.GetFullPath(path);
                StreamReader Obj = new StreamReader(path);
                Obj.Read();
            }
            else
            {
                this.Hide();
                Global.entrada = 3;
                SigueInt matf = new SigueInt();
                matf.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (Global.txresult == label6.Text)
            {
                playSimpleSound();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Forms\DificilMat.cs");
                path = Path.GetFullPath(path);
                StreamReader Obj = new StreamReader(path);
                Obj.Read();
            }
            else
            {
                this.Hide();
                Global.entrada = 3;
                SigueInt matf = new SigueInt();
                matf.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Refresh();
        }

       
    }

}