using System;
using System.Threading;

namespace Ejercicios_en_clase
{
    class Program
    {
        public static string  Mid (string  parametro, int comienzo_de_cadena, int length)//una funcion publica 
        {
            string resultado = parametro.Substring(comienzo_de_cadena, length); //para empezar a separar los caracteres
            return resultado; //Cristia(n)
        }

        static void Main(string[] args)
        {
            //variables
            string nombre; //variables de cadenas de texto
            string Caracter_cadena;
            int C = 0, P = 0, Longitud = 0, Recorrido = 0; //La C sirve para recorrer las columnas y la P para los carateres de la cadena
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 12);//En el curso 1 y en la fila 12
            Console.Write(nombre);
            Longitud = nombre.Length;//determine la cantidad de los caracteres que hay
            Recorrido = 30;//cuantos caracteres recorre letra por letra
            nombre = nombre.ToUpper();//convierte en mayuscular
            for (P = nombre.Length; P >= 1; P--) //asinga, toma valor de 30 y se ira disminuyendo  hasta que llegue a ese valor     //hay bucle anidado 
            {
                Caracter_cadena = Mid(nombre, P - 1, 1);//se llama a la funcion publica y se le da los parametor dentro del parentesis
                for (C = Longitud; C <= Recorrido; C++)//asinga, toma valor de 30 y se ira aumentando hasta que llegue a ese valor
                {
                    Console.SetCursorPosition(C, 12); //pone el curso en donde almacena el valor de C y en la fila 12
                    Console.Write("" + Caracter_cadena);//va dar un espacio y va a concatenar La ultima letra despues de un espacio
                    Thread.Sleep(25);//pausa 25 milesengundos

                }
                Recorrido = Recorrido-1;//se le resta un espacio para que no termien en el mismo lugar de recorrido
                Longitud = Longitud-1;//y si no se le resta 
            }
           
        }
    }
}
