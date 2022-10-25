using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02_EjerSello
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;


        public static string Imprimir() 
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar() 
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor() 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }
        private static string ArmarFormatoMensaje()
        {
            int tamaño = Sello.mensaje.Length;
            StringBuilder mensaje = new StringBuilder();
            string bordes = "";

            if (tamaño > 0)
            {
                for (int i = 0; i < tamaño + 2; i++) 
                {
                    bordes=mensaje.Append("*").ToString();
                }

                mensaje.AppendLine("\n"+"*"+Sello.mensaje+"*"+"\n"+bordes);
            }

            return mensaje.ToString();
        }
    }
}
