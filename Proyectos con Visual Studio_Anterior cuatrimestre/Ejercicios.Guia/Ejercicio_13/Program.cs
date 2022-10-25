using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°13";

            Console.Write("Ingrese un numero entero: ");
            string binario = Conversor.DecimalBinario(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nNumero en binario: {0}",binario);

            Console.Write("Ingrese un numero binario: ");
            int entero = Conversor.BinarioDecimal(Console.ReadLine());
            Console.WriteLine("\nNumero en decimal: {0}", entero);
















            Console.ReadKey();
        }
    }
}
