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

        public string setPatente
        {
            get
            {
                return this.patente;
            }
        }
        public EMarcas setMarca
        {
            get
            {
                return this.marca;
            }
        }
        protected string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Patente: {this.setPatente} // Cantidad de ruedas: {this.cantRuedas} // Marca: {this.setMarca}");
            return mensaje.ToString();
        }
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        public static bool operator ==(Vehiculo vehiculo1,Vehiculo vehiculo2) 
        {
            bool resultado=false;
            if ((object)vehiculo1==null && (object)vehiculo2 == null) 
            {
                resultado = true;
            }
            else if ((object)vehiculo1 != null && (object)vehiculo2 != null) 
            {
                if (vehiculo1.patente ==vehiculo2.patente && vehiculo1.marca == vehiculo2.marca) 
                {
                    resultado = true;
                }
            }
                return resultado;
        }
        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2) 
        {
            return !(vehiculo1==vehiculo2);
        }
    }
}