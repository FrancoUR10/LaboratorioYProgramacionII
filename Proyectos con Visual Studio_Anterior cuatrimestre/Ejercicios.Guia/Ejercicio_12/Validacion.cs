using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Validacion
    {
        public static bool ValidaS_N(char c)
        {
            bool sePudo = false;
            if (char.ToLower(c) == 's') 
            {
                sePudo = true;
            }
            return sePudo;
        }
    }
}
