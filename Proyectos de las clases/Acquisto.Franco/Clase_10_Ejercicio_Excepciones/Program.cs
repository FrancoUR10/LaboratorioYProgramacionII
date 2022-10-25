using System;

namespace Clase_10_Ejercicio_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado = Console.ReadLine();
            int resultado;
            if (Numero.NumeroEntero(numeroIngresado, out resultado)) 
            {
                Console.WriteLine("Numero: {0}", resultado);
            }
            else 
            {
                Console.WriteLine("El número no es válido");
            }
            Console.ReadKey();
        }
    }
}
