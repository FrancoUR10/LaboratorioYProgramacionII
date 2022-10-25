using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase04Sobrecarga
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa() 
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string cadena)
            :this()
        {
            this.cadena = cadena;
        }
        public Cosa(int entero, string cadena)
            :this(cadena)
        {
            this.entero = entero;
        }
        public Cosa(DateTime fecha, int entero, string cadena)
            :this(entero,cadena)
        {
            this.fecha = fecha;
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
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Entero: {this.entero}");
            texto.AppendLine($"Cadena: {this.cadena}");
            texto.AppendLine($"Fecha: {this.fecha}");
            return texto.ToString();
        }
        public static string Mostrar(Cosa miObjeto) 
        {
            return miObjeto.Mostrar();
        }

    }
}
