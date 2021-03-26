using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormatos
{
    class Practica
    {
        static void Main(string[] args)
        {
            Console.Title = "Formatos";
            /*
             * 0 Puede agregar ceros en espacios vacios   # Oculta los ceros que pueden omitirse
           
             :0.00   ||  :#.##   Agrega cantidades de decimales
             :#,# separa por puntos
             :#,#.00 separa por puntos y muestra decimales

             :N separa por puntos y dos decimales (no oculta los ceros)

             :X Convierte a hexadecimal, *no puede tener numeros con comas*

             :E Desconozco este formato

             :C Convierte a moneda (similar a N)

             :D10 Agrega ceros si la cantidad es menor al valor elegido en el formato, *no puede tener numeros con comas*

            Horas:

            G: Muestra la fecha y hora completa en numeros

            dd dia en numero  MM mes en numero  yy año abreviado

            dddd dia en caracteres MMMM mes en caracteres yyyy año completo
            
            hh horas en am/pm  HH horas completas  mm  minutos   ss  segundos   ff milisegundos



            */
            //Console.WriteLine("{0:000,00}",489489.587);
            //Console.WriteLine("{0:N}",85458.9887);
            //Console.WriteLine("{0:X}",16);
            //Console.WriteLine("{0:E}", 5.24);
            //Console.WriteLine("{0:C}", 87459.58987);
            //Console.WriteLine("{0:D10}", 875487);

            Console.WriteLine("Fecha y hora:");

            Console.WriteLine("{0:G}", DateTime.Now);

            Console.WriteLine("Fecha:");

            Console.WriteLine("{0:dd/MM/yy}", DateTime.Now);
            Console.WriteLine("{0:dddd/MMMM/yyyy}", DateTime.Now);

            Console.WriteLine("Hora:");

            Console.WriteLine("{0:hh/mm/ss}", DateTime.Now);
            Console.WriteLine("{0:HH/mm/ss.ff}", DateTime.Now);


            Console.ReadKey();
        }
    }
}
