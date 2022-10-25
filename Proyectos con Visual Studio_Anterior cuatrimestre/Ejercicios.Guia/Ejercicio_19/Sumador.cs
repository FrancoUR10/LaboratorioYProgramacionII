using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;
        public void Sumadores(int cantidadSumas) 
        {
            this.cantidadSumas = cantidadSumas;
        }
        public void Sumadores() 
        {
            this.Sumadores(0);
        }
        public long Sumar(long a,long b) 
        {
            this.cantidadSumas++;
            long resultado = a + b;
            return resultado;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            string cadena = "";
            cadena = string.Concat(a, b);
            return cadena;
        }
        public static explicit operator int(Sumador objeto) 
        {
            return objeto.cantidadSumas;
        }
        public static long operator + (Sumador objeto, int valorASumar) 
        {
            return (long)objeto.cantidadSumas + valorASumar;
        }
        public static bool operator |(Sumador objeto1, Sumador objeto2)
        {
            bool sonIguales = false;
            if (objeto1.cantidadSumas == objeto2.cantidadSumas) 
            {
                sonIguales = true;
            }
            return sonIguales;
        }
    }
}
