using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos)
            : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        public string MostrarAuto()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("AUTO");
            mensaje.Append(base.Mostrar());
            mensaje.AppendLine($"Cantidad de asientos: {this.cantidadAsientos}");
            return mensaje.ToString();
        }
    }
}