using System;
using Ejer_Lavadero;
using System.Collections.Generic;
using System.Collections;

namespace Lavadero_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lavadero = new Lavadero(50, 90, 20);

            Auto a1 = new Auto("fdghi", 4, EMarcas.Ford, 5);
            Auto a2 = new Auto("abcd", 4, EMarcas.Fiat, 4);
            Auto a3 = new Auto("aaaa", 4, EMarcas.Iveco, 4);

            Camion c1 = new Camion("1234", 4, EMarcas.Scania, 60);
            Camion c2 = new Camion("6589", 4, EMarcas.Ford, 80);
            Camion c3 = new Camion("5555", 4, EMarcas.Honda, 100);

            Moto m1 = new Moto("rtyu", 4, EMarcas.Zanella, 20);
            Moto m2 = new Moto("fhhn", 4, EMarcas.Fiat, 10);
            Moto m3 = new Moto("5687", 4, EMarcas.Zanella, 30);

            lavadero += a1;
            lavadero += a2;
            lavadero += a3;
            lavadero += c1;
            lavadero += c2;
            lavadero += c3;
            lavadero += m1;
            lavadero += m2;
            lavadero += m3;

            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine("Ordenado por patente");
            Console.WriteLine(lavadero.Detalle);

            lavadero.Vehiculos.Sort(lavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine("Ordenado por marca");
            Console.WriteLine(lavadero.Detalle);


            Console.ReadKey();
        }
    }
}
