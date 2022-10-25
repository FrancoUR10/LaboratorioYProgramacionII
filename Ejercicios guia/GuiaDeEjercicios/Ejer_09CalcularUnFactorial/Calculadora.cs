using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_09CalcularUnFactorial
{
    class Calculadora
    {
        public static string calcularFactorial(int unNumero)
        {
            StringBuilder resultado = new StringBuilder();
            resultado.Append("El número ingresado es invalido");
            if (unNumero == 0)
            {
                unNumero = 1;
            }
            else if (unNumero > 0)
            {
                for (int i = unNumero - 1; i > 0; i--)
                {
                    unNumero *= i;
                }
            }
            if (unNumero >= 0) 
            {
                resultado.Clear();
                resultado.Append("El factorial es " + unNumero);
            }

            return resultado.ToString();
        }
    }
}
