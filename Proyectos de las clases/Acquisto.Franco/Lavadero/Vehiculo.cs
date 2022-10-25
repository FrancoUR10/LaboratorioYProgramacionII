using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Lavadero
{
    public class Vehiculo
    {
        #region Atributos

        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;

        #endregion

        #region Propiedades
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
        #endregion

        protected virtual string Mostrar() 
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Patente: {this.patente}");
            texto.AppendLine($"Cantidad de ruedas: {this.cantRuedas}");
            texto.AppendLine($"Marca: {this.marca}");
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public Vehiculo(string patente,byte cantRuedas,EMarcas marca) 
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        #region Sobrecargas de igualdad
        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            bool sonIguales = false;
            if(((object)vehiculo1)==null && ((object)vehiculo2) == null) 
            {
                sonIguales = true;
            }
            else if (((object)vehiculo1) != null && ((object)vehiculo2) != null) 
            {
                if (vehiculo1.patente == vehiculo2.patente && vehiculo1.marca == vehiculo2.marca)  
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2) 
        {
            return !(vehiculo1 == vehiculo2);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Vehiculo) 
            {
                if (this == ((Vehiculo)obj)) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales; 
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion


    }
}
/*
 Y los siguientes métodos:
Sobrecarga de operadores:
 (+) == (Vehiculo, Vehiculo) : bool. Si las patentes y marcas son iguales, retorna TRUE.
 */