using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClaseMostrar
{
    public class Persona
    {
        public string nombre;

        public Persona(string nombre) 
        {
            this.nombre = nombre;
        }
        public virtual string Mostrar() 
        {
            return $"Nombre: {this.nombre}";
        }
    }
}
