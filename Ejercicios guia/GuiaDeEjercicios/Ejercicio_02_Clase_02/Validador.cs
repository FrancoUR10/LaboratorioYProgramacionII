using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02DeseaContinuar
{
    class Validador
    {
        public static bool ValidarRespuesta(string respuestaIngresada) 
        {
            bool continuar = false;
            respuestaIngresada=respuestaIngresada.ToUpper();
            if (respuestaIngresada == "S") 
            {
                continuar = true;
            }
            return continuar;
        }
    }
}
