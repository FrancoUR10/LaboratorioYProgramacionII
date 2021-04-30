using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio
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
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        protected string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Patente: {this.Patente}");
            mensaje.AppendLine($"Cantidad de ruedas: {this.cantRuedas}");
            mensaje.AppendLine($"Marca: {this.Marca}");
            return mensaje.ToString();
        }
        public static bool operator ==(Vehiculo v1,Vehiculo v2) 
        {
            return v1.Patente == v2.Patente && v1.Marca == v2.Marca;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2) 
        {
            return !(v1==v2);
        }
    }
}