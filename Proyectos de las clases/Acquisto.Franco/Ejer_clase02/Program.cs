using System;

namespace Ejer_clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int unNumero;
            bool numeroValido;
            bool primerNumeroAceptado=false;
            float promedio=0;
            int maximo=0;
            int minimo=0;

            for(int i = 0; i < 10; i++) 
            {
                Console.Write("Ingrese un número: ");
                unNumero = int.Parse(Console.ReadLine());

                numeroValido = Validador.Validar(unNumero, -100, 100);

                if (numeroValido == true) 
                {
                    promedio += unNumero;

                    if (primerNumeroAceptado == false) 
                    {
                        maximo = unNumero;
                        minimo = unNumero;
                        primerNumeroAceptado = true;
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
 
            }

            promedio /= 10;

            Console.WriteLine("El maximo es: {0} el minimo es: {1} el promedio es: {2}", maximo, minimo, promedio);

            Console.ReadLine();
        }
    }
}
