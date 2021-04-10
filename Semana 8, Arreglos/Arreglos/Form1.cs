using Arreglos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 33; 
            arreglo[4] = 1;

            ClsArreglos ObjetoArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjetoArreglo.metodoB();   

            foreach (int r in resultado)
            {
                listBoxResultado.Items.Add(r);
            }



        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog() ;

            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:/Users/Cristian Luna/Downloads";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArhivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;
            }
        }

        private void buttonNames_Click(object sender, EventArgs e)
        {
            listBoxDATOSTOTAL.Items.Clear();
            string[] Orden = ArregloNotas;
            string auxuliar;
            for (int i = 1; i <= Orden.Length; i++)
            {
                for (int j = 0; j < Orden.Length - 1; j++)
                {
                    if (Orden[j].CompareTo(Orden[j + 1]) > 0)
                    {
                        auxuliar = Orden[j];
                        Orden[j] = Orden[j + 1];
                        Orden[j + 1] = auxuliar;
                    }
                }
            }
            foreach (string po in ArregloNotas)
            {
                string[] datosUnitarios = po.Split(',');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                listBoxDATOSTOTAL.Items.Add(po);
            }
            
            
        }

        private void buttonPromGeneral_Click(object sender, EventArgs e)
        {
            listBoxDATOSTOTAL.Items.Clear();     
            foreach (string Linea in ArregloNotas)
            {
               
                string[] datosUnitarios = Linea.Split(',');
                this.listBoxDATOSTOTAL.Items.Add($"{datosUnitarios[0]} Promedio: {datosUnitarios[4]}");
                


            }

        }



        private void buttonPromParcial1_Click(object sender, EventArgs e)
        {
            listBoxDATOSTOTAL.Items.Clear();
            foreach (string Linea in ArregloNotas)
            {
                string[] datosUnitarios = Linea.Split(',');
                this.listBoxDATOSTOTAL.Items.Add($"{datosUnitarios[5]}");

            }
        }

        private void buttonPromPacial2_Click(object sender, EventArgs e)
        {
            listBoxDATOSTOTAL.Items.Clear();
            foreach (string Linea in ArregloNotas)
            {
                string[] datosUnitarios = Linea.Split(',');
                this.listBoxDATOSTOTAL.Items.Add($"{datosUnitarios[6]}");

            }
        }

        private void buttonPromParcial3_Click(object sender, EventArgs e)
        {
            listBoxDATOSTOTAL.Items.Clear();
            foreach (string Linea in ArregloNotas)
            {
                string[] datosUnitarios = Linea.Split(',');
                this.listBoxDATOSTOTAL.Items.Add($"{datosUnitarios[7]}");

            }
        }
    }
}
