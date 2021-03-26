using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSello
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir() 
        {
            string decorado;
            Sello.TryParse(Sello.mensaje, out decorado);
            return decorado;
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor() 
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static string ArmarFormatoMensaje() 
        {
            string decoracion="";
            decoracion = new string('*', Sello.mensaje.Length +2) + "\n";
            decoracion += "*" + Sello.mensaje + "*" + "\n";
            decoracion+= new string('*', Sello.mensaje.Length+2) + "\n";

            return decoracion;
        }
        private static bool TryParse(string texto,out string decoracion)
        {
            decoracion = "";
            bool sePuede = false;
            if(texto.Length > 0) 
            {
                decoracion = ArmarFormatoMensaje();
                sePuede = true;
            }
            return sePuede;
        }
    }
}
