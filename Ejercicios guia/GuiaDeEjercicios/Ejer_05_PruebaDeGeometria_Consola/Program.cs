using System;
using Geometria;

namespace Ejer_05_PruebaDeGeometria_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(5,9);
            Punto vertice3 = new Punto(3,7);

            Rectangulo miRectangulo = new Rectangulo(vertice1,vertice3);

            Console.WriteLine("");





            Console.ReadKey();
        }
    }
}
