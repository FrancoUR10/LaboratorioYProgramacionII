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
            int numero;
            Validador.ValidarNumeroRango("Ingrese un numero: ",out numero, -2, 10,"Error! Reingrese el numero: ");
            Console.WriteLine(numero);
            char texto = 'B';
            if (texto > 'A')
            {
                Console.WriteLine(texto);
            }
            */
            char opcion;
            Console.WriteLine(Validador.ValidarOpcion("Elija S o N: ", out opcion, "Error! Vuelva a elejir S o N: "));










            Console.ReadKey();
        }
    }
}
