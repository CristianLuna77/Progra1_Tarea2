using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_POO.clases;
using System.Media;

namespace Tarea_POO
{
    public partial class Form1 : Form
    {
        ClsAutoMotor carrito;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxHONDA.Visible = true;
            pictureBoxMAZDA.Visible = true;
            pictureBoxTOYOTA.Visible = true;
            pictureBoxBMW.Visible = true;
            buttonHONDA.Visible = true;
            buttonMAZDA.Visible = true;
            buttonTOYOTA.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            labelBienvenida.Visible = false;
            labelSelecvehiculo.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            groupBoxReproductor.Visible = true;
            pictureBoxHONDA.Visible = false;
            pictureBoxMAZDA.Visible = false;
            pictureBoxTOYOTA.Visible = false;
            pictureBoxBMW.Visible = false;
            buttonCambio.Visible = true;
            buttonAcelerar.Visible = true;
            buttonEncender.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            buttonHONDA.Visible = false;
            buttonMAZDA.Visible = false;
            buttonTOYOTA.Visible = false;
            labelSelecvehiculo.Visible = false;
            carrito = new ClsAutoMotor("BMW", 200, "NEGRO");
            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void buttonHONDA_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            groupBoxReproductor.Visible = true;
            pictureBoxHONDA.Visible = false;
            pictureBoxMAZDA.Visible = false;
            pictureBoxTOYOTA.Visible = false;
            pictureBoxBMW.Visible = false;
            buttonCambio.Visible = true;
            buttonAcelerar.Visible = true;
            buttonEncender.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            buttonHONDA.Visible = false;
            buttonMAZDA.Visible = false;
            buttonTOYOTA.Visible = false;
            labelSelecvehiculo.Visible = false;
            carrito = new ClsAutoMotor("HONDA", 250, "BLANCO");
            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void buttonMAZDA_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            groupBoxReproductor.Visible = true;
            pictureBoxHONDA.Visible = false;
            pictureBoxMAZDA.Visible = false;
            pictureBoxTOYOTA.Visible = false;
            pictureBoxBMW.Visible = false;
            buttonCambio.Visible = true;
            buttonAcelerar.Visible = true;
            buttonEncender.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            buttonHONDA.Visible = false;
            buttonMAZDA.Visible = false;
            buttonTOYOTA.Visible = false;
            labelSelecvehiculo.Visible = false;
            carrito = new ClsAutoMotor("MAZDA", 220, "BLANCO");
            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void buttonTOYOTA_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            groupBoxReproductor.Visible = true;
            pictureBoxHONDA.Visible = false;
            pictureBoxMAZDA.Visible = false;
            pictureBoxTOYOTA.Visible = false;
            pictureBoxBMW.Visible = false;
            buttonCambio.Visible = true;
            buttonAcelerar.Visible = true;
            buttonEncender.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            buttonHONDA.Visible = false;
            buttonMAZDA.Visible = false;
            buttonTOYOTA.Visible = false;
            labelSelecvehiculo.Visible = false;
            carrito = new ClsAutoMotor("TOYOTA", 240, "GRIS");
            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");

        }

        private void buttonEncender_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"El carro {carrito.marca} : {carrito.encender()}";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = true;
            label2.Text = carrito.Detener();
        }

        private void buttonSegunda_Click_1(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = carrito.cambios();
            buttonAcelerar.Show();
            label3.Text = carrito.VEL();
        }

        private void buttonAcelerar_Click_1(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = carrito.cambios();
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro Primero");

            }
            else
            {

                label2.Text = carrito.Acelerar();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SoundPlayer Player = new SoundPlayer();
        private void buttonMusic_Click_1(object sender, EventArgs e)
        {
           
            Player.SoundLocation = "C:/Users/Cristian Luna/Downloads/y2mate.com-ビッケブランカ-Black-Catcherofficial-music-video.wav";
            Player.Play();
        }

        private void buttonMusic2_Click_1(object sender, EventArgs e)
        {
            Player.SoundLocation = "C:/Users/Cristian Luna/Downloads/y2mate.com-Movimiento-Naranja-Remix-HD-Completo-full-Yuawi-Ft-Los-Niños-del-Movimiento-Naranja.wav";
            Player.Play();
        }

        private void buttonMusic3_Click_1(object sender, EventArgs e)
        {
            Player.SoundLocation = "C:/Users/Cristian Luna/Downloads/y2mate.com-Michael-Jackson-Billie-Jean-Official-Video.wav";
            Player.Play();
        }

        private void buttonMusic4_Click_1(object sender, EventArgs e)
        {
            Player.SoundLocation = "C:/Users/Cristian Luna/Downloads/y2mate.com-SFM-Shrekophone.wav";
            Player.Play();
        }
        

        private void buttonParar_Click_1(object sender, EventArgs e)
        {
            Player.Stop();
        }

        private void buttonCambio_Click(object sender, EventArgs e)
        {

        }
    }
}
