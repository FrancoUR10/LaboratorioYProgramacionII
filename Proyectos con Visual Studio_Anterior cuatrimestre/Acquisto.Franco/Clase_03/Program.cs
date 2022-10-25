using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Clase_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase N°3";

            MiClase objetoUno = new MiClase(5);
            MiClase[] variosObjetos = new MiClase[5];
            for(int i = 0; i < 5; i++) 
            {
                variosObjetos[i] = new MiClase(i+1);
            }

            objetoUno.noEstatico = 6;
            MiClase.estatico = 5;

            objetoUno.Mostrar();

            variosObjetos[0].Mostrar();










            Console.ReadKey();
        }
    }
}
