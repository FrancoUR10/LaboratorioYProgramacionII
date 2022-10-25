using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio_Excepciones_1
{
    public class MisMetodos
    {
        public static void Metodo1() 
        {
            try 
            {
                MisMetodos.Metodo2();
            }
            catch (MiPropiaExcepcion e)
            {
                throw new MiPropiaExcepcion("Mi excepcion en metodo 1", e);
            }
        }
        public static void Metodo2()
        {
            try 
            {
                MisMetodos.Metodo3();
            }
            catch (MiPropiaExcepcion e)
            {
                throw new MiPropiaExcepcion("Mi excepcion en metodo 2", e);
            }
        }
        public static void Metodo3()
        {
            throw new MiPropiaExcepcion("Mi excepcion en metodo 3");
        }
    }
}
