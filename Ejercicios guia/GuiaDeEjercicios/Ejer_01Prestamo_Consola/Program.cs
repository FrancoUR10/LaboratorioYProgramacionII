using System;
using Ejer_01Prestamo;

namespace Ejer_01Prestamo_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Perez",500);

            Console.WriteLine(Cuenta.Mostrar(cuenta1));

            cuenta1.Ingresar(600);

            Console.WriteLine(Cuenta.Mostrar(cuenta1));

            cuenta1.Retirar(1200);

            Console.WriteLine(Cuenta.Mostrar(cuenta1));

            cuenta1.Ingresar(400);

            Console.WriteLine(Cuenta.Mostrar(cuenta1));


            Console.ReadKey();
        }
    }
}
