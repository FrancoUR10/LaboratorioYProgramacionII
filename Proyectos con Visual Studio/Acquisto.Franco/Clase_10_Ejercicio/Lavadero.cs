using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Ejercicio
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public double GetLavadero 
        {
            get 
            {
                double totalPrecios = 0;
                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Auto)
                    {
                        totalPrecios = this.MostrarTotalFacturado(EVehiculos.Auto);
                    }
                    if (item is Camion)
                    {
                        totalPrecios = this.MostrarTotalFacturado(EVehiculos.Camion);
                    }
                    if (item is Moto)
                    {
                        totalPrecios = this.MostrarTotalFacturado(EVehiculos.Moto);
                    }
                }
                return totalPrecios;
            }
        }
        public List<Vehiculo> GetVehiculo
        {
            get
            {
                return this.vehiculos;
            }
        }
        public double MostrarTotalFacturado(EVehiculos tiposDeVehiculos) 
        {
            double totalFactura = 0;
            double precioAuto = 0;
            double precioCamion = 0;
            double precioMoto = 0;
            foreach(Vehiculo item in this.vehiculos) 
            {
                if(item is Auto) 
                {
                    precioAuto += this.precioAuto;
                }
                if (item is Camion)
                {
                    precioCamion += this.precioCamion;
                }
                if (item is Moto)
                {
                    precioMoto += this.precioMoto;
                }
            }
            switch (tiposDeVehiculos) 
            {
                case EVehiculos.Auto:
                    totalFactura = precioAuto;
                    break;
                case EVehiculos.Camion:
                    totalFactura = precioCamion;
                    break;
                case EVehiculos.Moto:
                    totalFactura = precioMoto;
                    break;
                default:
                    break;
            }
            return totalFactura;
        }
        public static bool operator ==(Lavadero lavadero,Vehiculo vehiculo) 
        {
            bool respuesta = false;
            foreach(Vehiculo objeto in lavadero.vehiculos) 
            {
                if (objeto == vehiculo) 
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo) 
        {
            return !(lavadero == vehiculo);
        }
        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo) 
        {
            if (lavadero != vehiculo) 
            {
                lavadero.vehiculos.Add(vehiculo);
            }
            return lavadero;
        }
        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo) 
            {
                lavadero.vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }
    }
}