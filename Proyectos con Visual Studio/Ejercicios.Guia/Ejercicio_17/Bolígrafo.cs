using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Bolígrafo
    {
        public static short cantidadTintaMaxima;
        private ConsoleColor color;
        private short tinta;

        static Bolígrafo() 
        {
            Bolígrafo.cantidadTintaMaxima = 100;
        }
        public Bolígrafo(short tinta, ConsoleColor color) 
        {
            this.color = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor() 
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta) 
        {
            short auxCantidad = this.tinta;
            auxCantidad += tinta;
            if(auxCantidad >= 0 && auxCantidad <= Bolígrafo.cantidadTintaMaxima) 
            {
                this.tinta +=tinta;
            }
        }
        public void Recargar() 
        {
            short auxTinta=(short)(Bolígrafo.cantidadTintaMaxima - this.tinta);
            this.SetTinta(auxTinta);
        }
        public bool Pintar(short gasto, out string dibujo) 
        {
            bool sePudoPintar=false;
            dibujo = "";
            while(this.tinta > 0 && gasto > 0)
            {
                Console.ForegroundColor = this.GetColor();
                SetTinta(-1);
                gasto--;
                dibujo += new string('*',1);
                sePudoPintar = true;
            }
            return sePudoPintar;
        }
    }
}
