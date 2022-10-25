using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_06CalculadoraDeAreas
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }
        public static double CalcularAreaTriangulo(double laBase, double altura)
        {
            return (laBase * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return 3.1416 * Math.Pow(radio, 2);
        }
    }
}
