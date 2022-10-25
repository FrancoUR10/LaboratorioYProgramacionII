using System;
using Ejercicio_Tinta_Pluma;

namespace Ejercicio_Tinta_Pluma_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta(ConsoleColor.Green,ETipoTinta.ConBrillito);
            Pluma pluma1 = new Pluma("Hola",tinta1,5);

            Console.WriteLine(Tinta.Mostrar(tinta1));
            //Console.WriteLine((string)tinta1);
            pluma1+=tinta1;
            Console.WriteLine(pluma1);


            Console.ReadKey();
        }
    }
}
