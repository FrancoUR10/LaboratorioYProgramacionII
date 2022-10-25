using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_PracticaParcial
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre,string raza) 
            :base(nombre,raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }
        public Perro(string nombre, string raza,int edad,bool esAlfa)
            : this(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        protected override string Ficha()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Perro - ");
            mensaje.Append(base.DatosCompletos());
            if (esAlfa == true) 
            {
                mensaje.Append(" - Alfa de la manada");
            }
            else 
            {
                mensaje.Append(" - Cruza");
            }
            mensaje.Append($" - Edad {this.edad}");
            return mensaje.ToString();
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Perro) 
            {
                if (this == (Perro)obj) 
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool respuesta = false;
            if ((Mascota)p1==(Mascota)p2) 
            {
                if ((int)p1 == (int)p2) 
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Perro p1, Perro p2) 
        {
            return !(p1==p2);
        }
        public static explicit operator int(Perro p) 
        {
            return p.edad;
        }
    }
}
