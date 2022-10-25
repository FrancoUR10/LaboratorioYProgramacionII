using System;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio N°2";

            int unNumero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un número: ");
            do
            {
                unNumero = int.Parse(Console.ReadLine());
                if (unNumero <= 0) 
                {
                    Console.Write("ERROR. Reingrese el número: ");
                }
            } while (unNumero <= 0);

            cuadrado=Math.Pow(unNumero, 2);
            cubo=Math.Pow(unNumero, 3);

            Console.Write("El cuadrado: {0} El cubo: {1}",cuadrado,cubo);


            Console.ReadLine();
        }
    }
}
