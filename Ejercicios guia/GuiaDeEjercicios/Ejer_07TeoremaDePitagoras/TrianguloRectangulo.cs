using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_07TeoremaDePitagoras
{
    class TrianguloRectangulo
    {
        public static double Calcularhipotenusa(double ladoA, double ladoB) 
        {
            double ladoAcuadrado;
            double ladoBcuadrado;

            ladoAcuadrado=Math.Pow(ladoA, 2);
            ladoBcuadrado=Math.Pow(ladoB, 2);

            return Math.Sqrt(ladoAcuadrado + ladoBcuadrado);
        }
    }
}
