using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lados) 
        {
            double resultado = Math.Pow(lados, 2);
            return resultado;
        }
        public static double CalcularTriangulo(double laBase, double altura) 
        {
            double resultado = (laBase * altura) / 2;
            return resultado;
        }
        public static double CalcularCirculo(double radio) 
        {
            double resultado=3.14 * Math.Pow(radio, 2);
            return resultado;
        }
    }
}
