using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Lavadero
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(string patente,byte cantRuedas,EMarcas marca, int cantidadAsientos) 
            : base(patente,cantRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        protected override string Mostrar() 
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("AUTO");
            texto.Append(base.Mostrar());
            texto.AppendLine($"Cantidad de asientos: {this.cantidadAsientos}");
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
