using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
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
            :this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        public string GetLavadero
        {
            get
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine($"*****LAVADERO*****\n");
                mensaje.AppendLine($"Total en autos: {this.MostrarTotalFacturado(EVehiculos.Auto)}");
                mensaje.AppendLine($"Total en camiones: {this.MostrarTotalFacturado(EVehiculos.Camion)}");
                mensaje.AppendLine($"Total en motos: {this.MostrarTotalFacturado(EVehiculos.Moto)}");
                mensaje.AppendLine($"Total facturado: {this.MostrarTotalFacturado()}");
                mensaje.AppendLine($"*****LISTA DE VEHICULOS*****");
                foreach (Vehiculo item in this.vehiculos) 
                {
                    mensaje.AppendLine($"{item.GetVehiculo}");
                }
                return mensaje.ToString();
            }
        }
        public List<Vehiculo> Vehiculos 
        {
            get 
            {
                return this.vehiculos;
            }
        }
        public double MostrarTotalFacturado(EVehiculos tipoDeVehiculo) 
        {
            double totalFacturado = 0;
            double totalAutos = 0;
            double totalCamiones = 0;
            double totalMotos = 0;
            foreach (Vehiculo item in this.vehiculos) 
            {
                switch (tipoDeVehiculo)
                {
                    case EVehiculos.Auto:
                        if (item is Auto) 
                        {
                            totalAutos += this.precioAuto;
                        }
                        break;
                    case EVehiculos.Camion:
                        if(item is Camion) 
                        {
                            totalCamiones += this.precioCamion;
                        }
                        break;
                    case EVehiculos.Moto:
                        if(item is Moto) 
                        {
                            totalMotos += this.precioMoto;
                        }
                        break;
                    default:
                        break;
                }
            }
            totalFacturado = totalAutos + totalCamiones + totalMotos;
            return totalFacturado;
        }
        public double MostrarTotalFacturado() 
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
        }
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo) 
        {
            bool respuesta = false;
            foreach (Vehiculo item in lavadero.vehiculos) 
            {
                if (item == vehiculo) 
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo) 
        {
            return !(lavadero==vehiculo);
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
