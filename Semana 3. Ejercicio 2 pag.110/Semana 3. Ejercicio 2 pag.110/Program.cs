using System;

namespace Semana_3._Ejercicio_2_pag._110
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado, num, num2;

        Aqui:
            Console.WriteLine("***Bienvendio Digite un numero para hacer una operacion :)***");
            Console.WriteLine("1 - De grados a radianes");
            Console.WriteLine("2 - De radianes a grados");
            Console.Write("............    ");
            num = float.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("De grados a radianes");
                        Console.Write("Ingresa la cantidad a convertir: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num2 * 3.1416 / 180;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("De radianes a grados");
                        Console.Write("Ingresa la cantidad a convertir: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num2 * 180/3.1416;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("A no mi hermano, vuelva a igresar los valores que se le piden");
                        goto Aqui;
                        
                    }

            }
        }
    }
}



