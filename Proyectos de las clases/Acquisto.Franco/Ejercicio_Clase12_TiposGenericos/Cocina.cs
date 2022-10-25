using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase12_TiposGenericos
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo 
        {
            get 
            {
                return this._codigo;
            }
        }
        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }
        public double Precio
        {
            get
            {
                return this._precio;
            }
        }
        public Cocina(int codigo,double precio,bool esIndustrial) 
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        public static bool operator ==(Cocina a, Cocina b)
        {
            bool sonIguales = false;
            if ((object)a == null && (object)b == null)
            {
                sonIguales = true;
            }
            else if ((object)a != null && (object)b != null) 
            {
                if (a._codigo == b._codigo) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Cocina a, Cocina b) 
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Cocina) 
            {
                if (this == (Cocina)obj) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"Codigo: {this._codigo} - ");
            texto.Append($"Precio: {this._precio} - ");
            if (this._esIndustrial) 
            {
                texto.Append("Es industrial");
            }
            else 
            {
                texto.Append("No es industrial");
            }
            return texto.ToString();
        }
    }
}
