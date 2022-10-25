using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente,byte cantRuedas,EMarcas marca,float cilindrada) 
            :base(patente,cantRuedas,marca)
        {
            this.cilindrada = cilindrada;
        }
        public string MostrarMoto() 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("MOTO");
            mensaje.Append(base.Mostrar());
            mensaje.AppendLine($"Cilondrada: {this.cilindrada}");
            return mensaje.ToString();
        }
    }
}
