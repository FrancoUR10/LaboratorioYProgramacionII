using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Validaciones";
            /*
            float numero;
            Console.WriteLine(Validador.ValidarNumeros(out numero, -1, 10));
            //Console.WriteLine(Validador.IngresarDatos(out numero));
            Console.WriteLine(numero);
            string texto;
            Console.WriteLine(Validador.ValidarSoloLetras(out texto));
            */
            char letra;
            Console.WriteLine(Validador.ValidarOpcion(out letra));



            Console.ReadKey();
        }
    }
}
