using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int comparacion = 0;
            if (llamada1.duracion > llamada2.duracion)
            {
                comparacion = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                comparacion = -1;
            }
            return comparacion;
        }
        protected virtual string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Duración de la llamada: {this.duracion}");
            texto.AppendLine($"Número de destino: {this.nroDestino}");
            texto.AppendLine($"Número de origen: {this.nroOrigen}");
            return texto.ToString();
        }
        public static bool operator==(Llamada l1,Llamada l2) 
        {
            bool sonIguales = false;
            if ((object)l1 == null && (object)l2 == null) 
            {
                sonIguales = true;
            }
            else if ((object)l1 != null && (object)l2 != null) 
            {
                if(l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Llamada l1, Llamada l2) 
        {
            return !(l1 == l2);
        }
    }
}
