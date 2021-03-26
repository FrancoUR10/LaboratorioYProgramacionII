using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio N°16";

            Alumno alumnoUno = new Alumno("Carlos","Juan",1054);
            Alumno alumnoDos = new Alumno("Perez","Santiago",2545);
            Alumno alumnoTres = new Alumno("Dias","Pepe",8564);

            alumnoUno.Estudiar(7, 5);
            alumnoDos.Estudiar(4, 6);
            alumnoTres.Estudiar(5, 3);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            Console.Write(alumnoUno.Mostrar());
            Console.Write(alumnoDos.Mostrar());
            Console.Write(alumnoTres.Mostrar());















            Console.ReadKey();
        }
    }
}
