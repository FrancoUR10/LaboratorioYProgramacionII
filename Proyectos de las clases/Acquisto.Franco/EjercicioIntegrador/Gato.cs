using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {
        }
        protected override string Ficha()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append("Gato - ");
            texto.Append(base.DatosCompletos());
            return texto.ToString();
        }
        public static bool operator ==(Gato g1,Gato g2) 
        {
            return ((Mascota)g1) == ((Mascota)g2);
        }
        public static bool operator !=(Gato g1, Gato g2) 
        {
            return !(g1 == g2);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (obj is Gato)
            {
                if (this == ((Gato)obj))
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
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
