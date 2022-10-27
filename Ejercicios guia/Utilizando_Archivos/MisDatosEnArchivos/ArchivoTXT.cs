using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MisDatosEnArchivos
{
    public static class ArchivoTXT
    {
        private static string rutaDelArchivo;
        private static StreamWriter escritor;
        private static StreamReader lector;

        public static string RutaDelArchivo
        {
            set 
            {
                ArchivoTXT.rutaDelArchivo = value;
            }
        }
        static ArchivoTXT() 
        {
            if (ArchivoTXT.rutaDelArchivo == null) 
            {
                ArchivoTXT.rutaDelArchivo = @"..\..\..\..\Mis Empleados.txt";
            }
            if (!Directory.Exists(@"..\..\..\..\")) 
            {
                Directory.CreateDirectory(@"..\..\..\..\");
            }
        }
        public static bool EscribirArchivo(List<Persona> lista) 
        {
            bool seEscribio = false;
            try 
            {
                using (ArchivoTXT.escritor = new StreamWriter(ArchivoTXT.rutaDelArchivo)) 
                {
                    foreach (Persona unaPersona in lista)
                    {
                        ArchivoTXT.escritor.WriteLine(unaPersona.ToString());
                    }
                    seEscribio = true;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            return seEscribio;
        }
        public static List<Persona> LeerArchivo()
        {
            List<Persona> auxLista = new List<Persona>();
            string personaString = "";
            try 
            {
                using (ArchivoTXT.lector = new StreamReader(ArchivoTXT.rutaDelArchivo)) 
                {
                    while ((personaString = ArchivoTXT.lector.ReadLine()) != null) 
                    {
                        string[] auxArray = personaString.Split(" - ");
                        Persona nuevaPersona = new Persona(auxArray[0],auxArray[1],int.Parse(auxArray[2]),(ENacionalidad)Enum.Parse(typeof(ENacionalidad),auxArray[3]));
                        auxLista.Add(nuevaPersona);
                    }
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            return auxLista;
        }
    }
}
