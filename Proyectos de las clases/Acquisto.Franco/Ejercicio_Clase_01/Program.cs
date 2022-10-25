using System;

namespace Ejercicio_Clase_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool primerNumeroIngresado=false;
            int numero;
            int acumulador=0;
            int maximo=0;
            int minimo=0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;

                if (primerNumeroIngresado == false)
                {
                    maximo = numero;
                    minimo = numero;
                    primerNumeroIngresado = true;
                }
                if (maximo < numero) 
                {
                    maximo = numero;
                }
                if (minimo > numero)
                {
                    minimo = numero;
                }
            }

            promedio = (float)acumulador / 5;
            Console.WriteLine("El maximo es: {0} el minimo es: {1} el promedio es: {2}", maximo, minimo,promedio);


            Console.ReadLine();
        }
    }
}
