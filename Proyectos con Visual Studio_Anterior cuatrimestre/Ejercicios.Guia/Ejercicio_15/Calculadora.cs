using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static float Calcular(int numeroUno, int numeroDos,char operador) 
        {
            float resultado=0;
            switch (operador) 
            {
                case '+':
                    resultado=Calculadora.Sumar(numeroUno, numeroDos);
                    break;
                case '-':
                    resultado=Calculadora.Restar(numeroUno, numeroDos);
                    break;
                case '*':
                    resultado=Calculadora.Multiplicar(numeroUno, numeroDos);
                    break;
                case '/':
                    if (Calculadora.Validar(numeroDos)) 
                    {
                        resultado=Calculadora.Dividir(numeroUno, numeroDos);
                    }
                    break;
                default :
                    break;
            }
            return resultado;
        }
        private static bool Validar(int segundoNumero)
        {
            bool noEsCero = false;
            if (segundoNumero != 0) 
            {
                noEsCero = true;
            }
            return noEsCero;
        }
        private static int Sumar(int numeroUno, int numeroDos) 
        {
            int resultado = numeroUno + numeroDos;
            return resultado;
        }
        private static int Restar(int numeroUno, int numeroDos)
        {
            int resultado = numeroUno - numeroDos;
            return resultado;
        }
        private static int Multiplicar(int numeroUno, int numeroDos)
        {
            int resultado = numeroUno * numeroDos;
            return resultado;
        }
        private static float Dividir(int numeroUno, int numeroDos)
        {
            float resultado = (float)numeroUno / numeroDos;
            return resultado;
        }
    }
}
