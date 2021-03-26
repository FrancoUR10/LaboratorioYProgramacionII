using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°5";

            int numero;
            int i;
            int j;
            int acumulador;
            int contador;
            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(),out numero)) 
            {
                for (i = 1; i <= numero; i++)
                {
                    acumulador = 0;
                    for (j = 1; j < i; j++) 
                    {
                        acumulador += j;
                    }
                    contador = i + 1;
                    do
                    {
                        acumulador -= contador;
                        contador++;
                    } while (acumulador > 0);

                    if (acumulador == 0) 
                    {
                        Console.WriteLine("Centro numerico {0}", i);
                    }
                    /*
                    else 
                    {
                        Console.WriteLine("No es centro numerico {0}", i);
                    }
                    */
                }
            }
            else 
            {
                Console.WriteLine("Error! No es un numero");
            }




            Console.ReadKey();
        }
    }
}
