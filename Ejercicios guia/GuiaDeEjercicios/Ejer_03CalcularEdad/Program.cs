using System;
using Biblioteca_Persona;

namespace Ejer_03CalcularEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pablo", new DateTime(2001, 3, 8), "20.222.333");
            Persona persona2 = new Persona("Marcos", new DateTime(1996, 5, 6), "10.400.100");
            Persona persona3 = new Persona("Carlos", new DateTime(2004, 10, 1), "30.300.200");


            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());


            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.EsMayorDeEdad());


            Console.ReadKey();
        }
    }
}
