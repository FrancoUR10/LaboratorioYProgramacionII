using System;
using System.Text;

namespace Ejer_01Prestamo
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string titular,float cantidad) 
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string Titular 
        {
            get 
            {
                return this.titular;
            }
        }
        public float Cantidad 
        {
            get 
            {
                return this.cantidad;
            }
        }
        private string Mostrar() 
        {
            StringBuilder listado = new StringBuilder();
            listado.AppendLine($"Titular: {this.Titular}");
            listado.AppendLine($"Cantidad: {this.Cantidad}");
            return listado.ToString();
        }
        public static string Mostrar(Cuenta unaCuenta) 
        {
            return unaCuenta.Mostrar();
        }
        public void Ingresar(float cantidad) 
        {
            if(cantidad > 0) 
            {
                this.cantidad += cantidad;
            }
        }
        public void Retirar(float cantidad)
        {
            this.cantidad -= cantidad;
        }
    }
}
