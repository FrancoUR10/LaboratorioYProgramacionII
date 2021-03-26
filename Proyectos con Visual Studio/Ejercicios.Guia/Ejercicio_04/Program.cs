using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°4";

            int numero=6;
            int contador = 0;
            int i;
            int suma=0;
            while(contador < 4) 
            {
                for (i = 1; i < numero; i++) 
                {
                    if(numero % i == 0)
                    {
                        suma += i;
                    }
                }
                if (numero == suma)
                {
                    Console.WriteLine("Numero perfecto: {0}", numero);
                    contador++;
                }
                numero++;
                suma = 0;
      
            }
            Console.ReadKey();
        }
    }
}
