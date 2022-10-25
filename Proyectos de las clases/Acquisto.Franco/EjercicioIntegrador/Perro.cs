using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza)
            : this(nombre, raza,0,false)
        {

        }
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        protected override string Ficha() 
        {
            StringBuilder texto = new StringBuilder();
            texto.Append("Perro - ");
            texto.Append(base.DatosCompletos());
            if (this.esAlfa) 
            {
                texto.Append(" - alfa de la manada - ");
            }
            texto.Append($"Edad: {this.edad}");
            return texto.ToString();
        }
        public static bool operator==(Perro p1,Perro p2) 
        {
            bool sonIguales = false;
            if(p1 == ((Mascota)p2)) 
            {
                if(p1.edad == p2.edad) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Perro p1, Perro p2) 
        {
            return !(p1 == p2);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Perro) 
            {
                if (this == ((Perro)obj)) 
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
        public static explicit operator int(Perro p) 
        {
            return p.edad;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
