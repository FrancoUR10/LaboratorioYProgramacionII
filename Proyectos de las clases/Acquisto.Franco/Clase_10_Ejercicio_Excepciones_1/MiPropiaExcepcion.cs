using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio_Excepciones_1
{
    class MiPropiaExcepcion : Exception
    {
        private string mensaje;
        public MiPropiaExcepcion(string mensaje) 
        {
            this.mensaje = mensaje;
        }
        public MiPropiaExcepcion(string mensaje, MiPropiaExcepcion e)
            : this(mensaje)
        {
            this.mensaje = e.mensaje + " " + this.mensaje;
        }
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }
    }
}
