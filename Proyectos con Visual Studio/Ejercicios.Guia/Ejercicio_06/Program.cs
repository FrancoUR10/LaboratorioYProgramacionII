using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°6";

            int primerAño;
            int ultimoAño;
            int i;

            Console.Write("Ingrese el primer año a buscar: ");
            primerAño=int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el ultimo año a buscar: ");
            ultimoAño = int.Parse(Console.ReadLine());



            for(i = primerAño; i<= ultimoAño; i++) 
            {
                if((i % 4 == 0) && (i % 100 != 0 || i % 400 == 0)) 
                {
                    Console.WriteLine("Año bisiesto: {0}",i);
                }
            }

            Console.ReadKey();
        }
    }
}
