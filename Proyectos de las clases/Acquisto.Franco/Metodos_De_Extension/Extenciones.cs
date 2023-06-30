using System;

namespace Metodos_De_Extension
{
    public static class Extenciones
    {
        public static string ObtenerPlacaCronicaTV(this DateTime fecha, EEstaciones estacion)
        {
            TimeSpan fechaSeleccionada = new TimeSpan();
            int año = fecha.Year;
            switch (estacion) 
            {
                case EEstaciones.Otonio:
                    if (fecha > new DateTime(año, 3, 20)) 
                    {
                        año++;
                    }
                    fechaSeleccionada = new DateTime(año, 3, 20) - fecha;
                    break;
                case EEstaciones.Invierno:
                    if (fecha > new DateTime(año, 6, 21)) 
                    {
                        año++;
                    }
                    fechaSeleccionada = new DateTime(año, 6, 21) - fecha;
                    break;
                case EEstaciones.Primavera:
                    if (fecha > new DateTime(año, 9, 22)) 
                    {
                        año++;
                    }
                    fechaSeleccionada = new DateTime(año, 9, 22) - fecha;
                    break;
                case EEstaciones.Verano:
                    if (fecha > new DateTime(año, 12, 21)) 
                    {
                        año++;
                    }
                    fechaSeleccionada = new DateTime(año, 12, 21) - fecha;
                    break;
                default:
                    break;
            }
            string mensaje = $"Faltan {fechaSeleccionada.Days.ToString()} días para la estación de {Enum.GetName(typeof(EEstaciones), estacion).ToLower()}.";
            return mensaje;
        }
        public static string ContarCantidadDeDigitos(this Int64 numero)
        {
            return $"Cantida de dígitos: {numero.ToString().Length.ToString()}";
        }
        public static string ContarCantidadDeSignos(this string cadena)
        {
            int cantidadSignos = 0;
            foreach(char caracter in cadena) 
            {
                if (caracter == '.' || caracter == ',' || caracter == ';') 
                {
                    cantidadSignos++;
                }
            }
            return $"Cantida de signos: {cantidadSignos.ToString()}";
        }
        public static string FizzBuzz(this int numero)
        {
            string reemplazo = numero.ToString();
            if(numero % 3 == 0 && numero % 5 == 0) 
            {
                reemplazo = "Fizz Buzz";
            }
            else if (numero % 3 == 0) 
            {
                reemplazo = "Fizz";
            }
            else if(numero % 5 == 0) 
            {
                reemplazo = "Buzz";
            }
            return reemplazo;
        }
    }
}
