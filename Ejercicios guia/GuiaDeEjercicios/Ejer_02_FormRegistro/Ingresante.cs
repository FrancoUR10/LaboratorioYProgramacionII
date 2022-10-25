using System;
using System.Text;

namespace Ejer_02_FormRegistro
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre,string direccion,string genero,string pais,string[] cursos,int edad) 
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
        public string Mostrar() 
        {
            StringBuilder datosIngresante = new StringBuilder();

            datosIngresante.AppendLine($"Nombre: {this.nombre}");
            datosIngresante.AppendLine($"Direccion: {this.direccion}");
            datosIngresante.AppendLine($"Genero: {this.genero}");
            datosIngresante.AppendLine($"Pais: {this.pais}");
            datosIngresante.Append($"Curso/s: ");
            foreach(string unCurso in this.cursos) 
            {
                datosIngresante.Append(unCurso+" ");
            }
            datosIngresante.AppendLine($"\nEdad: {this.edad}");

            return datosIngresante.ToString();
        }
    }
}
