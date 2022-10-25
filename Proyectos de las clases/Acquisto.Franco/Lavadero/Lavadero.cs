using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Lavadero
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero() 
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto)
            : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        public string Detalle 
        {
            get 
            {
                StringBuilder texto = new StringBuilder();
                texto.AppendLine($"LAVADERO");
                texto.AppendLine("");
                texto.AppendLine($"Precio total de autos: {this.MostrarTotalFacturado(EVehiculos.Auto)}");
                texto.AppendLine($"Precio total de camiones: {this.MostrarTotalFacturado(EVehiculos.Camion)}");
                texto.AppendLine($"Precio total de motos: {this.MostrarTotalFacturado(EVehiculos.Moto)}");
                texto.AppendLine("");
                texto.AppendLine($"Total de precios: {this.MostrarTotalFacturado()}");
                texto.AppendLine("");
                texto.AppendLine("Vehiculos en el lavadero:");
                texto.AppendLine("");
                foreach (Vehiculo unVehiculo in this.Vehiculos)
                {
                    texto.AppendLine(unVehiculo.ToString());
                }
                return texto.ToString();
            }
        }
        public List<Vehiculo> Vehiculos 
        {
            get 
            {
                return this.vehiculos;
            }
        }
        public double MostrarTotalFacturado() 
        {
            double precioTotal = this.MostrarTotalFacturado(EVehiculos.Auto);
            precioTotal += this.MostrarTotalFacturado(EVehiculos.Camion);
            precioTotal += this.MostrarTotalFacturado(EVehiculos.Moto);
            return precioTotal;
        }
        public double MostrarTotalFacturado(EVehiculos tipoDeVehiculo)
        {
            double precioTotal=0;
            switch (tipoDeVehiculo) 
            {
                case EVehiculos.Auto:
                    foreach (Vehiculo unVehiculo in this.Vehiculos)
                    {
                        if(unVehiculo is Auto) 
                        {
                            precioTotal += this.precioAuto;
                        }
                    }
                    break;
                case EVehiculos.Camion:
                    foreach (Vehiculo unVehiculo in this.Vehiculos)
                    {
                        if (unVehiculo is Camion)
                        {
                            precioTotal += this.precioCamion;
                        }
                    }
                    break;
                case EVehiculos.Moto:
                    foreach (Vehiculo unVehiculo in this.Vehiculos)
                    {
                        if (unVehiculo is Moto)
                        {
                            precioTotal += this.precioMoto;
                        }
                    }
                    break;
                default:
                    break;
            }
            return precioTotal;
        }

        #region Sobrecargas de igualdad
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool seEncuentra = false;
            foreach (Vehiculo unVehiculo in lavadero.Vehiculos)
            {
                if (vehiculo == unVehiculo) 
                {
                    seEncuentra = true;
                    break;
                }
            }
            return seEncuentra;
        }
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo) 
        {
            return !(lavadero == vehiculo);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj is Lavadero) 
            {
                if (this == ((Lavadero)obj)) 
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        public static Lavadero operator +(Lavadero lavadero,Vehiculo vehiculo) 
        {
            if (lavadero != vehiculo) 
            {
                lavadero.Vehiculos.Add(vehiculo);
            }
            return lavadero;
        }
        public static Lavadero operator -(Lavadero lavadero,Vehiculo vehiculo) 
        {
            if (lavadero == vehiculo) 
            {
                lavadero.Vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1,Vehiculo vehiculo2) 
        {
            int comparacion = vehiculo1.Patente.CompareTo(vehiculo2.Patente);
            return comparacion;
        }
        public int OrdenarVehiculosPorMarca(Vehiculo vehiculo1,Vehiculo vehiculo2) 
        {
            int comparacion = vehiculo1.Marca.CompareTo(vehiculo2.Marca);
            return comparacion;
        }
    }
}
