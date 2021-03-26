using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class MiClase
    {
        public static int estatico;
        public int noEstatico;

        static MiClase() 
        {
            MiClase.estatico = 99;
        }

        public MiClase(int entero)
        {
            this.noEstatico = entero;
            MiClase.estatico++;
        }

        public void Mostrar() 
        {
            Console.WriteLine(this.noEstatico);
            Console.WriteLine(MiClase.estatico);
        }

    }
}
