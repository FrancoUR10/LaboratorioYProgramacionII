using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio_04
{
    public class OrdenarLista : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int resultado = 0;
            if(string.Compare(x,y) < 0)
            {
                resultado = 1;
            }
            else 
            {
                resultado = -1;
            }
            return resultado;
        }
    }
}
