﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1,Punto vertice3) 
        {
            float sumaX = ((float)vertice1.GetX() + vertice3.GetX()) / 2;
            float sumaY = ((float)vertice1.GetY() + vertice3.GetY()) / 2;
            float puntoMedio = sumaX * sumaY;

        }
        
        public float Area() 
        {
            return 0;
        }
        public float Perimetro()
        {
            return 0;
        }
    }
}
