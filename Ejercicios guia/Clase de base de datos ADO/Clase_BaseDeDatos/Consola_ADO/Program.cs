using System;
using BaseDeDatos;
using System.Collections.Generic;

namespace Consola_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            ADO baseDeDatos = new ADO();
            if (baseDeDatos.ProbarConexion()) 
            {
                Console.WriteLine("Se conecta");
            }
            else 
            {
                Console.WriteLine("No se conecta");
            }

            List<Usuario> lista = baseDeDatos.SelectDatos();
            if(lista != null) 
            {
                foreach (Usuario unUsuario in lista)
                {
                    Console.WriteLine(unUsuario.ToString());
                }
            }
            else 
            {
                Console.WriteLine("No se obtuvieron los usuarios");
            }



            Console.ReadKey();
        }
    }
}
