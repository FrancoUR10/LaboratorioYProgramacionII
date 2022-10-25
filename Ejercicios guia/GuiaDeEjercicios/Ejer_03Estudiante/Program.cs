using System;
using Biblioteca_Estudiante;

namespace Ejer_03Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Juan", "Perez", "2000");
            Estudiante estudiante2 = new Estudiante("Carlos","Juarez", "3000");
            Estudiante estudiante3 = new Estudiante("Pepito", "Lalala", "4000");

            estudiante1.SetNotaPrimerParcial(6);
            estudiante2.SetNotaPrimerParcial(5);
            estudiante3.SetNotaPrimerParcial(2);
            estudiante1.SetNotaSegundoParcial(8);
            estudiante2.SetNotaSegundoParcial(6);
            estudiante3.SetNotaSegundoParcial(5);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());

            Console.ReadKey();
        }
    }
}