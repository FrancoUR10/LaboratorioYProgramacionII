using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private Bar singleton;

        public List<Empleado> Empleados
        {
            get 
            {
                return this.empleados;
            }
        }
        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }
        private Bar() 
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
            this.singleton = new Bar();
        }
        public Bar GetBar() 
        {
            Bar nuevoBar = new Bar();
            return nuevoBar;
        }
        public static bool operator +(Bar bar, Empleado empleado) 
        {
            bool sePuedeAgregar = true;
            foreach(Empleado item in bar.empleados) 
            {
                if(item == empleado) 
                {
                    sePuedeAgregar = false;
                    break;
                }
            }
            if (sePuedeAgregar == true) 
            {
                bar.empleados.Add(empleado);
            }
            return sePuedeAgregar;
        }
        public static bool operator +(Bar bar, Gente gente) 
        {
            bool sePuedeAgregar = false;
            int cantidadEmpleados = bar.empleados.Count;
            int cantidadGente = bar.gente.Count;

            if((cantidadEmpleados*10) > cantidadGente) 
            {
                sePuedeAgregar = true;
            }
            if (sePuedeAgregar == true) 
            {
                bar.gente.Add(gente);
            }
            return sePuedeAgregar;
        }
    }
}
