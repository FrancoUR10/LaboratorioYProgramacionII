using System;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°4";

            int numeroComparado = 1;
            int suma = 0;
            int division = 0;
            int contador = 0;
            while (contador < 4)
            {
                for (int i = 1; i < numeroComparado; i++)
                {
                    if (numeroComparado % i == 0)
                    {
                        division = i;
                        suma += division;
                    }
                }
                if (numeroComparado == suma)
                {
                    Console.WriteLine("{0} Es un numero perfecto", numeroComparado);
                    contador++;
                }
                numeroComparado++;
                suma = 0;
            }


            Console.ReadLine();
        }
    }
}
