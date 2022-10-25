using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio_Excepciones
{
    public class Numero
    {
        public static bool NumeroEntero(string cadenaAConvertir,out int resultado) 
        {
            bool esValido = true;
            try 
            {
                resultado = int.Parse(cadenaAConvertir);
            }
            catch
            {
                resultado = 0;
                esValido = false;
            }
            return esValido;

        }
    }
}
