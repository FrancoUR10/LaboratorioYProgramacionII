using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Lavadero
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, byte cantRuedas, EMarcas marca, float cilindrada)
            : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
        protected override string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("MOTO");
            texto.Append(base.Mostrar());
            texto.AppendLine($"Cilindrada: {this.cilindrada}");
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
