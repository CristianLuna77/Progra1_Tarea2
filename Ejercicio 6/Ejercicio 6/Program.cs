using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i, num1=0;
            Console.Write("Digite un numero para saber si es numero primo o no: ");
            num = int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                if (num % i == 0) 
                {
                    num1++;
                }
            }
            if (num1>2)
            {
                Console.WriteLine("El numero ingresado No es primo");
            }
            else
            {
                Console.WriteLine("El numero ingresado es primo");
            }



        }
    }
}
