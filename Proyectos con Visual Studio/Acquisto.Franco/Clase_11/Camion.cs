using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(string patente, byte cantRuedas, EMarcas marca,float tara) 
            :base(patente,cantRuedas,marca)
        {
            this.tara = tara;
        }
        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("CAMION");
            mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"Tara: {this.tara}");
            return mensaje.ToString();
        }
    }
}
