using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(int entero) 
        {
            string binario="";
            if (entero == 0) 
            {
                binario = "0";
            }
            else 
            {
                while(entero != 0) 
                {
                    binario = entero % 2 + binario;
                    entero = entero / 2;
                }
            }
            return binario;
        }
        public static int BinarioDecimal(string binario)
        {
            int residuo = 0;
            int exponente = 0;
            int resultado = 0;
            int numeroBinario = int.Parse(binario);
            do
            {
                residuo = numeroBinario % 10;
                numeroBinario = numeroBinario / 10;
                resultado += (int)(residuo * Math.Pow(2, exponente));
                exponente++;

            } while (numeroBinario != 0);
            return resultado;
        }
    }
}
