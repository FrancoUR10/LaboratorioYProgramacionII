using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 1";


            int edad = 8;
            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("La edad es de: {0}",edad);

            Console.ReadLine();
        }
    }
}
