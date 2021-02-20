using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("Introdusca un numero para saber si es un dia laboral o no...");
            Console.WriteLine("1 - Lunes");
            Console.WriteLine("2 - Martes");
            Console.WriteLine("3 - Miercoles");
            Console.WriteLine("4 - Jueves");
            Console.WriteLine("5 - Viernes");
            Console.WriteLine("6 - Sabado");
            Console.WriteLine("7 - Domingo");
            Console.Write(".....................");
            dia = int.Parse(Console.ReadLine());
            if (dia == 1 )
            {
                Console.WriteLine("Lunes es una dia laboral");
            }
            if (dia == 2)
            {
                Console.WriteLine("Martes es una dia laboral");
            }
            if (dia == 3)
            {
                Console.WriteLine("Miercoles es una dia laboral");
            }
            if (dia == 4)
            {
                Console.WriteLine("Jueves es una dia laboral");
            }
            if (dia == 5)
            {
                Console.WriteLine("Viernes es una dia laboral");
            }
            if (dia == 6)
            {
                Console.WriteLine("Sabado es una dia laboral (Aunque se trabaja medio dia)");
            }
            if (dia == 7)
            {
                Console.WriteLine("Domingo NO es un dia laboral (vaya directo a la Iglesia)");
            }
        }
    }
}
