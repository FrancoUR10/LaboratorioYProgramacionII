using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°17";

            string miDibujo;
            char seguir = 's';
            bool boligrafoUsado = true;
            short tintaUsada;
            bool sePudoPintar;
            Bolígrafo unoAzul = new Bolígrafo(100,ConsoleColor.Blue);
            Bolígrafo unoRojo = new Bolígrafo(50,ConsoleColor.Red);

            do 
            {
                Console.WriteLine("Tinta boligrafo azul: {0} // tinta boligrafo rojo: {1}\n",unoAzul.GetTinta(), unoRojo.GetTinta());
                Console.WriteLine("1- Usar boligrafo Azul: ");
                Console.WriteLine("2- Usar boligrafo Rojo: ");
                Console.WriteLine("3- Recargar tinta: ");
                Console.WriteLine("4- Pintar: ");
                Console.WriteLine("5- Salir: ");
                Console.Write("Ingrese una opcion: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        boligrafoUsado = true;
                        break;
                    case 2:
                        boligrafoUsado = false;
                        break;
                    case 3:
                        if (boligrafoUsado == true) 
                        {
                            unoAzul.Recargar();
                        }
                        else 
                        {
                            unoRojo.Recargar();
                        }
                        break;
                    case 4 :
                        Console.Write("Elija la cantidad de tinta a usar: ");
                        tintaUsada = short.Parse(Console.ReadLine());
                        if (boligrafoUsado == true) 
                        {
                            sePudoPintar = unoAzul.Pintar(tintaUsada, out miDibujo);
                        }
                        else 
                        {
                            sePudoPintar = unoRojo.Pintar(tintaUsada, out miDibujo);
                        }
                        if (sePudoPintar == true) 
                        {
                            Console.WriteLine(miDibujo);
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case 5 :
                        seguir = 'n';
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }while( seguir == 's');











            Console.ReadKey();
        }
    }
}
