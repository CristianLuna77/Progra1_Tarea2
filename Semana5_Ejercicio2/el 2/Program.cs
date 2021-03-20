using System;
using System.Threading;

namespace el_2
{
    class Program
    {
        public static void dibuja(int cantidad)//una funcion publica 
        {
            int columnas = 19;//crea el tamaño de las columnas, osea que pondra 19 veces el valor X de forma vertical
            int filas = 19;//crea el tamaño de las filas , osea que pondra 19 veces el valor ? de forma horizontal
            int espacio_fila = 2; //sirve para dar esapacios entre filas 
            int espacio_columna = 2;//sirve para dar espacios en colunma
            int x, Y, Z;//variables que serviran de centinelas para guardar valores de otras variables
            for (Z=1;Z<= cantidad; Z++)//asinga, tomal el valor de cantidad y se ira aumentando  //hay bucles anidados
            {
                for (x=espacio_columna; x<= filas; x++) //asinga, tomal el valor de cantidad y se ira aumentando 
                { 
                    Console.SetCursorPosition(x, columnas); Console.Write("?");//toma las coordenadas de las variable x y columnas, y va a dar espacios conforme a las coordenadas y luego imprime
                    Console.SetCursorPosition(x, espacio_fila); Console.Write("?");//Aqui igual
                }
                for (Y = espacio_fila; Y <= columnas; Y++)//asinga, tomal el valor de cantidad y se ira aumentando 
                {
                    Console.SetCursorPosition(espacio_columna, Y); Console.Write("X");//Aqui igual
                    Console.SetCursorPosition(filas, Y); Console.Write("X");//Aqui igual
                }
                espacio_fila++;//se igual la misma variable y se le ira sumando un valor
                columnas = columnas-1;//se igual la misma variable y se le ira restando un valor
                                      //un valor
                espacio_columna++;//a la variable se le suma el valor de 1
                filas++;//a la variable se le suma el valor de 1
            }
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 25; tam ++)//asinga el valor 1  y se ira aumentando hasta que llegue a ese valor que es 24
            {
                dibuja(tam);//imprime la funcion pulic que se llama dibuja 
                Thread.Sleep(300);//pausa 300 milesengundos
            }
        }
    }
}
