using System;

namespace Semana_3._Ejercicio_4_pag._110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Aqui:
            Console.Write("Ingrese un numero del 1 al 7: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Lunes");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Martes");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Miercoles");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Jueves");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Viernes");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sabado");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Domingo");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("A no mi hermano, ingrese el numero del rango que le doy");
                        goto Aqui;
                    }

            }
            
        }
    }
}
