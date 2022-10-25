using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07_Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 7 Ejemplo";

            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i + 1;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("/////////");

            foreach (int auxNumeros in numeros)
            {
                Console.WriteLine(auxNumeros);
            }

            Console.WriteLine("Array con strings: ");

            string[] textos = new string[5];
            int contador = 0;
            foreach (string auxTextos in textos)
            {
                if (contador % 2 == 0) 
                {
                    textos[contador] = "Hola Mundo";
                }
                    contador++;
            }
            foreach(string auxTextos in textos) 
            {
                Console.WriteLine(auxTextos);
            }






            Console.ReadKey();
        }
    }
}
