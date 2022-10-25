using System;

namespace Ejer_06CalculadoraDeAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            areaCuadrado=CalculadoraDeArea.CalcularAreaCuadrado(3);
            areaTriangulo=CalculadoraDeArea.CalcularAreaTriangulo(6,7);
            areaCirculo=CalculadoraDeArea.CalcularAreaCirculo(9);

            Console.WriteLine("Area del cuadrado: {0} Area del triangulo: {1} Area del círculo: {2:#.##}", areaCuadrado,areaTriangulo,areaCirculo);



            Console.ReadLine();
        }
    }
}
