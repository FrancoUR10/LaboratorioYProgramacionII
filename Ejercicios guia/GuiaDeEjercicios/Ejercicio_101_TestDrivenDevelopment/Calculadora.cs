using System;

namespace Ejercicio_101_TestDrivenDevelopment
{
    public class Calculadora
    {
        public static int Add(string numeros)
        {
            string primerOperando = "0";
            string segundoOperando = "0";
            int sumaTotal = 0;
            bool comaIngresada = false;
            if(numeros.Length > 0) 
            {
                foreach (char caracter in numeros)
                {
                    if(caracter == ',') 
                    {
                        comaIngresada = true;
                    }
                    if(caracter >= '0' && caracter <= '9') 
                    {
                        if (comaIngresada == false) 
                        {
                            primerOperando += caracter.ToString();
                        }
                        else 
                        {
                            segundoOperando += caracter.ToString();
                        }
                    }
                }
            }
            sumaTotal = int.Parse(primerOperando) + int.Parse(segundoOperando);
            return sumaTotal;
        }
    }
}
