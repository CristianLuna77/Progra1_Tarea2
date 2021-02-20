using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hors, total, horas_extras;
            Console.WriteLine("     ****    Bienvenido trabajador de la empresa 'El pasto fezil'    *****");
            Console.Write("Introdusca las horas laboradas de la semana: ");
            hors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (hors <= 40)
            {
                total = hors * 16;
                Console.Write("Usted a trabajado " + hors);
                Console.WriteLine(" horas. Y su salario semanal es de: " + total);
                Console.WriteLine("");
            }
            else if (hors >40)
            {
                total = ((hors - 40) * 20) + (40 * 16) ;
                horas_extras = hors - 40;
                Console.Write("Usted a trabajado " + hors);
                Console.WriteLine(" horas. Y su salario semanal es de: " + total);
                Console.WriteLine("Usted a trabajado horas extras, y las horas trabajadas son: " + horas_extras);
            }

        }
    }
}
