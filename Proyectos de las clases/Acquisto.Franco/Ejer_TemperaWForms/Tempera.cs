using System;
using System.Text;

namespace Ejer_TemperasWForms
{
    public class Tempera
    {
        private ConsoleColor color;
        private String marca;
        private Int32 cantidad;

        public String Marca 
        {
            get 
            {
                return this.marca;
            }
        }
        public ConsoleColor Color 
        {
            get 
            {
                return this.color;
            }
        }
        public Tempera(ConsoleColor color, String marca, Int32 cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Color: {this.color}");
            texto.AppendLine($"Marca: {this.marca}");
            texto.AppendLine($"Cantidad: {this.cantidad}");
            return texto.ToString();
        }
        public static string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }
        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool sonIguales = false;
            if((object)tempera1==null && (object)tempera2 == null) 
            {
                sonIguales = true;
            }
            else if((object)tempera1 != null && (object)tempera2 != null) 
            {
                if (tempera1.marca == tempera2.marca && tempera1.color == tempera2.color) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }
        public static implicit operator int(Tempera tempera)
        {
            return tempera.cantidad;
        }
        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {
                tempera1 += tempera2.cantidad;
            }
            return tempera1;
        }
        public static Tempera operator +(Tempera tempera, int cantidad)
        {
            tempera.cantidad += cantidad;
            return tempera;
        }

    }
}
