using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_03ConversorBinario
{
    class Conversor
    {
        public string ConvertirDecimalABinario(int numeroEntero)
        {
            string conversionBinaria = "";
            while (numeroEntero > 0)
            {
                conversionBinaria = numeroEntero % 2 + conversionBinaria;
                numeroEntero /= 2;

            }
            return conversionBinaria;
        }
        public int ConvertirBinarioADecimal(string numeroBinario)
        {
            int resultado=0;
            StringBuilder binario = new StringBuilder();
            int cantidad=numeroBinario.Length;
            foreach (char caracteres in numeroBinario)
            {
                cantidad--;
                if (caracteres == '1') 
                {
                    resultado +=(int)Math.Pow(2,cantidad);
                }
            }
            return resultado;
        }
    }
}
