using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca,string codigo,float precio) 
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca() 
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra;
        }
        public static string MostrarProducto(Producto p) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Codigo de barra: {(string)p} - Marca: {p.GetMarca()} - Precio: {p.GetPrecio()}");
            return sb.ToString();
        }
        public static bool operator==(Producto p1,Producto p2) 
        {
            bool respuesta = false;
            if((object)p1==null && (object)p2 == null) 
            {
                respuesta = true;
            }
            else if ((object)p1 != null && (object)p2 != null)
            {
                if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra) 
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Producto p1, Producto p2) 
        {
            return !(p1==p2);
        }
        public static bool operator ==(Producto p,string marca) 
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca) 
        {
            return !(p==marca);
        }
    }
}
