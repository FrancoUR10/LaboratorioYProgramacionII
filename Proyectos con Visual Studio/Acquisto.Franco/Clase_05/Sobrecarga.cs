using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Sobrecarga
    {
        public int entero;
        public static bool operator ==(Sobrecarga objeto1, Sobrecarga objeto2) 
        {
            return objeto1.entero == objeto2.entero;
        }
        public static bool operator !=(Sobrecarga objeto1, Sobrecarga objeto2)
        {
            return !(objeto1 == objeto2);
        }
    }
}
