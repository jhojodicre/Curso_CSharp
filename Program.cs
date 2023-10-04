using System;
using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.IO.Ports;

namespace Curso_CSharp
{
    //Clase Por defecto

 
    internal class Program
    { 
        string SerialRX = "";
        static SerialPort SerialESP;
        static void Main(string[] args)
        {
            //bool    SerialClose = false;
            SerialESP = new SerialPort();

            Console.WriteLine("Aprendiendo Programar en C#.");
            Console.WriteLine("Como te llamas");
            string nombreAprendiz  = Console.ReadLine();


            Console.WriteLine($"Hola {nombreAprendiz}");
            Console.WriteLine("Esta es una guia que te ayudara aprender los conceptos basicos de C#");


            //string SerialESP_COM = 
            SerialESP.BaudRate = 9600;
            SerialESP.Parity = Parity.None;
            //string SerialESP_PORT = SerialESP.SerialCOM();
            SerialCOM();
            SerialESP.Open();
            //SerialConnet();
            /* miCirculo es una Instancia (Ejemplar) de la Clase Circulo; 
            es decir es un Variable/Objeto de tipo Circulo
            Es semejante al definir una variable de tipo int, Esta variable se ha Iniciado al realizar New Circulo.
             */
            Circulo miCirculo = new Circulo();

            Console.WriteLine(miCirculo.CalculoArea(5));

            DolarPesos DolarActual = new DolarPesos();

            DolarActual.DolarCambiando(750);
            Console.WriteLine(DolarActual.DolaresTengo(1500));

            // Metodo Puente Gruas.
            PuenteGruas Grua11 = new PuenteGruas();
            PuenteGruas Grua12 = new PuenteGruas(3, 4);

            // accedemos a las propiedades de una instancia
            Console.WriteLine(Grua11.getInfoGrua());

            Console.WriteLine(Grua11.getInfoGrua());

            //Accedemos a las propiedades de otra instancia.

            Console.WriteLine(Grua12.getInfoGrua());

        }

        //static void SerialConnet()
        //{
            
        //    //SerialESP.PortName = "COM3";
        //    //SerialESP.BaudRate = 9600;
        //    //SerialESP.ReadTimeout = 500;
        //}
        public void SerialRecive()
        { 
            while( SerialESP.IsOpen )
            {
                try
                {
                    SerialRX = SerialESP.ReadLine();
                }
                catch { }
            }
        }

        public static string SerialCOM()
        {
            var comListados = new List<string> { };
            string puertoSerial;
            Console.WriteLine("Puertos Disponibles");
            foreach(string com in SerialPort.GetPortNames())
            {
                Console.WriteLine("  {0}", com);
                comListados.Add(com);
            }
            Console.WriteLine("Indique el Puerto COM");
            Console.WriteLine(comListados.Count);
            puertoSerial = Console.ReadLine();
            return puertoSerial;
        }
    }
    //Creacion de Una Clase
    class Circulo
    {
        //1. Variables Locales de la Clase Circulo.
        private const double PI = 3.1416;  // Variable dentro de la clase se convierte en la Propiedad de La Clase se denomimna Campo de Clase.
        // Esta variable es privada, no es accesible desde afuera, para que sea accesible deber tener public double 
        public double grosor = 1;

        /*3. Primer Metodo de Una Clase, es una funcion o una subrutina
         Es un comportamiento que puede hacer los Objetos de tipo Cirtculo*/

        public double CalculoArea(int radio)
        {
            /*Este Metodo Recibe Un paraetro de tipo int pero devuelve un valor de tipo double*/
            return PI * radio;
        }
    }

    class DolarPesos
    {
        private double dolar = 750.5;

        public double DolaresTengo(double pesos)
        {
            return pesos/dolar;
        }
        /*El siguiente metodo nos permite modificar el valor de una propiedad private double dolar = 750.5 desde afuera de la clase*/


        public void DolarCambiando(double nuevoValor) 
            //Introduce un valor en pesos y te dice cuantos dolares tienes
        {
            if(nuevoValor < 0) dolar = 750.5;

            else
                dolar = nuevoValor;
        }
    }

    class PuenteGruas
    {
        /*En este metodo haremos un ejemplo del constructor de la clase*/

        public PuenteGruas() 
            // Constructor de la clase.
        {
            ruedas = 4;
            puente = 1;
            carro = 2;
        }
        private int ruedas;
        private int puente;
        private int carro;

        //Metodo que retorna el valor de una propiedad
        public int getRuedas()
        {
            return ruedas;
        }
        // Metodo que retorna informacion general de las proipiedades.
        public String getInfoGrua()
        {
            return "info de la Grua" + "Ruedas" + ruedas + "puente" + puente;
        }

        // Metodo para modificar Propiedades y es una clase con sobrecarga porue tiene dos metodos cone el mismo metodo

        public PuenteGruas(int puenteG, int carroG) 
        {
            puente=puenteG;
            carro=carroG;
        }
    }


}

/*Glosario
  Encapsulacion: Es Proteger la funcion o variable dentro de una clase, y no permitir accesos externos.
  Esto lo logramos a traves de la palabra private.

Convencion:
Variables y Metodos: public: La primera letra debe ir en mayuscula.
Variables y Metodos: private: La primera letra debe ir en minuscula.
  */