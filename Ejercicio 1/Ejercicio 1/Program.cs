using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letra;
            Console.Write("Introdusca una Letra: ");
            Letra = Convert.ToChar(Console.ReadLine());
            if (char.IsUpper(Letra))
            {
                Console.WriteLine("Es una letra Mayuscula");


            }
            else
            {
                Console.WriteLine("Es una letra minuscula");
            }




        }
    }
}
