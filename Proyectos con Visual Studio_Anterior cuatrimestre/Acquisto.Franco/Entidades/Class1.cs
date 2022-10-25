using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }
        private string Mostrar() 
        {
            string mensaje = "";
            StringBuilder texto = new StringBuilder();
            texto.Append($"Tipo de tinta: {this.tipo}---Color de Tinta: {this.color}");
            mensaje = texto.ToString();
            return mensaje;
        }
        public static string Mostrar(Tinta objeto) 
        {
            return objeto.Mostrar();
        }
        public static bool operator ==(Tinta objetoUno, Tinta objetoDos) 
        {
            bool sonIguales=false;
            if((objetoUno.tipo== objetoDos.tipo) && (objetoUno.color == objetoDos.color)) 
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Tinta objetoUno, Tinta objetoDos)
        {
            return !(objetoUno==objetoDos);
        }
        public static explicit operator string(Tinta objeto) 
        {
            return Tinta.Mostrar(objeto);
        }
    }
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }
        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }
        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            string mensaje = "";
            StringBuilder texto = new StringBuilder();
            texto.Append($"Marca: {this.marca} --- Tinta: {(string)this.tinta} --- Cantidad: {this.cantidad}");
            mensaje = texto.ToString();
            return mensaje;
        }
        public static bool operator ==(Pluma unaPluma,Tinta unaTinta) 
        {

            return (unaPluma.tinta == unaTinta);
        }
        public static bool operator !=(Pluma unaPluma, Tinta unaTinta)
        {

            return !(unaPluma == unaTinta);
        }
        public static Pluma operator + (Pluma unaPluma, Tinta unaTinta) 
        {
            if (unaPluma == unaTinta) 
            {
                unaPluma.cantidad++;
            }
            return unaPluma;
        }
        public static Pluma operator -(Pluma unaPluma, Tinta unaTinta)
        {
            if (unaPluma == unaTinta)
            {
                unaPluma.cantidad--;
            }
            return unaPluma;
        }
        public static implicit operator string(Pluma unaPluma) 
        {
            return unaPluma.Mostrar();
        }
    }
}
