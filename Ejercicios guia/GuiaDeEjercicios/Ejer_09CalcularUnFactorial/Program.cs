using System;

namespace Ejer_09CalcularUnFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");

            int numeroIngresado= int.Parse(Console.ReadLine());

            Console.WriteLine(Calculadora.calcularFactorial(numeroIngresado));


            Console.ReadKey();
        }
    }
}
