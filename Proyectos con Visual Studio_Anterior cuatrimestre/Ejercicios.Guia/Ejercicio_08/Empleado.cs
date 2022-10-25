using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Empleado
    {
        public int hora;
        public string nombre;
        public int años;
        public int cantidadHorasTrabajadas;
        public Empleado(int hora, string nombre, int años, int cantidadHorasTrabajadas)
        {
            this.hora = hora;
            this.nombre = nombre;
            this.años = años;
            this.cantidadHorasTrabajadas = cantidadHorasTrabajadas;
        }
        public string mostrarEmpleados()
        {
            StringBuilder nuevoString = new StringBuilder();
            nuevoString.AppendLine($"Nombre: {this.nombre}");
            nuevoString.AppendLine($"Años: {this.años}");
            nuevoString.AppendLine($"Hora: {this.hora}");
            nuevoString.AppendLine($"Cantidad horas trabajadas: {this.cantidadHorasTrabajadas}");
            return nuevoString.ToString();
        }
    }
}
