using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Ejercicio_Interfaces
{
    public abstract class Vehiculo
    {
        protected double _precio;
        public Vehiculo(double precio) 
        {
            this._precio = precio;
        }
        public void MostrarPrecio() 
        {
            Console.WriteLine("Precio: {0}",this._precio);
        }
    }
}
