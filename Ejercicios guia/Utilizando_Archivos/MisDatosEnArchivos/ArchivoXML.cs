using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace MisDatosEnArchivos
{
    public static class ArchivoXML<T>
        where T : new()
    {
        private static string rutaDelArchivo;
        private static StreamWriter escritor;
        private static StreamReader lector;
        private static XmlSerializer serializadorXML;

        static ArchivoXML()
        {
            if (ArchivoXML<T>.rutaDelArchivo == null)
            {
                ArchivoXML<T>.rutaDelArchivo = @"..\..\..\..\Mi archivo XML.xml";
            }
            if (!Directory.Exists(@"..\..\..\..\"))
            {
                Directory.CreateDirectory(@"..\..\..\..\");
            }
        }

        public static bool EscribirArchivo(List<T> lista, bool opcionSobreEscritura)
        {
            bool seEscribio = false;
            try
            {
                using (ArchivoXML<T>.escritor = new StreamWriter(ArchivoXML<T>.rutaDelArchivo, opcionSobreEscritura))
                {
                    if (lista != null)
                    {
                        ArchivoXML<T>.serializadorXML = new XmlSerializer(typeof(List<T>));
                        serializadorXML.Serialize(ArchivoXML<T>.escritor, lista);
                        seEscribio = true;
                    }
                }
            }
            catch (Exception e)
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
                using (ArchivoXML<T>.lector = new StreamReader(ArchivoXML<T>.rutaDelArchivo)) 
                {
                    ArchivoXML<T>.serializadorXML = new XmlSerializer(typeof(List<T>));
                    auxLista = (List<T>)ArchivoXML<T>.serializadorXML.Deserialize(lector);
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
