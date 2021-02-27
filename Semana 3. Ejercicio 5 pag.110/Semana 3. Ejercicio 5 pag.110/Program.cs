using System;

namespace Semana_3._Ejercicio_5_pag._110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            float resultado, num2, longi, apotema;
            Console.WriteLine("Que desea hacer");
            Console.WriteLine("1 - calcular el perimetro");
            Console.WriteLine("2 - calcular el area de cualquier poligono regular");
            Console.Write("............       ");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.Write("Introduzca el diametro: ");
                num2 = float.Parse(Console.ReadLine());
                resultado = (float)(num2 * 3.14159);
                Console.WriteLine("El resultado es de: " + resultado);
            }
            else if (num == 2)
            {
                Console.Write("Introduzca la longitud: ");
                longi = float.Parse(Console.ReadLine());
                Console.Write("Introduzca la longitud: ");
                apotema = float.Parse(Console.ReadLine());
                resultado = (float)(5 * longi * apotema);
                Console.WriteLine("El resultado es de: " + resultado);


            }
            
        }
    }
}
