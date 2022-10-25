using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_05AprendeteLasTablas
{
    class Tablas
    {
        public static string Multiplicar(int numeroEntero)
        {
            StringBuilder resultado = new StringBuilder();
            int contador = 0;
            int operacion;

            for (int i=0; i < 10; i++)
            {
                contador++;
                operacion = numeroEntero * contador;
                resultado.AppendLine(numeroEntero.ToString()+" X "+contador.ToString()+" = "+operacion.ToString()+"\n");
            }


            return resultado.ToString();
        }
    }
}
