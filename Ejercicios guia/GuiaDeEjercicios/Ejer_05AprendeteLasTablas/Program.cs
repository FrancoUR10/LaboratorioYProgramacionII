using System;

namespace Ejer_05AprendeteLasTablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;
            Console.Write("Ingrese un número: ");
            numeroEntero=int.Parse(Console.ReadLine());
            Console.WriteLine("\n"+Tablas.Multiplicar(numeroEntero));


            Console.ReadKey();
        }
    }
}
