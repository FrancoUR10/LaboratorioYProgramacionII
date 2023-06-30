using System;

namespace Clase_10_Ejercicio_Excepciones_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MisMetodos.MetodoDeClase();
            }
            catch (MiPropiaExcepcion e)
            {
                try 
                {
                    throw new MiPropiaExcepcion("Excepción en el main", e);
                }
                catch(MiPropiaExcepcion excepcionAMostrar) 
                {
                    Console.WriteLine("Mensaje de mi excepción: {0}", excepcionAMostrar.Mensaje);
                    Console.WriteLine("Mensaje original de exception: {0}", excepcionAMostrar.Message);
                    Console.WriteLine("Stack: {0}", excepcionAMostrar.StackTrace);
                }
            }

            Console.ReadKey();
        }
    }
}
