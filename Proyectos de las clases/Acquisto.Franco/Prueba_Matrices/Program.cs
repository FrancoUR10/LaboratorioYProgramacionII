using System;

namespace Prueba_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] matrizUnidimensional = new int[] {0,1,2};


            int[,] matrizBidimensional = new int[,] { { 0, 4, 5, 5 }, { 1, 5, 5, 5 } };


            int[,,] matrizTridimensional = new int[,,] { { { 1, 5, 6, 8 }, { 4, 8, 7, 7 }, { 4, 5, 6, 8 } }, { { 1, 5, 6, 8 }, { 4, 8, 7, 87 }, { 4, 56, 6, 9 } } };

            int i = 1;
            int j = 1;
            int k = 3;
            Console.WriteLine("Número: {0} IndiceI: {1}, IndiceJ: {2}",matrizTridimensional[i,j,k],i,j,k);


            Console.ReadKey();
        }
    }
}
