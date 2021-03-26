using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string apellido,string nombre,int legajo) 
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public void CalcularFinal() 
        {
            if(this.nota1 > 3 && this.nota2 > 3) 
            {
                Random resultadoNotas = new Random();
                this.notaFinal = resultadoNotas.Next();
            }
            else 
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string datosAlumno="";
            StringBuilder armarMensaje=new StringBuilder();
            armarMensaje.AppendLine($"Nombre: {this.nombre} Apellido: {this.apellido} Legajo: {this.legajo}");
            armarMensaje.AppendLine($"PrimeraNota: {this.nota1} SegundaNota: {this.nota2}");
            if(this.notaFinal != -1) 
            {
                armarMensaje.AppendLine($"Nota final: {this.notaFinal}\n");
            }
            else 
            {
                armarMensaje.AppendLine("Alumno desaprobado\n");
            }
            datosAlumno = Convert.ToString(armarMensaje);
            return datosAlumno;
        }
    }
}