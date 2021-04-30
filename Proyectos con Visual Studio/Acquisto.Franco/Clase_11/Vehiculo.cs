using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    public class Vehiculo
    {
        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;

        public string Patente 
        {
            get 
            {
                return this.patente;
            }
        }
        public EMarcas Marca
        {
            get 
            {
                return this.marca;
            }
        }
        public string GetVehiculo 
        {
            get 
            {
                return this.Mostrar();
            }
        }
        protected virtual string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Patente: {this.Patente}");
            mensaje.AppendLine($"Cantidad de ruedas: {this.cantRuedas}");
            mensaje.AppendLine($"Marca: {this.Marca}");
            return mensaje.ToString();
        }
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca) 
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        public static bool operator==(Vehiculo v1, Vehiculo v2) 
        {
            return v1.marca==v2.marca && v1.patente==v2.patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2) 
        {
            return !(v1==v2);
        }
    }
}
