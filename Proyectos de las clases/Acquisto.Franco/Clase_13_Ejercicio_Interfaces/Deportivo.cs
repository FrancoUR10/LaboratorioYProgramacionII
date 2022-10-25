using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Ejercicio_Interfaces
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public double Impuesto 
        {
            get 
            {
                return ((IAFIP)this).CalcularImpuesto();
            }
        }
        public Deportivo(double precio,string patente,int hp)
            :base(precio,patente)
        {
            this._caballosFuerza = hp;
        }
        double IAFIP.CalcularImpuesto()
        {
            return this._precio + ((this._precio * 28) / 100);
        }
        double IARBA.CalcularImpuesto()
        {
            return this._precio + ((this._precio * 23) / 100);
        }
    }
}
