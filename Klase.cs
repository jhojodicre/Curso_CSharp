using System;
using System.Collections.Generic;
using System.Text;
//using System.IO.Ports;
//using System.IO;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

namespace Curso_CSharp
{


    class Klase
    {
        //1. Constructores de una Clase pueden Haber Varios.
        //-1.1
        public Klase()
        {
            /* Esto es un Constructor de Clase porque tiene el mismo nombre de la clase
             y Accedemos  las propiedades de la calase
             Podemos crear tambien un contructor de clase vacio.
             Si no creamos el constructor de una clase, El compilador asume por defecto un constructor de clase vacio
             */
            estadoDePropiedad = "Objeto Creado";
        }
        //-1.2
        public Klase(bool _constructorSobreCarga)
        {
            /*este es otro contructor de la clase pero tiene un parametro, es por eso que es poible crear sobrecarga,
             porque con mismo nombre del metodo, debeemos crear una diferencia con respecto a los demos, dentro de sus parametros*/
            constructorSobreCarga = _constructorSobreCarga;
        }
        //2. Propiedades de La clase
        public string estadoDePropiedad = "Sin Crear";
        public bool constructorSobreCarga = false;
        private bool estadoDeClase = false;
        private bool propiedadAdicional;
        private bool nombresIguales = false;

        //3. Metodos de la Clase

        //-3.1 Metodo Get: Nos da informacion de una propiedad de la clase.
        public string GetEstadoDePropiedad()
        {
            return estadoDePropiedad;
        }

        public string GetExtras()
        {
            return "Informacion del coche:\n " + "estadoDeClase: " + estadoDeClase + "constructorDeSobreCarga: " + constructorSobreCarga;
        }
        //3.2 Metodos de Acceso: Modificamos la Propiedad de una Variable de acceso private
        public void CambiarPropiedad(bool _estadoDeClase)
        {
            estadoDeClase = _estadoDeClase;
        }

        //3.3 Metodo Setter: "Establecemos informacion  en una propiedad de la clase que No iniciamos desde el constructor y no devuelve info
        public void SetExtras(bool _propiedadAdicional, bool nombresIguales)
        {
            propiedadAdicional = _propiedadAdicional;
            this.nombresIguales = nombresIguales; // Con this 
        }

    }
}