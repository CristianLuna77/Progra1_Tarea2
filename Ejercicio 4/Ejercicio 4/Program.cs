using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio, dias, mes;
            Console.Write("Digite el anio: ");
            anio = int.Parse(Console.ReadLine());
            Console.WriteLine("1 - Enero");
            Console.WriteLine("2 - Febrero");
            Console.WriteLine("3 - Marzo");
            Console.WriteLine("4 - Abril");
            Console.WriteLine("5 - Mayo"); 
            Console.WriteLine("6 - Junio");
            Console.WriteLine("7 - Julio");
            Console.WriteLine("8 - Agosto");
            Console.WriteLine("9 - Septimbre");
            Console.WriteLine("10 - Octubre");
            Console.WriteLine("11 - Noviembre");
            Console.WriteLine("12 - Diciembre");
            Console.Write("Digite el numero de mes: ");
            mes = int.Parse(Console.ReadLine());
            dias = 0;
            //Pues segun las instrucciones creo que no es necesario operar con los digitos 100 y 400. Porque igual da el mismo resutado :D
            if (mes == 2 && (anio % 4 == 0))
            {
                dias = 29;
            }
            else if (mes == 2 && (anio % 4 != 0))
            {
                dias = 28;
            }
            else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                dias = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dias = 30;
            }
            string name_mes = "a";
            switch (mes)
            { 
                case 1:
                    name_mes = "Enero";
                    break;
                case 2:
                    name_mes = "Febrero";
                    break;
                case 3:
                    name_mes = "Marzo";
                    break;
                case 4:
                    name_mes = "Abril";
                    break;
                case 5:
                    name_mes = "Mayo";
                    break;
                case 6:
                    name_mes = "Junio";
                    break;
                case 7:
                    name_mes = "Julio";
                    break;
                case 8:
                    name_mes = "Agosto";
                    break;
                case 9:
                    name_mes = "Septiembre";
                    break;
                case 10:
                    name_mes = "Octubre";
                    break;
                case 11:
                    name_mes = "Noviembre";
                    break;
                case 12:
                    name_mes = "Diciembre";
                    break;

            }
            Console.WriteLine("El valor de dias que tiene el mes de  " + dias);
            Console.WriteLine("El nombre del mes que ah escogido es: " + name_mes);
            Console.WriteLine();
        }
    }
}


