using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";

            string numeroIngresado;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();
            while (int.Parse(numeroIngresado) <= 0) 
            {
                Console.Write("\nError, reingrese el número: ");
                numeroIngresado = Console.ReadLine();

            }
            Console.WriteLine(Math.Pow(int.Parse(numeroIngresado), 2));
            Console.WriteLine(Math.Pow(int.Parse(numeroIngresado), 3));


            Console.ReadKey();
        }
    }
}
