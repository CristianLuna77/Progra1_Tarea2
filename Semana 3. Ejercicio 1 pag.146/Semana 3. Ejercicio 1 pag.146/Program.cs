using System;

namespace Semana_3._Ejercicio_1_pag._146
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,j;
            Console.WriteLine("\a**Tabalas disponibles del 1 al 10**");
            Console.Write("Digite el numero de tabla que desea imprimir: ");
            num = Convert.ToInt32(Console.ReadLine());
            while ((num <= 0) || (num >= 11))
            {
                Console.Clear();
                Console.WriteLine("Numero de rango: " + num);
                Console.Write("El numero " + num + " no es valido! Digite un numero para una tabla de multiplicar: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (i = num; i <= num; i++)
            {
                Console.WriteLine("\tTabla del " + i + "\n");

                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine(+i + " * " + j + " = " + j * i);

                }
                Console.WriteLine("");
            }
        }

    }
}
