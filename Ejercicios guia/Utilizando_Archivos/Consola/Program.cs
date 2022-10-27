using System;
using MisDatosEnArchivos;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();

            Persona persona1 = new Persona("Franco", "Acquisto", 24, ENacionalidad.Argentina);
            Persona persona2 = new Persona("Jorge", "Alejandro", 21, ENacionalidad.Chilena);
            Persona persona3 = new Persona("Juan", "Cruz", 20, ENacionalidad.Uruguaya);

            listaPersonas.Add(persona1);
            listaPersonas.Add(persona2);
            listaPersonas.Add(persona3);

            Console.WriteLine("Se logro escribir: {0}", ArchivoTXT.EscribirArchivo(listaPersonas));


            List<Persona> nuevaListaPersona = ArchivoTXT.LeerArchivo();
            Console.WriteLine("Lectura: ");
            foreach (Persona unaPersona in nuevaListaPersona)
            {
                Console.WriteLine(unaPersona.ToString());
            }


            Console.ReadKey();
        }
    }
}
