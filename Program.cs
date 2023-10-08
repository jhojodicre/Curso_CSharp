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
            Klase Clase = new Klase();

            //2. Consultas
            PaQSirve._partial();
            QueEs.PascalCase();

            Clase.GetInformacion();
        }
    }

    public class Glosario
    {
        public void PascalCase()
        {
            string nombre               = "PascalCase:\n";
            string definicion           = "Es una Convencion; Todas las variables, metodos de tipo public deben comenzar con la primera letra de\n las palabaras en Mayuscula.\n";
            string ejemplo              = "       Por ejemplo:\n";
            string implementacion       = "           MiMetodo";
            string nota = "";
            string notaDefinicion = "\n\n";
        }
        public void camelCase()
        {
            List<string> lista = new List<string>
            {
            "camelCase:\n",
            "   Es cuando una variable o metodo es de acceso private la primera palabra serà en Minuscula ejemplo: miFuncion",
            "       Por ejemplo:\n",
            "",
            "Nota:\n",
            "   ->"
            };
            ImprimirDefinicion(lista);
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
        public void campoDeClase()
        {
            List<string> lista = new List<string>
            {
            "Campo de Clase:\n",
            "   Es una propiedad o Variable creada dentro de una Clase",
            "       Por ejemplo:\n",
            "class CampodeClase\n" +
            "{\n" +
            "public int VariableNew = 1;" +
            "\n" +
            "}" +
            "\n\n"
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
            try
            {
                //1. Definicion
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(concepto[0]);
                Console.ResetColor();
                Console.WriteLine(concepto[1]);

                //2. Por Ejemplo
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(concepto[2]);
                //3. Referencia de Ejemplo
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(concepto[3]);

                //3. Detalles del Ejemplo
                Console.ResetColor();
                Console.WriteLine(concepto[4]);

                //4. Nota
                Console.WriteLine(concepto[5]);
            }
            catch (Exception e) { }

        }
        
    }
    //TODO: Realizar otra clase con otros metodos distintos,
    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }

}
