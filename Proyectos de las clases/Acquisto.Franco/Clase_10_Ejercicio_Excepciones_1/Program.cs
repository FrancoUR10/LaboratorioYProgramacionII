using System;

namespace Clase_10_Ejercicio_Excepciones_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MisMetodos.Metodo1();
            }
            catch (MiPropiaExcepcion e) 
            {
                Console.WriteLine("Mensaje de mi excepcion: {0}",e.Mensaje);
            }

            Console.ReadKey();
        }
    }
}
