using System;

namespace Semana_3._Ejercicio_2_pag._146
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, potencia, resultado;
            Console.Write("Digite un numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Digite la potencia que desea elevar: ");
            potencia = int.Parse(Console.ReadLine());
            resultado = (int) Math.Pow(num, potencia);
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
