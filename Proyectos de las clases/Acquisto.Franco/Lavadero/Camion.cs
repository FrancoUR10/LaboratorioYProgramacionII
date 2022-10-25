using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Lavadero
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(string patente,byte cantRuedas,EMarcas marca,float tara) 
            : base(patente,cantRuedas,marca)
        {
            this.tara = tara;
        }
        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("CAMION");
            texto.Append(base.Mostrar());
            texto.AppendLine($"Tara: {this.tara}");
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
