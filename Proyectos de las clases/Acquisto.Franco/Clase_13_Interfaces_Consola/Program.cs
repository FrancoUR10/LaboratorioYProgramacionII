using System;
using Clase_13_Ejercicio_Interfaces;

namespace Clase_13_Interfaces_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion a1 = new Avion(10, 20);
            Privado avionPrivado = new Privado(50, 100, 10);
            Comercial avionComercial = new Comercial(10, 20, 25);
            Console.WriteLine("Avion privado IAFIP: {0}",avionPrivado.Impuesto);
            Console.WriteLine("Avion Impuesto IAFIP: {0}",a1.Impuesto);
            Console.WriteLine("Avion Comercial IARBA implicito: {0}",avionComercial.CalcularImpuesto());
            Console.WriteLine("Avion Comercial IARBA explicito: {0}", ((IARBA)avionComercial).CalcularImpuesto());
            Console.WriteLine("Avion comercial IAFIP: {0}",((IAFIP)avionComercial).CalcularImpuesto());
            Console.ReadKey();
        }
    }
}
