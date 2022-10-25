using System;
using BibliotecaUtiles;

namespace Ejer_04Boligrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoEscrito;
            Boligrafo boligrafoAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            boligrafoRojo.Pintar(100, out textoEscrito);
            Console.WriteLine(textoEscrito);
            Console.WriteLine("Cantidad tinta roja: {0}\n", boligrafoRojo.GetTinta());

            boligrafoRojo.Recargar();

            boligrafoRojo.Pintar(100, out textoEscrito);
            Console.WriteLine(textoEscrito);
            Console.WriteLine("Cantidad tinta roja: {0}\n", boligrafoRojo.GetTinta());


            boligrafoAzul.Pintar(100,out textoEscrito);
            Console.WriteLine(textoEscrito);
            Console.WriteLine("Cantidad tinta azul: {0}\n",boligrafoAzul.GetTinta());



            Console.ReadKey();
        }
    }
}
