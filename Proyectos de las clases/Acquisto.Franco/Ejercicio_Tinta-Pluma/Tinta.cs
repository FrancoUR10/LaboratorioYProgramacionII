using System;
using System.Text;

namespace Ejercicio_Tinta_Pluma
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;
        
        public Tinta() 
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color)
            :this()
        {
            this.color = color;
        }
        public Tinta(ConsoleColor color,ETipoTinta tipo)
            :this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar() 
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Color: {this.color}");
            texto.AppendLine($"Tipo: {this.tipo}");
            return texto.ToString();
        }
        public static string Mostrar(Tinta tinta) 
        {
            return tinta.Mostrar();
        }
        public static bool operator ==(Tinta tinta1,Tinta tinta2) 
        {
            return tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo;
        }
        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1==tinta2);
        }
        public static explicit operator string(Tinta tinta) 
        {
            return Tinta.Mostrar(tinta);
        }
    }
}
