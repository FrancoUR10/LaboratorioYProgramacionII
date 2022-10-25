using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal 
        { 
            get 
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            } 
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get 
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita() 
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo) 
        {
            float costoTotal = 0;
            foreach (Llamada unaLlamada in this.listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local) 
                {
                    if(unaLlamada is Local) 
                    {
                        costoTotal += unaLlamada.CostoLlamada;
                    }
                }
                else if (tipo == Llamada.TipoLlamada.Provincial) 
                {
                    if(unaLlamada is Provincial) 
                    {
                        costoTotal += unaLlamada.CostoLlamada;
                    }
                }
                else if (tipo == Llamada.TipoLlamada.Todas) 
                {
                    costoTotal += unaLlamada.CostoLlamada;
                }
            }
            return costoTotal;
        }
        public void OrdenarLlamadas() 
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Empresa: {this.razonSocial}");
            texto.AppendLine($"Ganancias totales: {this.GananciasPorTotal}");
            texto.AppendLine($"Ganancias locales: {this.GananciasPorLocal}");
            texto.AppendLine($"Ganancias provinciales: {this.GananciasPorProvincial}");
            texto.AppendLine($"Detalles de las llamadas:");
            texto.AppendLine("");
            foreach (Llamada unaLlamada in this.listaDeLlamadas)
            {
                texto.AppendLine(unaLlamada.ToString());
            }
            return texto.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator==(Centralita c,Llamada llamada) 
        {
            bool seEncontro = false;
            foreach (Llamada unaLlamada in c.listaDeLlamadas)
            {
                if (unaLlamada.Equals(llamada)) 
                {
                    seEncontro = true;
                    break;
                }
            }
            return seEncontro;
        }
        public static bool operator !=(Centralita c, Llamada llamada) 
        {
            return !(c == llamada);
        }
        private void AgregarLlamada(Llamada nuevaLlamada) 
        {
            if (this != nuevaLlamada) 
            {
                this.listaDeLlamadas.Add(nuevaLlamada);
            }
            else 
            {
                throw new CentralitaException($"La llamada ingresada ya se encuentra en la centralina","Centralina","AgregarLlamada");
            }
        }
        public static Centralita operator +(Centralita c,Llamada nuevaLlamada) 
        {
            c.AgregarLlamada(nuevaLlamada);
            return c;
        }
    }
}
