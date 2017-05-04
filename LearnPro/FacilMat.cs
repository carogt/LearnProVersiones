﻿using System;
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
    public partial class FacilMat : Form
    {
        public FacilMat()
        {
            InitializeComponent();
        }

        private void FacilMat_Load(object sender, EventArgs e)
        {
            Actualizacion();
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
        private void playSimpleSound()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Recursos\BuenTrabajo.wav");
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
            MessageBox.Show("Bien Hecho");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DificultadMath Fmat = new DificultadMath();
            Fmat.ShowDialog();
            this.Close();
        }
        public void Actualizacion() {
            Random r = new Random();
            int resultadosum;
            int resultadores;
            int aleatorio1 = r.Next(1, 9);
            string con1 = aleatorio1.ToString();
            int aleatorio2 = r.Next(1, 9);
            string con3 = aleatorio2.ToString();
            int aleatorio3 = r.Next(1, 3);
            int aleatorio4 = r.Next(1, 20);
            string Error1 = aleatorio4.ToString();
            int aleatorio5 = r.Next(1, 20);
            string Error2 = aleatorio5.ToString();
            resultadosum = aleatorio1 + aleatorio2;
            int aleatorio6 = r.Next(1, 10);
            if (aleatorio6 >= 1 && aleatorio6 <= 5)
            {
                label2.Text = "+";
                label1.Text = con1;
                label3.Text = con3;
                Global.result = resultadosum.ToString();
            }
            else if (aleatorio6 >= 6 && aleatorio6 <= 10)
            {
                label2.Text = "-";
                label1.Text = con1;
                label3.Text = con3;
                if (aleatorio1 >= aleatorio2)
                {
                    resultadores = aleatorio1 - aleatorio2;
                    label1.Text = con1;
                    label3.Text = con3;
                    Global.result = resultadores.ToString();
                }
                else if (aleatorio2 >= aleatorio1)
                {
                    resultadores = aleatorio2 - aleatorio1;
                    label1.Text = con3;
                    label3.Text = con1;
                    Global.result = resultadores.ToString();
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
                        Error1 = aleatorio4.ToString();
                    }
                    else if (Error2 == Global.result)
                    {
                        aleatorio5 = r.Next(1, 20);
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
    }

    public static class Global{
        public static int resultg;
        public static String txresult;
        public static String result;
        public static int sumacon = 0;
        public static int restacon = 0;
        public static int entrada = 0;
        public static Boolean cuchillo = false;
        public static Boolean silla = false;
        public static Boolean refri = false;
        public static Boolean micro = false;
        public static Boolean estufa = false;
        public static Boolean Inodoro = false;
        public static Boolean LavaMan = false;
        public static Boolean LavaPla = false;
        public static Boolean Tina = false;
        public static Boolean Regadera = false;
        public static Boolean Espejo = false;
        public static Boolean Cocina = false;
        public static Boolean Baño = false;
        public static Boolean Buro = false;
        public static Boolean Cajonera = false;
        public static Boolean Ventana = false;
        public static Boolean Cama = false;
        public static Boolean Recamara = false;
        public static Boolean tenedor = false;
        public static Boolean Cuchara = false;
        public static Boolean olla = false;
        public static Boolean Sala = false;
        public static Boolean TV = false;
        public static Boolean Control = false;
        public static Boolean Sofa = false;
        public static Boolean MesaC = false;
    }
   
}
