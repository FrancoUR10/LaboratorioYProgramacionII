using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase12_TiposGenericos
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad) 
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        private int GetIndice(Cocina c) 
        {
            int indice = -1;
            for(int i = 0; i < this._lista.Count; i++) 
            {
                if (this._lista[i] == c) 
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public bool Agregar(Cocina c) 
        {
            bool seAgrego = false;
            if (this.GetIndice(c) == -1 && this._lista.Count < this._capacidadMaxima) 
            {
                this._lista.Add(c);
                seAgrego = true;
            }
            return seAgrego;
        }
        public bool Remover(Cocina c)
        {
            bool seRemovio = false;
            if (this.GetIndice(c) != -1)
            {
                this._lista.Remove(c);
                seRemovio = true;
            }
            return seRemovio;
        }
        public static bool operator +(DepositoDeCocinas d, Cocina c) 
        {
            return d.Agregar(c);
        }
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            return d.Remover(c);
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Capacidad máxima: {this._capacidadMaxima}");
            texto.AppendLine($"***Depósito de cocinas***");
            foreach (Cocina unaCocina in this._lista) 
            {
                texto.AppendLine(unaCocina.ToString());
            }
            return texto.ToString();
        }
    }
}
