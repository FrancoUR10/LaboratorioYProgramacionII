using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°10";
            int cantidad;
            int i;
            int j;
            int z;
            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out cantidad)) 
            {
                Console.WriteLine();
                Console.WriteLine();
                for (i = 1; i <= cantidad; i++)
                {
                    for (j = 0; j < cantidad - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (z = 0; z < (i * 2) - 1; z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();






            Console.ReadKey();
        }
    }
}
