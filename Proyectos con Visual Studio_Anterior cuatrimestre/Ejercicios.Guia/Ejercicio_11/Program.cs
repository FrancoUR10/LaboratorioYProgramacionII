using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°11";

            bool esValido;
            int numeroIngresado;
            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Ingrese el numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                esValido = Validacion.Validar(numeroIngresado,-100,100);
                while (esValido == false) 
                {
                    Console.Write("Error! Reingrese el numero: ");
                    numeroIngresado = int.Parse(Console.ReadLine());
                    esValido = Validacion.Validar(numeroIngresado, -100, 100);
                }
                Validacion.acumulador += numeroIngresado;
                Validacion.contador++;
                if (numeroIngresado > Validacion.maximo || Validacion.primerNumeroIngresado == false)
                {
                    Validacion.maximo = numeroIngresado;
                }
                if(numeroIngresado < Validacion.minimo || Validacion.primerNumeroIngresado == false)
                {
                    Validacion.minimo = numeroIngresado;
                }
                Validacion.primerNumeroIngresado = true;
            }
            Validacion.promedio = (float)Validacion.acumulador / Validacion.contador;
            Console.WriteLine("Numero maximo: {0} Numero Minimo: {1} Promedio: {2}", Validacion.maximo, Validacion.minimo, Validacion.promedio);















            Console.ReadKey();
        }
    }
}
