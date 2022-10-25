using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°12";
            bool opcion;
            int numero;
            int acumulador = 0;
            do
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                Console.Write("Desea ingresar otro numero? (S/N): ");
                opcion = Validacion.ValidaS_N(char.Parse(Console.ReadLine()));
            } while (opcion == true);
            Console.WriteLine("La suma total es de {0}",acumulador);




















            Console.ReadKey();
        }
    }
}
