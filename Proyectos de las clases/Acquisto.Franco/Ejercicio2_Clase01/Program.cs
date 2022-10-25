using System;

namespace Ejercicio2_Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un número: ");
            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.Write("ERROR. Reingresar número: ");
                }
            }
            while (numero <= 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado es: {0} el cubo es: {1}", cuadrado, cubo);



            Console.ReadLine();
        }
    }
}
