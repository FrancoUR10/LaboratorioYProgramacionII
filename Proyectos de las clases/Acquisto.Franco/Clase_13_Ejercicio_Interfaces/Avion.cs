using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Ejercicio_Interfaces
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public double Impuesto 
        {
            get 
            {
                return ((IAFIP)this).CalcularImpuesto();
            }
        }
        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }
        double IAFIP.CalcularImpuesto() 
        {
            return this._precio + ((this._precio * 33) / 100);
        }
        public virtual double CalcularImpuesto() 
        {
            return this._precio + ((this._precio * 27) / 100);
        }
    }
}
