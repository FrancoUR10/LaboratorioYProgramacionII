using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_PracticaParcial
{
    public class Gato : Mascota
    {
        public Gato(string nombre,string raza) 
            :base(nombre,raza)
        {
        }
        protected override string Ficha()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Gato - ");
            mensaje.Append(base.DatosCompletos());
            return mensaje.ToString();
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            bool respuesta=false;
            if(obj is Gato) 
            {
                if (this == (Gato)obj) 
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator==(Gato g1,Gato g2) 
        {
            bool respuesta = false;
            if ((Mascota)g1==(Mascota)g2) 
            {
                respuesta = true;
            }
            return respuesta;
        }
        public static bool operator !=(Gato g1, Gato g2) 
        {
            return !(g1==g2);
        }
    }
}
