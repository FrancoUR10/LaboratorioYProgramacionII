using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_07_Ejercicio;

namespace Clase_08_TestClase7
{
    class Clase_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase N°8";

            Tempera tempera = new Tempera(ConsoleColor.Red,"Hola",10);
            Paleta paleta = 2;

            paleta += tempera;
            Console.WriteLine((string)paleta);


            Console.ReadKey();
        }
    }
}
