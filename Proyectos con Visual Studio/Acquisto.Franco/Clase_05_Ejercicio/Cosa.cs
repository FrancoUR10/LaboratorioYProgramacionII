using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04_Ejercicio
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa(DateTime fecha, int entero, string cadena) :this(entero,cadena)
        {
            this.fecha = fecha;
        }
        public Cosa(int entero, string cadena) : this(cadena)
        {
            this.entero = entero;
        }
        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
        }
        public Cosa() 
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public void EstablecerValor(int entero) 
        {
            this.entero = entero;
        }
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar() 
        {
            string mensaje="";
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Entero: {this.entero} // Cadena: {this.cadena} // Fecha: {this.fecha}");
            mensaje=texto.ToString();
            return mensaje;
        }
        public static string Mostrar(Cosa objeto)
        {
            string mensaje = "";
            mensaje=objeto.Mostrar();
            return mensaje;
        }
    }
}
