using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_sobrecargas
{
    class Sobrecargas
    {
        public int id;
        public string nombre;
        public float salario;

        public Sobrecargas()
        {
            this.salario = (float)50.55;
        }
        public Sobrecargas(int id) : this()
        {
            this.id = id;
        }
        public Sobrecargas(int id, string nombre) : this(id)
        {
            this.nombre = nombre;
        }
        public static Sobrecargas operator +(Sobrecargas dato, int numero)
        {
            dato.id += numero;
            return dato;
        }
        public static Sobrecargas operator +(int numero, Sobrecargas dato)
        {
            dato = dato + numero;
            return dato;
        }
        public static bool operator ==(Sobrecargas dato1, Sobrecargas dato2)
        {
            bool sonIguales = false;
            if (dato1.nombre == dato2.nombre)
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Sobrecargas dato1, Sobrecargas dato2)
        {
            return !(dato1 == dato2);
        }
        public static implicit operator int (Sobrecargas dato)
        {
            return dato.id;
        }
    }

}
