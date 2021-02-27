using System;

namespace calcular_el_factorial_de_un_número
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            long fact=1;
            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + "! = 1");
            for (int i = 2; i<=num; i++)
            {
                fact *= i;
                Console.WriteLine(" factor:  " + i);
            }
            Console.WriteLine("\t= " + fact);
        }
    }
}
