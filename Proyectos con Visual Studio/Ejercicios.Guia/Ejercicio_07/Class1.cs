using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class FechaPersona
    {
        public static DateTime fechaNacimiento;
        private static int dia;
        private static int mes;
        private static int año;
        public static string IngresarFechaNacimiento() 
        {
            string fechaCompleta="";
            Console.Write("Ingrese el dia: ");
            FechaPersona.dia= Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes: ");
            FechaPersona.mes = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el año: ");
            FechaPersona.año = Int32.Parse(Console.ReadLine());
            fechaCompleta = FechaPersona.dia.ToString() + "/" + FechaPersona.mes.ToString() + "/" + FechaPersona.año.ToString();
            return fechaCompleta;
        }
        public static int CalcularDias() 
        {
            FechaPersona.fechaNacimiento=DateTime.Parse(FechaPersona.IngresarFechaNacimiento());
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Subtract(FechaPersona.fechaNacimiento).Days;
        }
    }
}
