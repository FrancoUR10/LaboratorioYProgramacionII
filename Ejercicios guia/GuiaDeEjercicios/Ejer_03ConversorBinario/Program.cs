using System;

namespace Ejer_03ConversorBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor miConversor = new Conversor();
            int numeroEntero;
            string DecimalABinario;
            int BinarioADecimal;

            numeroEntero = int.Parse(Console.ReadLine());
            DecimalABinario = miConversor.ConvertirDecimalABinario(numeroEntero);

            Console.WriteLine(DecimalABinario);


            BinarioADecimal=miConversor.ConvertirBinarioADecimal(DecimalABinario);

            Console.WriteLine(BinarioADecimal);


            Console.ReadLine();
        }
    }
}
