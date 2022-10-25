using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        

        public static string Imprimir() 
        {
            string mensajeImpreso="";
            if(!Sello.TryParse(Sello.mensaje,out mensajeImpreso)) 
            {
                mensajeImpreso = "";
                
            }
            return mensajeImpreso;
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static string ArmarFormatoMensaje()
        {
            string fila;
            int largo;
            largo = Sello.mensaje.Length;
            
            fila = new string('*',largo + 2) + "\n";
            fila += "*" + Sello.mensaje + "*" + "\n";
            fila += new string('*',largo + 2) + "\n";

            return fila;
        }
        private static bool TryParse(string largo, out string mensaje) 
        {
            bool sePudo = false;
            mensaje = Sello.ArmarFormatoMensaje();
            if (largo.Length > 0) 
            {
                sePudo = true;
            }
            return sePudo;
        }
    }
}
