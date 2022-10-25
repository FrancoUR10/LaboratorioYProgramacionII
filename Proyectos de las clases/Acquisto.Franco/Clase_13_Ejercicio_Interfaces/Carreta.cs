using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Ejercicio_Interfaces
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio)
            : base(precio) 
        {

        }
        public double CalcularImpuesto() 
        {
            return this._precio + ((this._precio * 18) / 100);
        }
    }
}
