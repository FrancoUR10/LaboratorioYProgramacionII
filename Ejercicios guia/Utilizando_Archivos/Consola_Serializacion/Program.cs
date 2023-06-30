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

            HeredadoDePersona herencia1 = new HeredadoDePersona("Franco", "Acquisto", 24, ENacionalidad.Argentina, "Dato1", 1);
            HeredadoDePersona herencia2 = new HeredadoDePersona("Jorge", "Alejandro", 21, ENacionalidad.Chilena, "Dato2", 2);
            HeredadoDePersona herencia3 = new HeredadoDePersona("Juan", "Cruz", 20, ENacionalidad.Uruguaya, "Dato3", 3);




            listaPersonas.Add(herencia1);
            listaPersonas.Add(herencia2);
            listaPersonas.Add(herencia3);

            Console.WriteLine("Se logro escribir en JSON: {0}",ArchivoJSON<Persona>.EscribirArchivo(listaPersonas));


            List<Persona> nuevaListaPersona1 = ArchivoJSON<Persona>.LeerArchivo();
            Console.WriteLine("Lectura JSON: ");
            foreach (Persona unaPersona in nuevaListaPersona1)
            {
                if(unaPersona is HeredadoDePersona) 
                {
                    Console.WriteLine(((HeredadoDePersona)unaPersona).ToString());
                }
            }


            Console.WriteLine("Se logro escribir en XML PERSONAS: {0}", ArchivoXML<Persona>.EscribirArchivo(listaPersonas, false));

            Console.WriteLine("Lectura XML PERSONAS: ");
            List<Persona> nuevaListaPersona2 = ArchivoXML<Persona>.LeerArchivo();
            foreach (Persona unaPersona in nuevaListaPersona2)
            {
                Console.WriteLine(unaPersona.ToString());
            }
            Console.ReadKey();
        }
    }
}
