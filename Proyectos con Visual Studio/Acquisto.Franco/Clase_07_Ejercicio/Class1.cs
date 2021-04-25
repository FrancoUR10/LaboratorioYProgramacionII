using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07_Ejercicio
{
    public class Tempera 
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color,string marca,int cantidad) 
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        private string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Color: {this.color} // Marca: {this.marca} // Cantidad: {this.cantidad}");
            return mensaje.ToString();
        }
        public static string Mostrar(Tempera tempera) 
        {
            string mensaje = "";
            if (null != tempera)
            {
                mensaje = tempera.Mostrar();
            }
            return mensaje;
        }
        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool resultado = false;
            if ((object)tempera1 == null && (object)tempera2 == null)
            {
                resultado = true;
            }
            else if ((object)tempera1 != null && (object)tempera2 != null)
            {
                if (tempera1.color == tempera2.color && tempera1.marca == tempera2.marca)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        public static bool operator !=(Tempera tempera1, Tempera tempera2) 
        {
            return !(tempera1==tempera2);
        }
        public static implicit operator int(Tempera tempera) 
        {
            return tempera.cantidad;
        }
        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 != null && tempera2 != null) 
            {
                if (tempera1 == tempera2) 
                {
                    tempera1.cantidad += tempera2;
                }
            }
            return tempera1;
        }
        public static Tempera operator +(Tempera tempera,int cantidad) 
        {
            if (null != tempera) 
            {
                tempera.cantidad += cantidad;
            }
            return tempera;
        }
    }
    public class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaColores;

        private Paleta() : this(5)
        {
        }
        private Paleta(int cantidadMaximaColores)
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
            this.temperas = new Tempera[this.cantidadMaximaColores];
        }
        public static implicit operator Paleta(int cantidad)
        {
            Paleta paleta = new Paleta(cantidad);
            return paleta;
        }
        private string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Cantidad de colores: {this.cantidadMaximaColores}");
            foreach (Tempera objeto in this.temperas)
            {
                mensaje.AppendLine($"{Tempera.Mostrar(objeto)}");
            }
            return mensaje.ToString();
        }
        public static explicit operator string(Paleta paleta)
        {
            string mensaje = "";
            if (null != paleta)
            {
                mensaje = paleta.Mostrar();
            }
            return mensaje;
        }
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool resultado = false;
            int indice = paleta.ObtenerIndice(tempera);
            if (indice != -1)
            {
                resultado = true;
            }
            return resultado;
        }
        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }
        public int ObtenerIndice()
        {
            return ObtenerIndice(null);
        }
        public int ObtenerIndice(Tempera temperaABuscar)
        {
            int indiceBusqueda = -1;
            for (int i = 0; i < this.temperas.Length; i++)
            {
                if (this.temperas[i] == temperaABuscar)
                {
                    indiceBusqueda = i;
                    break;
                }
            }
            return indiceBusqueda;
        }
        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int indice;
            indice = paleta.ObtenerIndice(tempera);
            if (paleta == tempera)
            {
                paleta.temperas[indice] += tempera;
            }
            else
            {
                indice = paleta.ObtenerIndice();
                if (indice != -1) 
                {
                    paleta.temperas[indice] = tempera;
                }
            }
            return paleta;
        }
        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.ObtenerIndice(tempera);
            int cantidadEnTempera;
            if (paleta == tempera)
            {
                cantidadEnTempera = (0 - tempera);
                paleta.temperas[indice] += cantidadEnTempera;
                cantidadEnTempera = paleta.temperas[indice];
                if(cantidadEnTempera <= 0) 
                {
                    paleta.temperas[indice] = null;
                }
            }
            return paleta;
        }
        public static Paleta operator +(Paleta paleta1, Paleta paleta2)
        {
            Paleta nuevaPaleta = new Paleta(paleta1.cantidadMaximaColores + paleta2.cantidadMaximaColores);
            foreach (Tempera objeto in paleta1.temperas) 
            {
                nuevaPaleta.temperas[nuevaPaleta.ObtenerIndice()]= objeto;
            }
            foreach (Tempera objeto in paleta2.temperas)
            {
                nuevaPaleta.temperas[nuevaPaleta.ObtenerIndice()] = objeto;
            }
            return nuevaPaleta;
        }
    }
}