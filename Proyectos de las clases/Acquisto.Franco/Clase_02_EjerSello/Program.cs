using System;

namespace Clase_02_EjerSello
{
    class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "hola mundo";


            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());


            Sello.mensaje = "hola mundo C#";

            Sello.color = ConsoleColor.DarkGreen;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());





            Console.ReadLine();
        }
    }
}
