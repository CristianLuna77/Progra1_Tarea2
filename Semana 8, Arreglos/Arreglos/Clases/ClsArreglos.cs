using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos.Clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanioArreglo = 0;


        public int GettamanioArreglo()
        {
            return datos.Length;
        }
   
        public ClsArreglos (int [] arregloParametro)
        {
            datos = arregloParametro;
            tamanioArreglo = datos.Length;
        }

        public int[] metodoB()
        {
            ArregloTemporal = datos;
            for(i = 0; i < tamanioArreglo - 1; i++)
            {
                for(j=i+1; j < tamanioArreglo; j++)
                {
                    if(ArregloTemporal[i] < ArregloTemporal[j])
                    { 
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }

       
    }
}
