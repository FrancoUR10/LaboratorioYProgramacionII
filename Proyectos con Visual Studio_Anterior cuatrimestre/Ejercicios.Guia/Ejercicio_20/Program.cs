using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°20";

            Euro euro = new Euro(1.08);
            Dolar dolar = new Dolar(1);
            Pesos peso = new Pesos(66);

            /*
            Pesos nuevoPeso = new Pesos(0);
            nuevoPeso = (Pesos)dolar;

            Console.WriteLine("{0:C}", nuevoPeso.GetCantidad());

            Euro nuevoEuro = new Euro(0);
            nuevoEuro=(Euro)dolar;

            Console.WriteLine("{0:C}", nuevoEuro.GetCantidad());
            Euro nuevoEuro = new Euro(0);
            nuevoEuro = (Euro)peso;

            Console.WriteLine("{0:C}", nuevoEuro.GetCantidad());
            Dolar nuevoDolar = new Dolar(0);
            nuevoDolar = (Dolar)euro;
            Pesos nuevoPeso = new Pesos(0);
            nuevoPeso = (Pesos)euro;
            Console.WriteLine("{0:C}", nuevoPeso.GetCantidad());

            if(dolar == peso) 
            {
                Console.WriteLine("Son iguales");
            }
            else 
            {
                Console.WriteLine("Son distintos");
            }
            */
            dolar = dolar + peso;
            Console.WriteLine("{0:C}", dolar.GetCantidad());










            Console.ReadKey();
        }
    }
}
