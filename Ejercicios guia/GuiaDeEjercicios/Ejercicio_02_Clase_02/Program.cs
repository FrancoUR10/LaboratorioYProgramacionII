using System;

namespace Ejer02DeseaContinuar
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuar=true;
            int numeroIngresado;
            int suma=0;

            do
            {
                Console.Write("Ingrese un número: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                suma += numeroIngresado;
                Console.Write("Desea continuar? (S/N): ");
                continuar =Validador.ValidarRespuesta(Console.ReadLine());

            } while
            (continuar == true);

            Console.WriteLine("La suma total es de: {0}",suma);

            Console.ReadLine();
        }
    }
}
