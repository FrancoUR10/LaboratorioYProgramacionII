using System;
using PruebaClaseMostrar;

namespace PruebaClaseMostrar_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Estudiante e1 = new Estudiante("Juan", 10);


            Console.WriteLine(((Persona)e1).Mostrar());

            Console.ReadKey();
        }
    }
}
