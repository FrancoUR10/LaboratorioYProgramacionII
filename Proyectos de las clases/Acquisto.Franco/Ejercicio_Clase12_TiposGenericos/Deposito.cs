using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase12_TiposGenericos
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad) 
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        private int GetIndice(T a) 
        {
            int indice = -1;
            for (int i = 0; i < this._lista.Count; i++) 
            {
                if (this._lista[i].Equals(a)) 
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public bool Agregar(T a) 
        {
            bool seAgrego = false;
            if (this.GetIndice(a) == -1 && this._lista.Count < this._capacidadMaxima) 
            {
                this._lista.Add(a);
                seAgrego = true;
            }
            return seAgrego;
        }
        public bool Remover(T a)
        {
            bool seRemovio = false;
            if (this.GetIndice(a) != -1)
            {
                this._lista.Remove(a);
                seRemovio = true;
            }
            return seRemovio;
        }
        public static bool operator +(Deposito<T> d, T a)
        {
            return d.Agregar(a);
        }
        public static bool operator -(Deposito<T> d, T a)
        {
            return d.Remover(a);
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Capacidad máxima: {this._capacidadMaxima}");
            texto.AppendLine($"***Depósito de la clase {typeof(T).Name.ToLower()}***");
            foreach (T item in this._lista)
            {
                texto.AppendLine(item.ToString());
            }
            return texto.ToString();
        }
    }
}
