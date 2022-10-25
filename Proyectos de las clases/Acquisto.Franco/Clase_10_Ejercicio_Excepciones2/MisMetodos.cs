using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio_Excepciones_2
{
    public class MisMetodos
    {
        public static void MetodoDeClase() 
        {
            try 
            {
                new MisMetodos().MetodoDeInstancia();
            }
            catch(MiPropiaExcepcion e) 
            {
                throw new MiPropiaExcepcion("Excepción en metodo de clase",e);
            }
        }
        public void MetodoDeInstancia() 
        {
            throw new MiPropiaExcepcion("Excepción en metodo de instancia");
        }
    }
}
