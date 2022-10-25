using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;

        public override float CostoLlamada 
        {
            get 
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        private float CalcularCosto() 
        {
            float costoLlamada = 0;
            switch (this.franjaHoraria) 
            {
                case Franja.Franja_1:
                    costoLlamada = this.duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costoLlamada = this.duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costoLlamada = this.duracion * 0.66f;
                    break;
                default:
                    break;
            }
            return costoLlamada;
        }
        protected override string Mostrar() 
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.Mostrar());
            texto.AppendLine($"Costo: {this.CostoLlamada}");
            texto.AppendLine($"Franja horaria: {this.franjaHoraria}");
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (obj is Provincial)
            {
                if (this == (Provincial)obj)
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
    }
}
