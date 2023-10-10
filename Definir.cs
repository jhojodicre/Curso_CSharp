using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    internal class Definir
    {
        string nombre;
        string definicion;
        string ejemplo;
        string implementacion;
        string nota;
        string notaDefinicion;


        public Definir()
        {
            this.nombre         = "\n";
            this.definicion     = "   \n";
            this.ejemplo        = "      Por ejemplo:\n";
            this.implementacion = "           MiMetodo\n";
            this.nota           = "Nota:";
            this.notaDefinicion = "     note\n\n";
        }
        public void Imprimir(Definir concepto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.nombre);
            Console.ResetColor();
            Console.WriteLine(this.definicion);

            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(this.ejemplo);
            Console.ResetColor();
            Console.WriteLine(this.implementacion);

            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine(this.nota);
            Console.ResetColor();
            Console.WriteLine(this.notaDefinicion);
        }
    }
}
