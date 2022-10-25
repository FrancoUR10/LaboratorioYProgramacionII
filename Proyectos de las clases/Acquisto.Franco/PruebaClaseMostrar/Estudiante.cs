using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClaseMostrar
{
    public class Estudiante : Persona
    {
        public int legajo;

        public Estudiante(string nombre, int legajo)
            : base(nombre)
        {
            this.legajo = legajo;
        }

        public override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.Mostrar());
            texto.Append($"Legajo: {this.legajo}");
            return texto.ToString();
        }
    }
}
