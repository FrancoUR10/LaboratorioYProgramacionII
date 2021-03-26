using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro. 1";

            Console.WriteLine("Hola mundo!");

            Console.Write("C#");

            Console.Clear();

            Console.WriteLine("Ingrese un nombre:");
            string nombre = Console.ReadLine();

            //Console.WriteLine(nombre);

            Console.WriteLine("Su nombre es {0} y su sueldo es {1}", nombre, 56200);

            Console.ReadKey();
        }
    }
}
