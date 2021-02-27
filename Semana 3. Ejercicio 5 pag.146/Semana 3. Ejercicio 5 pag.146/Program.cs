using System;

namespace Semana_3._Ejercicio_5_pag._146
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,mayor=0,menor=0;
            Console.Write("Cuantas Edades desea ingresar: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] year= new int[num + 1];
            for (i = 1; i <= num; i++)
            {
                Console.Write("Cual es la Edad de la Persona: ");
                year[i]= Convert.ToInt32(Console.ReadLine());
            }
            mayor = year[1];
            menor = year[1];
            for (i = 1; i <= num; i++)
            {
                if (year[i] > mayor)
                {
                    mayor = year[i];
                }
                else if (year[i] < menor)
                {
                    menor =year[i];
                }
            }
            
            Console.WriteLine("La edad mayor es: " + mayor);
            Console.WriteLine("La edad menor es: " + menor);
        }
        }
    }

