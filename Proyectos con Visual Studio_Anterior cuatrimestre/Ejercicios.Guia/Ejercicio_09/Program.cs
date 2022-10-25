using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°9";
            int alto;
            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out alto)) 
            {
                Console.WriteLine();
                Console.WriteLine();
                for(int i = 1; i <= alto * 2; i += 2) 
                {
                    for(int j = 1; j <= i; j++) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
