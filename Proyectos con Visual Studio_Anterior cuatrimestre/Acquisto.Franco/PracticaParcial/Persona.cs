using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        public short Edad 
        {
            get 
            {
                return this.edad;
            }
            set 
            {
                this.edad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        protected virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre} - Edad: {this.edad}");
            return sb.ToString();
        }
        protected Persona(string nombre, short edad) 
        {
            this.nombre=nombre;
            this.edad = edad;
        }
        public abstract bool Validar();
        
        public static explicit operator string(Persona persona) 
        {
            return persona.nombre;
        }
    }
}
