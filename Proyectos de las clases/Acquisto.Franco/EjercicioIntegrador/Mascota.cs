using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
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

        public Mascota(string nombre,string raza) 
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        protected abstract string Ficha();
        protected virtual string DatosCompletos() 
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"{this.nombre} - {this.raza}");
            return texto.ToString();
        }
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool sonIguales = false;
            if (((object)m1) == null && ((object)m2) == null) 
            {
                sonIguales = true;
            }
            else if (((object)m1) != null && ((object)m2) != null) 
            {
                if (m1.nombre == m2.nombre && m1.raza == m2.raza) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Mascota m1, Mascota m2) 
        {
            return !(m1 == m2);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Mascota) 
            {
                if (this == ((Mascota)obj)) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        /*
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        */
    }
}
