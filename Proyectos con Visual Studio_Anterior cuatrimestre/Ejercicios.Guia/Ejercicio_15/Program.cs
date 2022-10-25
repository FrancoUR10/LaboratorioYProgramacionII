using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°15";

            int primerNumero;
            int segundoNumero;
            char operador;
            float resultadoOperacion;
            Console.Write("Ingrese el primer numero: ");
            primerNumero = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el segundo numero: ");
            segundoNumero = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la operacion que desea realizar (+ - * /): ");
            operador=char.Parse(Console.ReadLine());
            resultadoOperacion = Calculadora.Calcular(primerNumero, segundoNumero, operador);

            Console.WriteLine("\nEl resultado de {0} {2} {1} es: {3}",primerNumero,segundoNumero,operador,resultadoOperacion);








            Console.ReadKey();
        }
    }
}
