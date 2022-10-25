using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio
{
    public class Camion : Vehiculo
    {
        protected float tara;
        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara)
            : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        public string MostrarCamion()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("CAMION");
            mensaje.Append(base.Mostrar());
            mensaje.AppendLine($"Tara: {this.tara}");
            return mensaje.ToString();
        }
    }
}
