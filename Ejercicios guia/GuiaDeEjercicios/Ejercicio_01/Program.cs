using System;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°1";

            int unNumero;
            bool primerNumeroIngresado = false;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                unNumero = int.Parse(Console.ReadLine());
                promedio += unNumero;

                if (primerNumeroIngresado == false)
                {
                    maximo = unNumero;
                    minimo = unNumero;
                    primerNumeroIngresado = true;
                }
                if (maximo < unNumero) 
                {
                    maximo = unNumero;
                }
                if (minimo > unNumero)
                {
                    minimo = unNumero;
                }
            }
            promedio /=5;

            Console.WriteLine("Número maximo: {0} Número minimo: {1} Promedio: {2}",maximo,minimo,promedio);

            Console.ReadLine();
        }
    }
}
