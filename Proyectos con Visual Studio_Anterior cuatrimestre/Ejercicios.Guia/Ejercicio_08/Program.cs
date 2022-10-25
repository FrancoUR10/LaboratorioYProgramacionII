using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°8";
            /*
            Empleado empleadoUno = new Empleado(10,"Alan",19,18);
            Empleado empleadoDos = new Empleado(15,"Pedro",22,20);
            Empleado empleadoTres = new Empleado(4,"Marcos",25,23);
            Empleado empleadoCuatro = new Empleado(8,"Pablo",27,40);

            Console.WriteLine(empleadoTres.mostrarEmpleados());
            */
            /*
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++) 
            {
                numeros[i]=int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            */
            /*
            char[] letras = new char[5];
            for (int i = 0; i < 5; i++)
            {
                char.TryParse(Console.ReadLine(),out letras[i]);
            }
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(letras[i]);
            }
            */
            /*
            string[] textos=new string[6];
            for(int i = 0; i < 6; i++) 
            {
                textos[i]=Console.ReadLine();
            }
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(textos[i]);
            }
            */
            Empleado[] empleados = new Empleado[5];
            for(int i = 0; i < 5; i++) 
            {
                empleados[i] = new Empleado(10, "Alan", 19, 18);
            }
            empleados[2].hora=55;
            foreach(Empleado aux in empleados) 
            {
                Console.WriteLine(aux.hora);
            }
            Console.WriteLine(empleados[2].hora);
            Console.ReadKey();
        }
    }
}
