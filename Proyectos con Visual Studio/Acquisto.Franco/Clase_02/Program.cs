using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num;
            bool rta = int.TryParse("5", out num);
            if (rta == true) 
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error{0}",num);
            }
            */
            Sello.mensaje = "Hola mundo";
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());


            Sello.mensaje = "Hola mundo C#";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());



            Console.ReadLine();

        }
    }
}
