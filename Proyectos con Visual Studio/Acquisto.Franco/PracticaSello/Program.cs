using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSello
{
    class PracticaSello
    {
        static void Main(string[] args)
        {


            Sello.mensaje = "Hola mundo";

            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "Hola mundo C#";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();
        }
    }
}
