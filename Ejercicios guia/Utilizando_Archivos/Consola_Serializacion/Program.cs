using System;
using MisDatosEnArchivos;
using System.Collections.Generic;

namespace Consola_Serializacion
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

            Console.WriteLine("Se logro escribir en JSON: {0}",ArchivoJSON<Persona>.EscribirArchivo(listaPersonas));


            List<Persona> nuevaListaPersona1 = ArchivoJSON<Persona>.LeerArchivo();
            Console.WriteLine("Lectura JSON: ");
            foreach (Persona unaPersona in nuevaListaPersona1)
            {
                Console.WriteLine(unaPersona.ToString());
            }

            Console.WriteLine("Se logro escribir en XML: {0}", ArchivoXML<Persona>.EscribirArchivo(listaPersonas, false));

            Console.WriteLine("Lectura XML: ");
            List<Persona> nuevaListaPersona2 = ArchivoXML<Persona>.LeerArchivo();
            foreach (Persona unaPersona in nuevaListaPersona2)
            {
                Console.WriteLine(unaPersona.ToString());
            }

            Console.ReadKey();
        }
    }
}
