using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 4";
            Cosa objeto = new Cosa();
            Cosa objeto1 = new Cosa("Hola");
            Cosa objeto2 = new Cosa(5,"Hola");
            Cosa objeto3 = new Cosa(new DateTime(1998,3,2),5,"Hola");
            /*
            objeto.EstablecerValor(50);
            objeto.EstablecerValor("Hola");
            objeto.EstablecerValor(DateTime.Now);
            */

            Console.WriteLine(Cosa.Mostrar(objeto));
            Console.WriteLine(Cosa.Mostrar(objeto1));
            Console.WriteLine(Cosa.Mostrar(objeto2));
            Console.WriteLine(Cosa.Mostrar(objeto3));

            Console.ReadKey();
        }
    }
}
