using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    class Validador
    {
        public static bool IngresarDatos(out int numero) 
        {
            return int.TryParse(Console.ReadLine(), out numero);
        }
        public static bool IngresarDatos(out float numero)
        {
            return float.TryParse(Console.ReadLine(), out numero);
        }
        public static bool IngresarDatos(out char caracter)
        {
            return char.TryParse(Console.ReadLine(), out caracter);
        }
        public static void IngresarDatos(out string cadena)
        {
            cadena=Console.ReadLine();
        }
        public static bool ValidarNumeros(out int numeroEntero, int min, int max)
        {
            bool sePudo=true;
            bool esNumero=Validador.IngresarDatos(out numeroEntero);
            if ((numeroEntero < min || numeroEntero > max) || (esNumero != true)) 
            {
                sePudo = false;
            }
            return sePudo;
        }
        public static bool ValidarNumeros(out float numeroFlotante, float min, float max)
        {
            bool sePudo = true;
            bool esNumero = Validador.IngresarDatos(out numeroFlotante);
            if ((numeroFlotante < min || numeroFlotante > max) || (esNumero != true))
            {
                sePudo = false;
            }
            return sePudo;
        }
        public static bool ValidarSoloLetras(out string cadena)
        {
            bool contieneSoloLetras = true;
            IngresarDatos(out cadena);
            int tamaño = cadena.Length;
            if(tamaño > 0) 
            {
                for (int i = 0; i < tamaño; i++)
                {
                    if ((cadena[i] < 'A' || cadena[i] > 'Z') && (cadena[i] < 'a' || cadena[i] > 'z')) 
                    {
                        contieneSoloLetras = false;
                        break;
                    }
                }
            }
            else 
            {
                contieneSoloLetras = false;
            }
            return contieneSoloLetras;
        }
        public static bool ValidarOpcion(out char opcion)
        {
            bool opcionElejida = false;
            Validador.IngresarDatos(out opcion);
            opcion = char.ToLower(opcion);
            if (opcion == 's')
            {
                opcionElejida = true;
            }

            return opcionElejida;
        }
    }
}
