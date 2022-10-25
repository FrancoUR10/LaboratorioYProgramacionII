using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase12_TiposGenericos
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color 
        {
            get 
            {
                return this._color;
            }
        }
        public string Marca
        {
            get
            {
                return this._marca;
            }
        }
        public Auto(string color,string marca) 
        {
            this._color = color;
            this._marca = marca;
        }
        public static bool operator ==(Auto a, Auto b)
        {
            bool sonIguales = false;
            if ((object)a == null && (object)b == null)
            {
                sonIguales = true;
            }
            else if ((object)a != null && (object)b != null) 
            {
                if (a._marca == b._marca && a._color == b._color) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Auto a, Auto b) 
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Auto) 
            {
                if (this == (Auto)obj) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"Marca: {this._marca} - ");
            texto.Append($"Color: {this._color}");
            return texto.ToString();
        }
    }
}
