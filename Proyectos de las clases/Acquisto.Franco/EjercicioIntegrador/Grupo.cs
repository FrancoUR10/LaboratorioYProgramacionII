using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;

        public ETipoManada Tipo 
        {
            set 
            {
                Grupo.tipo = value;
            }
        }

        static Grupo() 
        {
            Grupo.tipo = ETipoManada.Unica;
        }
        private Grupo() 
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, ETipoManada tipo)
            : this(nombre)
        {
            Grupo.tipo = tipo;
        }
        public static bool operator==(Grupo g,Mascota m) 
        {
            bool seEncontro = false;
            foreach (Mascota unaMascota in g.manada)
            {
                if (unaMascota.Equals(m)) 
                {
                    seEncontro = true;
                }
            }
            return seEncontro;
        }
        public static bool operator !=(Grupo g, Mascota m) 
        {
            return !(g == m);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (obj is Grupo)
            {
                if (this == ((Grupo)obj))
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        /*
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        */
        public static Grupo operator +(Grupo g,Mascota m) 
        {
            if (g != m) 
            {
                g.manada.Add(m);
            }
            else 
            {
                Console.WriteLine("Ya se encuentra {0} en el grupo",m.ToString());
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m) 
        {
            if (g == m) 
            {
                g.manada.Remove(m);
            }
            else 
            {
                Console.WriteLine("No se encuentra {0} en el grupo", m.ToString());
            }
            return g;
        }
        public static implicit operator string(Grupo g) 
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Grupo: {g.nombre} - Tipo: {Grupo.tipo}");
            texto.AppendLine($"Integrantes: {g.manada.Count}");
            foreach (Mascota unaMascota in g.manada)
            {
                texto.AppendLine(unaMascota.ToString());
            }
            return texto.ToString();
        }
    }
}
