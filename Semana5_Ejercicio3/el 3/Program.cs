using System;

namespace el_3
{
    class Program
    {
        public static string generaletra(int MIN, int MAX)//una funcion publica 
        {
            Random ran = new Random();//se declara una varible random y nos perimte inicializar un nuevo dato 
            int NUM = Convert.ToInt32(ran.Next(100));//se declara variable y se convierte en tipo entero; se le asigna los valores de la variable ran y generará uno nuevo 
            string letraRespuesta = "";//se crea una varibale tipo string
            if (((NUM > MIN) & (NUM <= MAX)))//si icializa if con los parametros siguiente..
            {
                letraRespuesta = Convert.ToString((char)NUM);//si cumple la sentencia letraRespuesta se va a convertir a tipo char con los parametros que da num
            }
            return letraRespuesta;//devuelve los valores que hay en la letraRespuesta
        }

        static void Main(string[] args)
        {
            byte CAM, K;//se inicializan varibales
            String linea;//se crea una varibale tipo string
            Console.Write("Cuantos numeros?");//Se imprime en consola lo que esta dentro del parentesis
            linea = Console.ReadLine();//Y se guarda en la varible linea
            CAM = byte.Parse(linea);//cam se convirte en byte y a la ves se le transfieren los datos que estan el linea, convertiendolo en numero 

            string Letra = "";//se crea una varibale tipo string
            for (K = 1; K <= CAM; K++)//a K se le asigna un numero, toma valor que hay en cam y se ira aumentando hasta que llegue a ese valor
            {
                Letra = Letra + generaletra(0,250);//A letra se le va a sumar la funcion publica que es generaletra, y tomara un rango de 0 a 250
       
            }
            Console.WriteLine($"Letra generada= {Letra}");//por ultimo se imprime texto y la varibale Letra

        }
    }
}


