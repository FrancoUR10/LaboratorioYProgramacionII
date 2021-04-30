using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_PracticaParcial
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
            :this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre,ETipoManada tipo)
            :this(nombre)
        {
            Grupo.tipo = tipo;
        }
        public static bool operator==(Grupo g, Mascota m) 
        {
            bool respuesta = false;
            foreach(Mascota item in g.manada) 
            {
                if (item.Equals(m)) 
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Grupo g, Mascota m) 
        {
            return !(g==m);
        }
        public static Grupo operator+(Grupo g,Mascota m) 
        {
            if (g != m) 
            {
                g.manada.Add(m);
            }
            else 
            {
                Console.WriteLine("{0} ya se encuentra en el grupo",m.ToString());
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
                Console.WriteLine("{0} no se encuentra en el grupo",m.ToString());
            }
            return g;
        }
        public static implicit operator string(Grupo g) 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Grupo: {g.nombre} - Tipo: {Grupo.tipo}");
            mensaje.AppendLine($"Integrantes ({g.manada.Count()})");
            foreach(Mascota item in g.manada) 
            {
                mensaje.AppendLine(item.ToString());
            }
            return mensaje.ToString();
        }
    }
}
