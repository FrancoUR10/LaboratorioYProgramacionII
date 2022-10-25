using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class MiClase
    {
        #region atributos NO estaticos

        public String cadena;
        public Int32 entero;

        #endregion

        #region atributos estaticos o de clase

        public static Double doble;

        #endregion

        public void MetodoInstancia() 
        {
            Console.WriteLine("Valor cadena: {0} Valor entero: {1} Valor doble: {2}",this.cadena,this.entero,MiClase.doble);
        }

    }
}
