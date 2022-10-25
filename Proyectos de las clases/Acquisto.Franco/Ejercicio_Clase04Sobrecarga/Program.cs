using System;

namespace Ejercicio_Clase04Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa miObjeto = new Cosa();
            
            /*
            miObjeto.EstablecerValor(5);
            miObjeto.EstablecerValor("Hola");
            miObjeto.EstablecerValor(DateTime.Now);
            */

            Console.Write(Cosa.Mostrar(miObjeto));



            Console.ReadKey();
        }
    }
}
