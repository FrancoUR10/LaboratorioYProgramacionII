using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio N°19";
            Sumador objeto1 = new Sumador();
            Sumador objeto2 = new Sumador();
            objeto1.Sumadores(5);
            objeto2.Sumadores(6);
            Console.WriteLine(objeto1 | objeto2);
            Console.WriteLine(objeto1.Sumar(5,6));
            Console.WriteLine(objeto1.Sumar("Hola ","mundo"));


            Console.WriteLine((int)objeto1);

            long unaSuma = objeto1 + 6;
            Console.WriteLine(unaSuma);




            Console.ReadKey();
        }
    }
}
