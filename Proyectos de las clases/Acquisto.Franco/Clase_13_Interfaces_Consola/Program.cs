using System;
using Clase_13_Ejercicio_Interfaces;

namespace Clase_13_Interfaces_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado avionPrivado = new Privado(50, 100, 10);
            Comercial avionComercial = new Comercial(70, 80, 25);
            Console.WriteLine(avionPrivado.CalcularImpuesto());
            Console.WriteLine(avionComercial.CalcularImpuesto());
            Console.ReadKey();
        }
    }
}
