using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_PracticaParcial
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append($"{this.nombre} - {this.raza}");
            return mensaje.ToString();
        }
        public static bool operator ==(Mascota m1, Mascota m2) 
        {
            return m1.nombre == m2.nombre && m1.raza == m2.raza;
        }
        public static bool operator !=(Mascota m1, Mascota m2) 
        {
            return !(m1==m2);
        }
    }
}
