using System;
using System.Text;

namespace Biblioteca_Persona
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public DateTime FechaDeNacimiento
        {
            set
            {
                this.fechaDeNacimiento = value;
            }
            get
            {
                return this.fechaDeNacimiento;
            }
        }
        public string DNI
        {
            set
            {
                this.dni = value;
            }
            get
            {
                return this.dni;
            }
        }
        private double CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - this.fechaDeNacimiento;
            double dias = diferencia.TotalDays;
            double años = Math.Floor(dias / 365.2422);
            return años;
        }
        public string Mostrar() 
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Nombre: {this.nombre}");
            texto.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento}");
            texto.AppendLine($"DNI: {this.dni}");
            return texto.ToString();
        }
        public string EsMayorDeEdad() 
        {
            string texto = "No es mayor de edad";
            if(CalcularEdad() >= 18) 
            {
                texto = "Es mayor de edad";
            }
            return texto;
        }
    }
}
