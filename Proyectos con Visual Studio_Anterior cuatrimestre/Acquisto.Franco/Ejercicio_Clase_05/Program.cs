using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase N°5 Ejercicio";
            Entidades.Tinta objTinta = new Entidades.Tinta(ConsoleColor.Yellow,ETipoTinta.ConBrillito);
            Entidades.Pluma objPluma = new Entidades.Pluma("HolaPluma", objTinta, 3);

            Entidades.Pluma nuevaPluma;

            nuevaPluma = objPluma + objTinta;
            objPluma += objTinta;

            Console.WriteLine(nuevaPluma);
            Console.WriteLine(objPluma);













            Console.ReadKey();
        }
    }
}
