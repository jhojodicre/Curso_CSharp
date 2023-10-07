using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    internal class PuertoSerial
    {
    }
}


//1. Variables
//string SerialRX = " ";


//2. Instancias.
//static SerialPort SerialESP;
//static Thread SerialHilo;

//static StreamWriter eventos; // Creamos un modificadoor de archivos de texto.
//SerialConnection SerialESP = new SerialConnection();
//Console.WriteLine("  Seleccionar Puerto");


        //SerialConfig();
        //SerialESP.Open();

        ////-2.2 Hilo Thread.
        //SerialHilo = new Thread(SerialRecive);
        //SerialHilo.Start();

        // 3. File eventos
        //eventos = new StreamWriter(path, true, Encoding.ASCII);     // Lito: Cerrado.
        //eventos.Close();
        //Programa Principal
        //while (loopMain != "salir")
        //{

        //    loopMain = Console.ReadLine();

        //    SerialESP.WriteLine(loopMain);
        //}

        //Cierre de instancias, Banderas
        //SerialHilo.Join();
        //    SerialESP.Close();

        //static string loopMain = "continue";
        //public static void SerialRecive()
        //{

        //    while (loopMain != "salir")
        //    {
        //        try
        //        {
        //            SerialRX = SerialESP.ReadLine();
        //            Console.WriteLine(SerialRX);
        //            eventos.WriteLine(SerialRX);
        //        }
        //        catch (TimeoutException)
        //        {

        //        }
        //    }
        //}
        //public static string SerialCOM()
        //{
        //    var comListados = new List<string> { };
        //    int comSeleccionado;
        //    int comNumeros = 0;
        //    string comFINAL;
        //    Console.WriteLine("Seleccione una Opcion de Puertos Disponibles");
        //    foreach (string com in SerialPort.GetPortNames())
        //    {
        //        comListados.Add(com);
        //    }
        //    foreach (string comleido in comListados)
        //    {
        //        comNumeros++;
        //        Console.WriteLine(comNumeros + ") " + $"{comleido}");
        //    }
        //    comSeleccionado = int.Parse(Console.ReadLine());
        //    comSeleccionado--;
        //    comFINAL = comListados[comSeleccionado];
        //    Console.WriteLine($"Puerto seleccionado: {comListados[comSeleccionado]}");
        //    return comFINAL;
        //}
        //public static void SerialConfig()
        //{
        //    SerialESP.PortName = SerialCOM();
        //    SerialESP.BaudRate = 115200;
        //    SerialESP.StopBits = StopBits.One;
        //    SerialESP.Handshake = Handshake.None;
        //    SerialESP.DataBits = 8;
        //    SerialESP.Parity = Parity.None;
        //    SerialESP.ReadTimeout = 300;
        //    SerialESP.WriteTimeout = 300;
        //}
//    }
//}


    //main


    /* miCirculo es una Instancia (Ejemplar) de la Clase Circulo; 
    es decir es un Variable/Objeto de tipo Circulo
    Es semejante al definir una variable de tipo int, Esta variable se ha Iniciado al realizar New Circulo.
     */






//    Circulo miCirculo = new Circulo();

//    Console.WriteLine(miCirculo.CalculoArea(5));

//            DolarPesos DolarActual = new DolarPesos();

//    DolarActual.DolarCambiando(750);
//            Console.WriteLine(DolarActual.DolaresTengo(1500));

//            // Metodo Puente Gruas.
//            PuenteGruas Grua11 = new PuenteGruas();
//    PuenteGruas Grua12 = new PuenteGruas(3, 4);

//    // accedemos a las propiedades de una instancia
//    Console.WriteLine(Grua11.getInfoGrua());

//            Console.WriteLine(Grua11.getInfoGrua());

//            //Accedemos a las propiedades de otra instancia.

//            Console.WriteLine(Grua12.getInfoGrua());

//}
//class Circulo
//{
//    //1. Variables Locales de la Clase Circulo.
//    private const double PI = 3.1416;  // Variable dentro de la clase se convierte en la Propiedad de La Clase se denomimna Campo de Clase.
//                                       // Esta variable es privada, no es accesible desde afuera, para que sea accesible deber tener public double 
//    public double grosor = 1;

//    /*3. Primer Metodo de Una Clase, es una funcion o una subrutina
//     Es un comportamiento que puede hacer los Objetos de tipo Cirtculo*/

//    public double CalculoArea(int radio)
//    {
//        /*Este Metodo Recibe Un paraetro de tipo int pero devuelve un valor de tipo double*/
//        return PI * radio;
//    }
//}

//class DolarPesos
//{
//    private double dolar = 750.5;

//    public double DolaresTengo(double pesos)
//    {
//        return pesos / dolar;
//    }
//    /*El siguiente metodo nos permite modificar el valor de una propiedad private double dolar = 750.5 desde afuera de la clase*/


//    public void DolarCambiando(double nuevoValor)
//    //Introduce un valor en pesos y te dice cuantos dolares tienes
//    {
//        if (nuevoValor < 0) dolar = 750.5;

//        else
//            dolar = nuevoValor;
//    }
//}

//class PuenteGruas
//{
//    /*En este metodo haremos un ejemplo del constructor de la clase*/

//    public PuenteGruas()
//    // Constructor de la clase.
//    {
//        ruedas = 4;
//        puente = 1;
//        carro = 2;
//    }
//    private int ruedas;
//    private int puente;
//    private int carro;

//    //Metodo que retorna el valor de una propiedad
//    public int getRuedas()
//    {
//        return ruedas;
//    }
//    // Metodo que retorna informacion general de las proipiedades.
//    public String getInfoGrua()
//    {
//        return "info de la Grua" + "Ruedas" + ruedas + "puente" + puente;
//    }

//    // Metodo para modificar Propiedades y es una clase con sobrecarga porue tiene dos metodos cone el mismo metodo

//    public PuenteGruas(int puenteG, int carroG)
//    {
//        puente = puenteG;
//        carro = carroG;
//    }
//}

