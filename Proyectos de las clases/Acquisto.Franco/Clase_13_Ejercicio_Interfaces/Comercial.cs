using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Ejercicio_Interfaces
{
    public class Comercial : Avion
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros)
            : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }
        public override double CalcularImpuesto()
        {
            return this._precio + ((this._precio * 25) / 100);
        }
    }
}
