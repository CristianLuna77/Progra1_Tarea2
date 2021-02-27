using System;

namespace calcular_la_serie_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, x = 0, y = 1, z = 1;
            Console.Write("Ingrese el numero de elementos: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                z = x + y;
                Console.WriteLine(z + " ");
                x = y;
                y = z;
            }
        }
    }
}
