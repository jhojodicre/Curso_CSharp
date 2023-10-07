using System;
using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Text;
using System.IO;
using System.Collections;

namespace Curso_CSharp
{
    //Clase Por defecto
    internal class Program
    {
        //1. Variables


        //2. Instancias.

        static void Main(string[] args)
        {
            //1. Instancias
            SirvePara PaQSirve = new SirvePara();
            Glosario QueEs = new Glosario();


            //2. Consultas
            PaQSirve._partial();
            QueEs.retomarProgramacion();
            // TODO:
        }
    }

    public class Glosario
    {
        public void PascalCase()
        {
            List<string> concepto = new List<string>
            {
            "PascalCase:\n",
            "   Es una Convencion; Todas las variables, metodos de tipo public deben comenzar con la primera letra de\n las palabaras en Mayuscula.\n",
            "       Por ejemplo:\n",
            "           MiMetodo"
            };
        }
        public void camelCase()
        {
            List<string> concepto = new List<string>
            {
            "camelCase:\n",
            "   Es cuando una variable o metodo es de acceso private la primera palabra serà en Minuscula ejemplo: miFuncion",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void ConstructorDef()
        {
            List<string> lista = new List<string>
            {
            "Constructor:\n",
            "   Es asignarle un estado inicial a un objeto, y tiene que tener el mismo nombre que la clase",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void SobreCarga()
        {
            List<string> lista = new List<string>
            {
            "Constructor:\n",
            "   Es crear mas de un metodo dentro de una calse, pero con diferentes numeros y/ó tipos de parametros, es util cuando requerimos instacion una objeto de clase con diferentes propiedades",
            "       Por ejemplo:\n",
            "           Es Util Cuando requerimos instanciar un objeto con diferentes propiedades, o sin ninguna pripiedad."
            };
            ImprimirDefinicion(lista);
        }
        public void metodoDefinicion()
        {
            List<string> lista = new List<string>
            {
            "Metodo:\n",
            "   Es un Objeto",
            "       Por ejemplo:\n",
            ""
            };
            ImprimirDefinicion(lista);
        }
        public void claseDefinicion()
        {
            List<string> lista = new List<string>
            {
            "clase:\n",
            "   Es un molde\n",
            "       Por ejemplo:\n",
            ""
            };
            ImprimirDefinicion(lista);
        }
        public void propiedadDefinicion()
        {
            List<string> lista = new List<string>
            {
            "Propiedad:\n",
            "   Es una caracteristica de la clase\n",
            "       Por ejemplo:\n",
            ""
            };
            ImprimirDefinicion(lista);
        }
        public void metodoDeAcceso()
        {
            List<string> lista = new List<string>
            {
            "metodo:\n",
            "   Es modificar la propiedad desde afuea de la clase\n",
            "       Por ejemplo:\n"

            };
            ImprimirDefinicion(lista);
        }
        public void encapsulacionDef()
        {
            List<string> lista = new List<string>
            {
            "Encapsulacion:\n",
            "   Es proteger la variable, funcion o propiedad de una clase y no permitir accesos externos a traves de la palabra reservada private",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void modificadoresDeAcceso()
        {
            List<string> lista = new List<string>
            {
            "Modificadores de acceso:\n",
            "   Son nombres que nos permiten revoidir o acceder a una clase, metodo ó propiedad por ejemplo: private, public",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void parametroDeClase()
        {
            List<string> lista = new List<string>
            {
            "Modificadores de acceso:\n",
            "   Son las variables declaradas dentro de una Clase",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void ambitodeVariable()
        {
            List<string> lista = new List<string>
            {
            "Modificadores de acceso:\n",
            "   Es el lungar donde se declara una variable, si esta dentro de una clase o dentro de un metodo o funcion",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void variable()
        {
            List<string> lista = new List<string>
            {
            "Modificadores de acceso:\n",
            "   Al crear una variable sin iniciar esta toma el valor por defecto",
            "       Por ejemplo:\n",
            ""
            };
        }
        public void retomarProgramacion()
        {
            List<string> lista = new List<string>
            {
            "retomarProgramacion:\n",
            "   Es una Herramienta o tips para hacer referencia donde dejastes el programa.\n\n",
            "       Por ejemplo:\n",
            "           //TODO:\n" +
            "               Con esta palabra TODO: y dos puntos al final del comentario:\n" +
            "               Marcamos el punto donde deseamos recordar el codigo para volver a retomarlo y,\n" +
            "               Accediendo al Menu Ver>Lista de tareas (Se muestran Las Ubicaciones donde se encuentre este cmentario).\n\n"
            };
            ImprimirDefinicion(lista);
        }
        public void ImprimirDefinicion(List<string> concepto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(concepto[0]);
            Console.ResetColor();
            Console.WriteLine(concepto[1]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(concepto[2]);
            Console.ResetColor();
            Console.WriteLine(concepto[3]);
        }
    }
    
}
