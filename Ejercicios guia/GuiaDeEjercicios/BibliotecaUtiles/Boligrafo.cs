using System;
using System.Text;

namespace BibliotecaUtiles
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta,ConsoleColor color) 
        {
            this.tinta = tinta;
            this.color = color;
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
            int sumaAuxiliarTinta = this.tinta + tinta;
            if (sumaAuxiliarTinta >= 0 && sumaAuxiliarTinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }
        public void Recargar() 
        {
            int recarga = cantidadTintaMaxima - this.tinta;
            this.SetTinta((short)recarga);
        }
        public bool Pintar(short gasto,out string dibujo) 
        {
            int auxiliarGasto;
            int auxiliarResta;
            dibujo = "";
            bool cantidadValida = false;
            StringBuilder dibujado = new StringBuilder();

            if (this.tinta >= gasto) 
            {
                auxiliarGasto = gasto;
                auxiliarResta = gasto + gasto;
                gasto -= (short)auxiliarResta;
                this.SetTinta(gasto);
                cantidadValida = true;
            }
            else 
            {
                auxiliarResta = gasto - this.tinta;
                gasto -= (short)auxiliarResta;
                auxiliarGasto = gasto;
                this.tinta = 0;
            }
            for(int i = 0; i < auxiliarGasto; i ++) 
            {
                dibujado.Append("*");

            }
            Console.ForegroundColor=this.color;
            dibujo = dibujado.ToString();
            return cantidadValida;
        }
    }
}
