using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace MisDatosEnArchivos
{
    public static class ArchivoJSON<T>
    {
        private static string rutaDelArchivo;
        private static StreamWriter escritor;
        private static StreamReader lector;

        public static string RutaDelArchivo
        {
            set
            {
                ArchivoJSON<T>.rutaDelArchivo = value;
            }
        }
        static ArchivoJSON()
        {
            if (ArchivoJSON<T>.rutaDelArchivo == null)
            {
                ArchivoJSON<T>.rutaDelArchivo = @"..\..\..\..\Mi archivo JSON.json";
            }
            if (!Directory.Exists(@"..\..\..\..\"))
            {
                Directory.CreateDirectory(@"..\..\..\..\");
            }
        }

        public static bool EscribirArchivo(List<T> lista)
        {
            string datosJson="";
            bool seEscribio = false;
            try 
            {
                using(ArchivoJSON<T>.escritor=new StreamWriter(ArchivoJSON<T>.rutaDelArchivo)) 
                {
                    datosJson=JsonSerializer.Serialize(lista);
                    escritor.Write(datosJson);
                    seEscribio = true;
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            return seEscribio;
        }
        public static List<T> LeerArchivo() 
        {
            List<T> auxLista = new List<T>();
            try 
            {
                using (ArchivoJSON<T>.lector = new StreamReader(ArchivoJSON<T>.rutaDelArchivo)) 
                {
                    auxLista=JsonSerializer.Deserialize<List<T>>(lector.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return auxLista;
        }

    }
}
