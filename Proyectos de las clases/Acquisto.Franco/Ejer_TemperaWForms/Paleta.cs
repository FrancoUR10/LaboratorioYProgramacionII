using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_TemperasWForms
{
    public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        public Tempera this[int indice] 
        {
            get 
            {
                Tempera auxTempera=null;
                if(indice >= 0 && indice < this.cantidadMaximaColores) 
                {
                    auxTempera = this.temperas[indice];
                }
                return auxTempera;
            }
            set 
            {
                if(indice >=0 && indice < this.temperas.Count) 
                {
                    this.temperas[indice] = value;
                }
            }
        }
        public int CantidadTemperas 
        {
            get 
            {
                return this.temperas.Count;
            }
        }
        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }
        private Paleta(int cantidadMaximaColores) : this()
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
        }
        public static implicit operator Paleta(int cantidadMaximaColores)
        {
            return new Paleta(cantidadMaximaColores);
        }
        private string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Cantidad maxima: {this.cantidadMaximaColores}");
            foreach (Tempera unaTempera in this.temperas)
            {
                texto.AppendLine(Tempera.Mostrar(unaTempera));
            }
            return texto.ToString();
        }
        private int ObtenerIndice(Tempera unaTempera)
        {
            int indice = -1;
            for(int i=0; i < this.temperas.Count; i++) 
            {
                if (this.temperas[i] == unaTempera) 
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            return paleta.ObtenerIndice(tempera) != -1;
        }
        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }
        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.ObtenerIndice(tempera);
            if (indice != -1)
            {
                paleta.temperas[indice]+=tempera;
            }
            else if (paleta.temperas.Count < paleta.cantidadMaximaColores)
            {
                paleta.temperas.Add(tempera);
            }
            return paleta;
        }
        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.ObtenerIndice(tempera);
            int auxCantidad = tempera;
            auxCantidad *= -1;

            if (indice != -1)
            {
                paleta.temperas[indice] += auxCantidad;
                auxCantidad = paleta.temperas[indice];
                if (auxCantidad <= 0)
                {
                    paleta.temperas.RemoveAt(indice);
                }
            }
            return paleta;
        }
        public static Paleta operator +(Paleta paleta1, Paleta paleta2) 
        {
            int cantidadMaxima = paleta1.cantidadMaximaColores + paleta2.cantidadMaximaColores;
            Paleta nuevaPaleta = cantidadMaxima;

            nuevaPaleta.temperas = paleta1.temperas;
            foreach(Tempera unaTempera in paleta2.temperas) 
            {
                nuevaPaleta += unaTempera;
            }
            return nuevaPaleta;
        }
    }
}
