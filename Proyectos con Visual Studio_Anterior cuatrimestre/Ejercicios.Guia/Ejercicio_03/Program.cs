using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°3";

            int numero = 2;
            int divisible = 0;
            int numeroIngresado;
            int i;

            Console.Write("Ingrese un numero: ");
            numeroIngresado=int.Parse(Console.ReadLine());

            while (numero <=numeroIngresado) 
            {
                for (i = 1; i <= numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        divisible++;
                    }
                }
                if(divisible == 2) 
                {
                    Console.WriteLine("Es primo: {0}", numero);
                }
                numero++;
                divisible=0;
            }

            Console.ReadKey();
        }
    }
}
