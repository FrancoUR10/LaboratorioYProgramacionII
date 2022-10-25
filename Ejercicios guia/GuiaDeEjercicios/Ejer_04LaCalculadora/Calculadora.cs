using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_04LaCalculadora
{
    class Calculadora
    {
        public static float Calcular(int primerOperando,int segundoOperando,char operador)
        {
            float resultado = 0;
            switch (operador) 
            {
                case '+' :
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Calculadora.Validar(segundoOperando) == true) 
                    {
                        resultado =(float) primerOperando / segundoOperando;
                    }
                    break;
                default :
                    break;
            }
            return resultado;
        }

        private static bool Validar(int segundoOperando)
        {
            bool esValido = false;
            if (segundoOperando != 0) 
            {
                esValido = true;
            }
            return esValido;
        }
    }
}
