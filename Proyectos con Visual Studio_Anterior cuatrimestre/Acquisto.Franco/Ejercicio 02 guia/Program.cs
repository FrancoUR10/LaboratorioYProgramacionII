using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02_guia
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("Ingrese un numero:");
            numero = Console.ReadLine();
            while (int.Parse(numero) <= 0) 
            {
                Console.WriteLine("Numero incorrecto, ingrese de nuevo:");
                numero = Console.ReadLine();
            }

            //Utilizar metodo de la clase Math

            Math.Pow(int.Parse(numero), 2);
            Math.Pow(int.Parse(numero), 3);
            Console.WriteLine(Math.Pow(int.Parse(numero), 2));
            Console.WriteLine(Math.Pow(int.Parse(numero), 3));

            Console.ReadKey();
        }
    }
}
