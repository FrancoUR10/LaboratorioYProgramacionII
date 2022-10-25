using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_Ejercicio_Interfaces
{
    public interface IAFIP
    {
        double Impuesto 
        {
            get;
        }
        double CalcularImpuesto();
    }
}
