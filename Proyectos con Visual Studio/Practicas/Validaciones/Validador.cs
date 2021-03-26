using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    class Validador
    {
        public static bool setInt(out int numero)
        {
            return int.TryParse(Console.ReadLine(), out numero);
        }
        public static bool setFloat(out float numero)
        {
            return float.TryParse(Console.ReadLine(), out numero);
        }
        public static bool setChar(out char caracter)
        {
            return char.TryParse(Console.ReadLine(), out caracter);
        }
        public static void setString(out string mensaje)
        {
            mensaje = Console.ReadLine();
        }
        public static bool ValidarNumeroRango(string mensajeIngreso, out int numero, int minimo, int maximo, string mensajeError)
        {
            Console.Write(mensajeIngreso);
            bool sePudo = Validador.setInt(out numero);
            while ((sePudo == false) || (numero < minimo || numero > maximo))
            {
                Console.Write(mensajeError);
                sePudo = Validador.setInt(out numero);
            }
            return sePudo;
        }
        public static bool ValidarNumeroFloatRango(string mensajeIngreso, out float numero, float minimo, float maximo, string mensajeError) 
        {
            Console.Write(mensajeIngreso);
            bool sePudo = Validador.setFloat(out numero);
            while ((sePudo == false) || (numero < minimo || numero > maximo))
            {
                Console.Write(mensajeError);
                sePudo = Validador.setFloat(out numero);
            }
            return sePudo;
        }
        public static bool ValidarOpcion(string mensaje, out char caracter,string mensajeError) 
        {
            Console.WriteLine(mensaje);
            bool respuesta=false;
            Validador.setChar(out caracter);
            caracter=char.ToLower(caracter);
            while(caracter != 's' && caracter != 'n') 
            {
                Console.WriteLine(mensajeError);
                Validador.setChar(out caracter);
                caracter = char.ToLower(caracter);
            }
            if (caracter == 's') 
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
