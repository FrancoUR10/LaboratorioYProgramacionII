using System;
using Ejer_TemperasWForms;

namespace Ejer_TemperasWForms_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta p1 = 5;
            Paleta p2 = 6;
            Paleta p3;

            Tempera t1 = new Tempera(ConsoleColor.Red,"Alba",50);
            Tempera t2 = new Tempera(ConsoleColor.Blue,"Alba",50);
            Tempera t3 = new Tempera(ConsoleColor.Red,"Alba",25);
            Tempera t4 = new Tempera(ConsoleColor.Black,"Pinturita",50);
            Tempera t5 = new Tempera(ConsoleColor.Green,"Temperita",50);
            Tempera t6;

            p1 += t1;
            p1 += t2;
            p2 += t3;
            p2 += t4;
            p2 += t5;

            t6 = p1[0];
            p1[0]=t2;
            Console.WriteLine($"T6 vale: {t6}");
            Console.WriteLine(t1==t2);
            Console.WriteLine(t1==t3);
            Console.WriteLine(t1==t4);
            Console.WriteLine(t1==null);
            Console.WriteLine(null==t1);

            t1 += t2;
            t1 += t3;
            t1 += t4;
            t1 += null;

            t1 += 20;
            t2 += 30;

            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine("Muestro paleta");

            p3 = p1 + p2;

            Console.WriteLine((string)p3);
            /*
             En el Main





NOTA: luego de cada comparación, suma o resta, mostrar el contenido completo de la tempera.
             */
            Console.ReadKey();
        }
    }
}
