using System;

namespace Biblioteca_Estudiante
{
    public class Estudiante
    {
        #region atributos

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        #endregion
        static Estudiante() 
        {
            Estudiante.random = new Random();
        }
        private Estudiante() 
        {

        }
        public Estudiante(string nombre, string apellido, string legajo)
            :this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        #region metodos

        private double CalcularNotaFinal()
        {
            double notaFinal=-1;
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4) 
            {
                notaFinal=Estudiante.random.Next(6,10);
            }
            return notaFinal;
        }
        private float CalcularPromedio()
        {
            float resultado = this.notaPrimerParcial + this.notaSegundoParcial;
            resultado /= 2;
            return resultado;
        }
        public string Mostrar()
        {
            double notaFinal;
            System.Text.StringBuilder datosEstudiante = new System.Text.StringBuilder();
            datosEstudiante.AppendFormat("\n{0} {1} {2}\n", this.nombre, this.apellido, this.legajo);
            datosEstudiante.AppendFormat("Primer parcial: {0} Segundo parcial: {1}\n", this.notaPrimerParcial, this.notaSegundoParcial);
            datosEstudiante.AppendFormat("Promedio: {0}\n", this.CalcularPromedio());
            notaFinal=this.CalcularNotaFinal();
            if (notaFinal != -1)
            {
                datosEstudiante.AppendFormat("Nota final: {0}", notaFinal);
            }
            else 
            {
                datosEstudiante.Append("Alumno desaprobado");
            }
            return datosEstudiante.ToString();
        }
        public void SetNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota) 
        {
            this.notaSegundoParcial = nota;
        }

        #endregion
    }
}
