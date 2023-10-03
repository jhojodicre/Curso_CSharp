using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Curso_CSharp
{
    //Clase Por defecto
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comenzaremos Instanciando Un Objeto de una clase.");

            /* miCirculo es una Instancia (Ejemplar) de la Clase Circulo; 
            es decir es un Variable/Objeto de tipo Circulo
            Es semejante al definir una variable de tipo int, Esta variable se ha Iniciado al realizar New Circulo.
             */
            Circulo miCirculo = new Circulo();

            Console.WriteLine(miCirculo.CalculoArea(5));

            DolarPesos DolarActual = new DolarPesos();

            DolarActual.DolarCambiando(750);
            Console.WriteLine(DolarActual.DolaresTengo(1500));
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
}/*Glosario
  Encapsulacion: Es Proteger la funcion o variable dentro de una clase, y no permitir accesos externos.
  Esto lo logramos a traves de la palabra private.

Convencion:
Variables y Metodos: public: La primera letra debe ir en mayuscula.
Variables y Metodos: private: La primera letra debe ir en minuscula.
  */