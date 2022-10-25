using System;

namespace Ejer_04LaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar='S';
            int operandoUno;
            int operandoDos;
            char operador;


            do
            {
                Console.Write("Ingrese un número: ");
                operandoUno = int.Parse(Console.ReadLine());
                Console.Write("Ingrese otro número: ");
                operandoDos = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el operador: ");
                operador = char.Parse(Console.ReadLine());

                Console.WriteLine("El resultado es: {0}", Calculadora.Calcular(operandoUno, operandoDos, operador));
                Console.Write("Desea continuar? (S/N): ");
                continuar = char.Parse(Console.ReadLine());
                continuar = char.ToUpper(continuar);
                if (continuar == 'S') 
                {
                    Console.Clear();
                }
            }
            while (continuar == 'S');

            Console.ReadLine();
        }
    }
}
