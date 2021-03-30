using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecargas";

            Sobrecargas objetoUno = new Sobrecargas(56);
            Sobrecargas objetoDos = new Sobrecargas(85,"Juan");
            Sobrecargas objetoTres = new Sobrecargas(50,"Pedro");

            Console.WriteLine(objetoDos.nombre);

            objetoDos=objetoDos + 6;
            objetoTres = 8 + objetoTres;
            Console.WriteLine(objetoDos.id);
            Console.WriteLine(objetoTres.id);

            bool sonIguales=objetoUno == objetoDos;
            Console.WriteLine(sonIguales);

            int unId = objetoTres;
            Console.WriteLine(unId);
            Console.ReadKey();
        }
    }
}
