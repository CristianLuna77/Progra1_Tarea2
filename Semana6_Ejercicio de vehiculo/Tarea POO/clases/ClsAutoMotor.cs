using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_POO.clases
{
    class ClsAutoMotor
    {
          public String marca { get; }
        public int vel_max { get; set; }
        public String color { get; set; }
        public int velocidadActual = 0;
        public bool encendidio { get; set; } = false;
        public ClsAutoMotor(string marcaCarro, int MaxVel)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
        }
        public ClsAutoMotor(string marcaCarro, int Maxvel, string colorCarro)
        {
            this.vel_max = Maxvel;
            this.marca = marcaCarro;
            this.color = colorCarro;
        }

        public string encender()
            {
            string respuesta = "";
                if (encendidio)
                {
                
                encendidio = false;
                return "Ahora el carro esta apagado";
                }
                else
                {
                
                encendidio = true;
                respuesta = "Listo!. \n El carro esta encendido";
                }
            velocidadActual = 0;
                return respuesta;
        }
        
        public string Detener()
        {
            
    
            if (encendidio)
            {
                velocidadActual = velocidadActual - 5;
                if (velocidadActual == 0)
                {
                    encendidio = false;
                }

            }
            return $"ALERTA, El carro se esta deteniendo {velocidadActual}KPH";
                     
        }
        public string Acelerar()
        {
            if (!encendidio)
            {
                return "Enciende el carro de primero";
            }
            if (velocidadActual > vel_max)
            {
                velocidadActual = vel_max;
                return $"Parale mem ya llegaste al tope: {vel_max}KPH";

            }
            else
            {
                velocidadActual = velocidadActual + 5;

                if (velocidadActual == 25)
                {
                    return $"Has el cambio a Segunda, vas a {velocidadActual}kPH";

                }
                if (velocidadActual == 35)
                {
                    return $"Has el cambio a Tercera, vas a {velocidadActual}kPH";

                }
                if (velocidadActual == 60)
                {
                    return $"Has el cambio a Cuarta, vas a {velocidadActual}kPH";

                }
                if (velocidadActual == 95)
                {
                    return $"Has el cambio a Quinta, vas a {velocidadActual}kPH";

                }
                if (velocidadActual == 105)
                {
                    return $"Has el cambio a Sexta, vas a {velocidadActual}kPH";

                }
            }
            return $"vas a {velocidadActual}KPH";


        }
        public string VEL()
        {

            string velocidad = "";
            if (!encendidio)
            {
                
                return "Acelera el carro de primero";
            }
            if (velocidadActual== 25) 
            {
                velocidad = "vas a 2da";
                
            }
            else if (velocidadActual == 35)
            {
                velocidad = "vas a 3ra";
                
            }
            else if (velocidadActual == 60)
            {
                velocidad = "vas a 4ta";
                
            }
            else if(velocidadActual == 95)
            {
                velocidad = "vas a 5ta";
            }
            else if (velocidadActual == 105)
            {
                velocidad = "vas a 6ta";
            }
            return velocidad;

           
        }
        public bool cambios()
        {
            
            bool cambio;
            switch (velocidadActual)
            {
                
                case 20:
                case 30:
                case 55:
                case 90:
                case 100:
                    cambio = false;
                    break;
                default: cambio = true;
                    break;
            }
            return cambio;
        }
    }
}
