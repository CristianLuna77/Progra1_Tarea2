using System;

namespace Semana_3._Ejercicio_2_pag._110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            float resultado;
            Aqui:
            Console.WriteLine("Programa para calcular impuesto de un prodcuto.");
            Console.WriteLine("Ingrese un numero para calcular el impuseto de productos deseado");
            Console.WriteLine("1 - Medicamentos");
            Console.WriteLine("2 - otros");
            Console.Write("............    ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.Write("Ingrese la cantidad del producto:");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El impuesto aplicado es de 0% y el total es de: " + num2);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingrese la cantidad del producto:");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = (float) (num2 * 0.20);
                        Console.WriteLine("El impuesto aplicado es de 20% y el total es de: " + resultado);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("A no mi hermano, ingresa el valor que te pido");
                        goto Aqui;
                    }
            }



            
        }
    }
}