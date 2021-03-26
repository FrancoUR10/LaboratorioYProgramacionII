using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio N°14";
            int opcion;
            int laBase;
            int altura;
            double resultadoDelArea;
            Console.WriteLine("1- AREA CUADRADO");
            Console.WriteLine("2- AREA TRIANGULO");
            Console.WriteLine("3- AREA CIRCULO");
            Console.Write("Ingrese una opcion: ");
            opcion=int.Parse(Console.ReadLine());
            switch (opcion) 
            {
                case 1:
                    Console.Write("\nIngrese el tamaño de los lados: ");
                    resultadoDelArea=CalculoDeArea.CalcularCuadrado(int.Parse(Console.ReadLine()));
                    Console.WriteLine("\nEl area del cuadrado es {0}",resultadoDelArea);
                    break;
                case 2:
                    Console.Write("\nIngrese el tamaño de la base: ");
                    laBase=int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese el tamaño de la altura: ");
                    altura =int.Parse(Console.ReadLine());

                    resultadoDelArea = CalculoDeArea.CalcularTriangulo(laBase,altura);
                    Console.WriteLine("\nEl area del triangulo es {0}", resultadoDelArea);
                    break;
                case 3:
                    Console.Write("\nIngrese el tamaño del radio: ");
                    resultadoDelArea = CalculoDeArea.CalcularCirculo(int.Parse(Console.ReadLine()));
                    Console.WriteLine("\nEl area del circulo es {0}", resultadoDelArea);
                    break;
                default:
                    Console.WriteLine("\nOpcion incorrecta");
                    break;
            }
















            Console.ReadKey();
        }
    }
}
