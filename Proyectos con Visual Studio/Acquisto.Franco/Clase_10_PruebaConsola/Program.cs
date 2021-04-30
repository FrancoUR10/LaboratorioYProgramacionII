using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_10_Ejercicio;

namespace Clase_10_PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 10";

            Lavadero unLavadero = new Lavadero(2000,5000,3000);
            Auto unAuto = new Auto("02E7", 4, EMarcas.Ford,4);
            Auto otroAuto = new Auto("02E8", 4, EMarcas.Fiat,4);
            Camion unCamion = new Camion("02E9", 4, EMarcas.Honda,200);

            unLavadero += unAuto;
            unLavadero += otroAuto;
            unLavadero += unCamion;
            Console.WriteLine(unLavadero.GetLavadero);













            Console.ReadKey();
        }
    }
}
