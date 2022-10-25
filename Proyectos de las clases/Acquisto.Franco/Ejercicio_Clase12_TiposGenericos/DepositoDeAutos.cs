using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase12_TiposGenericos
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad) 
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }
        private int GetIndice(Auto a)
        {
            int indice = -1;
            for (int i = 0; i < this._lista.Count; i++) 
            {
                if (this._lista[i] == a) 
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public bool Agregar(Auto a) 
        {
            bool seAgrego = false;
            if (this.GetIndice(a) == -1 && this._lista.Count < this._capacidadMaxima) 
            {
                this._lista.Add(a);
                seAgrego = true;
            }
            return seAgrego;
        }
        public bool Remover(Auto a)
        {
            bool seRemovio = false;
            if (this.GetIndice(a) != -1) 
            {
                this._lista.Remove(a);
                seRemovio = true;
            }
            return seRemovio;
        }
        public static bool operator +(DepositoDeAutos d, Auto a) 
        {
            return d.Agregar(a);
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            return d.Remover(a);
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Capacidad máxima: {this._capacidadMaxima}");
            texto.AppendLine($"***Depósito de autos***");
            foreach (Auto unAuto in this._lista)
            {
                texto.AppendLine(unAuto.ToString());
            }
            return texto.ToString();
        }
    }
}
