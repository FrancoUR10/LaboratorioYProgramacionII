using System;
using Metodos_De_Extension;

namespace Metodos_De_Extencion_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime fecha = DateTime.Now;

            Console.WriteLine(fecha.ObtenerPlacaCronicaTV(EEstaciones.Otonio));
            Console.WriteLine(fecha.ObtenerPlacaCronicaTV(EEstaciones.Invierno));
            Console.WriteLine(fecha.ObtenerPlacaCronicaTV(EEstaciones.Primavera));
            Console.WriteLine(fecha.ObtenerPlacaCronicaTV(EEstaciones.Verano));
            */
            Int64 numero;
            Console.Write("Ingrese un número: ");
            numero = Int64.Parse(Console.ReadLine());
            Console.WriteLine(numero.ContarCantidadDeDigitos());

            Console.WriteLine("Ho.la,sss;;s".ContarCantidadDeSignos());

            int numeroDivisible = 15;
            Console.WriteLine(numeroDivisible.FizzBuzz());


            Console.ReadKey();
        }
    }
}
