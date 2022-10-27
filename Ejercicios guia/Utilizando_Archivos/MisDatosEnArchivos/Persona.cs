using System;
using System.Text;

namespace MisDatosEnArchivos
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private ENacionalidad nacionalidad;

        #region Propiedades
        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        #endregion

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"Mi nombre: {this.nombre} - ");
            texto.Append($"Mi apellido: {this.apellido} - ");
            texto.Append($"Mi edad: {this.edad} - ");
            texto.Append($"Mi nacionalidad: {this.nacionalidad}");
            return texto.ToString();
        }
    }
}
