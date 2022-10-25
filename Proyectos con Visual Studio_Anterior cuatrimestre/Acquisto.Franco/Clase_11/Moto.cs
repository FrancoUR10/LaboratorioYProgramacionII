using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente,byte cantRuedas,EMarcas marca,float cilindrada) 
            :base(patente,cantRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }
        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("MOTO");
            mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"Cilindrada: {this.cilindrada}");
            return mensaje.ToString();
        }
    }
}
