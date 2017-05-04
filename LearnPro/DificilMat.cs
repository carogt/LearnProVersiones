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
           Actualizacion();
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
                Actualizacion();
            }
            else
            {
                Actualizacion();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (Global.txresult == label5.Text)
            {
                playSimpleSound();
                Actualizacion();
            }
            else
            {
                Actualizacion();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (Global.txresult == label6.Text)
            {
                playSimpleSound();
                Actualizacion();
            }
            else
            {
                Actualizacion();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DificultadMath Fmat = new DificultadMath();
            Fmat.ShowDialog();
            this.Close();
        }
        public void Actualizacion()
        {
            Random r = new Random();
            decimal resultadomul;
            decimal resultadodiv;
            int decimals = 2;
            decimal[] pen = { '0', '0', '0' };
            decimal aleatorio1 = r.Next(1, 10);
            string con1 = aleatorio1.ToString();
            decimal aleatorio2 = r.Next(1, 10);
            string con3 = aleatorio2.ToString();
            decimal aleatorio3 = r.Next(1, 3);
            decimal aleatorio4 = r.Next(1, 100);
            string Error1 = aleatorio4.ToString();
            decimal aleatorio5 = r.Next(1, 100);
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
                    pen[0] = Decimal.Round(resultadodiv, decimals);
                    aleatorio4 = aleatorio4 / 2;
                    pen[1] = Decimal.Round(aleatorio4, decimals);
                    Error1 = pen[1].ToString();
                    aleatorio5 = aleatorio5 / 3;
                    pen[2] = Decimal.Round(aleatorio5, decimals);
                    Error2 = pen[2].ToString();
                    label1.Text = con1;
                    label3.Text = con3;
                    Global.result = pen[0].ToString();
                }
                else if (aleatorio2 >= aleatorio1)
                {
                    resultadodiv = aleatorio2 / aleatorio1;
                    pen[0] = Decimal.Round(resultadodiv, decimals);
                    aleatorio4 = aleatorio4 / 2;
                    pen[1] = Decimal.Round(aleatorio4, decimals);
                    Error1 = aleatorio4.ToString();
                    aleatorio5 = aleatorio5 / 3;
                    pen[2] = Decimal.Round(aleatorio5, decimals);
                    Error2 = aleatorio5.ToString();
                    label1.Text = con3;
                    label3.Text = con1;
                    Global.result = pen[0].ToString();
                }
            }
            Global.txresult = Global.result;
            if (aleatorio3 == 1)
            {
                while (Error1 == Global.result || Error2 == Global.result)
                {
                    if (Error1 == Global.result)
                    {
                        aleatorio4 = r.Next(1, 20);
                        aleatorio4 = aleatorio4 / 2;
                        pen[1] = Decimal.Round(aleatorio4, decimals);
                        Error1 = pen[1].ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 20);
                        aleatorio5 = aleatorio4 / 3;
                        pen[2] = Decimal.Round(aleatorio5, decimals);
                        Error2 = pen[2].ToString();
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
                        aleatorio4 = aleatorio4 / 2;
                        pen[1] = Decimal.Round(aleatorio4, decimals);
                        Error1 = pen[1].ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 20);
                        aleatorio5 = aleatorio4 / 3;
                        pen[2] = Decimal.Round(aleatorio5, decimals);
                        Error2 = pen[2].ToString();
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
                        aleatorio4 = aleatorio4 / 2;
                        pen[1] = Decimal.Round(aleatorio4, decimals);
                        Error1 = pen[1].ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 20);
                        aleatorio5 = aleatorio4 / 3;
                        pen[2] = Decimal.Round(aleatorio5, decimals);
                        Error2 = pen[2].ToString();
                    }
                    label5.Text = Error1;
                    label4.Text = Error2;
                }
                label5.Text = Error1;
                label4.Text = Error2;
            }
        }
    }


       
    }
