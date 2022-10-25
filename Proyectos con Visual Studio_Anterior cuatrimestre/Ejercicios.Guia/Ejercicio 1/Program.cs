using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio N°1";

            string numeroIngresado;
            int acumulador=0;
            int contador=0;
            float promedio;
            int i;
            int numeroMayor=0;
            int numeroMenor=0;
            bool primerNumeroIngresado=false;
            for(i = 0; i < 5; i++) 
            {
                numeroIngresado = Console.ReadLine();
                acumulador += int.Parse(numeroIngresado);
                contador++;

                if ((int.Parse(numeroIngresado) > numeroMayor) || (primerNumeroIngresado == false)) 
                {
                    numeroMayor = int.Parse(numeroIngresado);
                }
                if ((int.Parse(numeroIngresado) < numeroMenor) || (primerNumeroIngresado == false))
                {
                    numeroMenor = int.Parse(numeroIngresado);
                }
                primerNumeroIngresado = true;
            }
            promedio = (float)acumulador / contador;
            Console.WriteLine("El promedio es: {0} El numero Mayor es: {1} El numero menor es: {2}", promedio,numeroMayor,numeroMenor);



            Console.ReadKey();
        }
    }
}
