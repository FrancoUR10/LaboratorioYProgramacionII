using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisDatosEnArchivos
{
    public class HeredadoDePersona : Persona
    {
        public string nuevoDatoCadena;
        public int nuevoDatoEntero;
        public HeredadoDePersona(string nombre, string apellido, int edad, ENacionalidad nacionalidad,string nuevoDatoCadena, int nuevoDatoEntero)
            : base(nombre, apellido,edad,nacionalidad)
        {
            this.nuevoDatoCadena = nuevoDatoCadena;
            this.nuevoDatoEntero = nuevoDatoEntero;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.ToString());
            texto.Append($" - Dato cadena: {this.nuevoDatoCadena} - ");
            texto.Append($" - Dato entero: {this.nuevoDatoEntero}");
            return texto.ToString();
        }
    }
}
