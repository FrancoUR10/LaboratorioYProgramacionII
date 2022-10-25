using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Sobrecarga
    {
        public int entero;
        public string cadena;

        public Sobrecarga() 
        {
            this.entero = 8;
            this.cadena = "sin valor";
        }
        public Sobrecarga(int entero) : this()
        {
            this.entero = entero;
        }
        public Sobrecarga(string cadena) : this()
        {
            this.cadena = cadena;
        }
        public Sobrecarga(int entero,string cadena) : this(entero)
        {
            this.cadena = cadena;
        }
        public Sobrecarga(string cadena,int entero) : this(entero,cadena)
        {
        }


        public static void MiMetodo() 
        {
            Console.WriteLine("Sin parametros");
        }
        public static void MiMetodo(string parametro) 
        {
            Console.WriteLine(parametro);
        }
        public static void MiMetodo(int parametro)
        {
            Console.WriteLine(parametro);
        }
        public static void MiMetodo(int parametro,string parametro1)
        {
            Console.WriteLine("{0} - {1}",parametro,parametro1);
        }
        public static void MiMetodo(string parametro, int parametro1)
        {
            Console.WriteLine("{1} - {0}", parametro, parametro1);
        }
    }
}
