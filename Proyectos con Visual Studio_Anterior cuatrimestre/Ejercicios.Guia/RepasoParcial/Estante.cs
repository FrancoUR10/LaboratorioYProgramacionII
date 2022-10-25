using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");
            sb.AppendLine("*****Lista de productos*****");
            foreach (Producto item in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(item));
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool seEncontro = false;
            foreach (Producto item in e.productos)
            {
                if (item == p)
                {
                    seEncontro = true;
                    break;
                }
            }
            return seEncontro;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            int indiceBusqueda = -1;
            bool sePuedeAgregar = false;
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if ((object)e.productos[i] == null)
                    {
                        indiceBusqueda = i;
                        break;
                    }
                }
            }
            if (indiceBusqueda != -1) 
            {
                e.productos[indiceBusqueda] = p;
                sePuedeAgregar = true;
            }
            return sePuedeAgregar;
        }
        public static Estante operator -(Estante e, Producto p) 
        {
            int indiceBusqueda = -1;
            if (e == p) 
            {
                for(int i = 0; i < e.productos.Length; i++) 
                {
                    if (e.productos[i] == p) 
                    {
                        indiceBusqueda = i;
                        break;
                    }
                }
                e.productos[indiceBusqueda] = null;
            }
            return e;
        }
    }
}
