using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool primerNumeroIngresado = false;
        public static int minimo;
        public static int maximo;
        public static int acumulador;
        public static int contador;
        public static float promedio;
        public static bool Validar(int valor, int min, int max)
        {
            bool esValido=true;
            if (valor < min || valor > max)
            {
                esValido = false;
            }
            return esValido;
        }
    }
}
