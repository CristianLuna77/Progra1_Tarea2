using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento, compra,total;
            Console.WriteLine("****Bienvenido a MegaPlaza****");
            Console.Write("Ingrese el Total de la compra para un descuento: ");
            compra = Convert.ToInt32(Console.ReadLine());
            descuento = compra * 0.20;
            total = compra - descuento;
            if (compra > 299)
            {
                
                Console.WriteLine("Su descuento es de: " + descuento);
                Console.WriteLine("El total a pagar es de: " + total);

            }
            else
            {
                Console.WriteLine("Usted no tiene ningun descuento porque su compra es menor a 300");
                
            
                    }
             
             
            
        }
    }
}
