using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class Usuario
    {
        private int id;
        private string correo;
        private string clave;
        private string nombre;
        private int edad;

        public int Id { get { return this.id;}set { this.id = value; } }
        public string Correo { get { return this.correo;}set { this.correo = value; } }
        public string Clave { get { return this.clave;}set { this.clave = value; } }
        public string Nombre { get { return this.nombre;}set { this.nombre = value; } }
        public int Edad { get { return this.edad;}set { this.edad = value; } }

        public Usuario(int id, string correo, string clave, string nombre, int edad)
        {
            this.id = id;
            this.correo = correo;
            this.clave = clave;
            this.nombre = nombre;
            this.edad = edad;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"ID: {this.id}");
            texto.Append($"Correo: {this.correo}");
            texto.Append($"Clave: {this.clave}");
            texto.Append($"Nombre: {this.nombre}");
            texto.Append($"Edad: {this.edad}");
            return texto.ToString();
        }
    }
}
