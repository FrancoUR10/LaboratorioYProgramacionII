using System;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°3";

            int numerosAMostrar;
            int numeroIngresado;
            int contador = 0;
            bool numeroValido;
            bool confirmacionSalir=false;
            string textoIngresado="";

            Console.Write("Ingrese un número o escriba salir para cerrar: ");
            do
            {
                textoIngresado = Console.ReadLine();
                textoIngresado = textoIngresado.ToLower();
                numeroValido = int.TryParse(textoIngresado, out numeroIngresado);
                if ((numeroValido == false) && (textoIngresado != "salir"))
                {
                    Console.Write("ERROR. Reingrese un número o escriba salir: ");
                }
                else if (textoIngresado == "salir")
                {
                    Console.Write("Esta seguro que desea salir? (s/n): ");
                    if (Console.ReadLine() == "s")
                    {
                        confirmacionSalir = true;
                    }
                    else 
                    {
                        Console.Write("Ingrese un número o escriba salir: ");
                    }
                }
                
                if (numeroValido == true) 
                {
                    for(numerosAMostrar = 0; numerosAMostrar <= numeroIngresado; numerosAMostrar++) 
                    {
                        for(int i = numerosAMostrar; i > 0; i--) 
                        {
                            if (numerosAMostrar % i == 0) 
                            {
                                contador++;
                            }
                        }
                        if (contador == 2) 
                        {
                            Console.WriteLine("Numero primo: {0}", numerosAMostrar);
                        }
                        contador = 0;
                    }
                    Console.Write("Ingrese otro número o escriba salir para cerrar: ");
                }
            } while (confirmacionSalir == false);

        }
    }
}
