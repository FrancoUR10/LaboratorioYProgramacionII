using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Gente : Persona
    {
        public Gente(short edad) 
            :base("",edad)
        {

        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if(this is Gente) 
            {
                sb.AppendLine("GENTE");
                sb.Append(base.Mostrar());
            }
            return sb.ToString();
        }
        public override bool Validar()
        {
            bool esMayorDeEdad = false;
            if(this.Edad > 18)
            {
                esMayorDeEdad = true;
            }
            return esMayorDeEdad;
        }
    }
}
