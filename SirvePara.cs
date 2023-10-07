using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    public class SirvePara
    {
        public void _this()
        {
            string definicion = "this";
            List<string> concepto = new List<string>
            {
            "Palabra Reservada:",
            definicion,
            "   Diferenciar una propiedad de la clase con respecto a un parametro de clase que tengan el mismo nombre.",
            "   ¡Aqui va lo que no se puede hacer\n\n",
            "       Por ejemplo:",
            "           this.variable_1 = variable1  \n",
            "               (this.variable1) hace referencia a la propiedad de la clase y \n",
            "               (variable1) es el parametro recibido con el mismo nombre de propiedad de clase.\n\n",
            "Nota:",
            "        esta es la nota",
            " \n\n",
            " \n\n"
            };
            ImprimirDefinicion(concepto);
        }
        public void _partial()
        {
            string definicion = "partial";
            List<string> concepto = new List<string>
            {
                "Keyword\n",
                definicion,
                "   Nos permite dividir la clase en Dos",
                "   ¡\n\n",
                "       Por ejemplo:",
                "           "+definicion+" class Division",
                "               "+"("+definicion+") "+ "es el prefijo delante de la palabra class que queremos dividir.\n\n",
                "partial class Division\n{\n//parte 1\n\n}\npartial class Division\n{\n // parte 2\n\n}",
                "Nota:",
                "       deben haber al menos dos definiciones de particion."+"V#31",
                "       partial class Division {} seguidamente de partial class Division{}\n\n",
                " "
            };
            ImprimirDefinicion(concepto);
        }
        public void _nombre()
        {
            string definicion = "nombre";
            List<string> concepto = new List<string>
            {
                "Keyword\n",
                definicion,
                "   Es una plantilla para definir conceptos",
                "   ¡\n\n",
                "       Por ejemplo:",
                "           "+definicion+"",
                "               "+"("+definicion+") "+"es el nombre de la palabra reservada que queremos mencionar.\n\n",
                " ",
                "Nota:",
                "       x n m s d",
                " \n\n",
                " "
            };
            ImprimirDefinicion(concepto);
        }
        public void ImprimirDefinicion(List<string> concepto)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(concepto[0]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(concepto[1]);
            Console.ResetColor();
            Console.WriteLine(concepto[2]);

            //Advertencia.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(concepto[3]);


            // Por Ejemplo
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(concepto[4]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(concepto[5]);

            Console.ResetColor();
            Console.WriteLine(concepto[6]);
            Console.WriteLine(concepto[7]);

            //Nota
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(concepto[8]);
            Console.ResetColor();
            Console.WriteLine(concepto[9]);
            Console.WriteLine(concepto[10]);
        }

    }
}
/*Porocedimiento de Definicion.
 * Definir que es, para que sirve cual es el alcance, como se hace, donde se aplica, ventajas y desventajas.
 * 
  */