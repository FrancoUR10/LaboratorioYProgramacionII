﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_clase02
{
    class Validador
    {
        public static bool Validar(int valor, int min, int max) 
        {
            bool esValido = false;
            if(valor >= min && valor <= max) 
            {
                esValido = true;
            }

            return esValido;
        }
    }
}
