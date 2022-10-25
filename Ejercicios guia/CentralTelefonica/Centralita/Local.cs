using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        private float CalcularCosto() 
        {
            return this.costo * this.duracion;
        }
        protected override string Mostrar() 
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.Mostrar());
            texto.AppendLine($"Costo: {this.CostoLlamada}");
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Local) 
            {
                if (this == (Local)obj) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
    }
}
