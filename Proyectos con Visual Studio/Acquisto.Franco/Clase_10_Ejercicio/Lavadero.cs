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

        public string GetLavadero 
        {
            get 
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("**********LAVADERO**********\n");
                mensaje.AppendLine("**********PRECIOS VIGENTES**********\n");
                mensaje.AppendLine($"Precio por lavar auto: {this.precioAuto}");
                mensaje.AppendLine($"Precio por lavar camion: {this.precioCamion}");
                mensaje.AppendLine($"Precio por lavar moto: {this.precioMoto}");
                mensaje.AppendLine($"\n**********Vehiculos en el lavadero**********\n");
                foreach(Vehiculo item in this.Vehiculos) 
                {
                    if(item is Auto) 
                    {
                        mensaje.AppendLine(((Auto)item).MostrarAuto());
                    }
                    if (item is Camion)
                    {
                        mensaje.AppendLine(((Camion)item).MostrarCamion());
                    }
                    if (item is Moto)
                    {
                        mensaje.AppendLine(((Moto)item).MostrarMoto());
                    }
                }
                mensaje.AppendLine($"**********FACTURACIONES**********\n");
                mensaje.AppendLine($"Total facturado en autos: {MostrarTotalFacturado(EVehiculos.Auto).ToString()}");
                mensaje.AppendLine($"Total facturado en camiones: {MostrarTotalFacturado(EVehiculos.Camion).ToString()}");
                mensaje.AppendLine($"Total facturado en motos: {MostrarTotalFacturado(EVehiculos.Moto).ToString()}");
                mensaje.Append($"\nTotal facturado: {MostrarTotalFacturado().ToString()}");
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
        public double MostrarTotalFacturado()
        {
            double totalDePrecios=0;
            totalDePrecios = this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
            return totalDePrecios;
        }
        public double MostrarTotalFacturado(EVehiculos tipoDeVehiculo) 
        {
            double totalDePrecios = 0;
            double precioTotalAuto = 0;
            double precioTotalCamion = 0;
            double precioTotalMoto = 0;
            foreach (Vehiculo item in this.Vehiculos)
            {
                if (item is Auto)
                {
                    precioTotalAuto += this.precioAuto;
                }
                if (item is Camion)
                {
                    precioTotalCamion += this.precioCamion;
                }
                if (item is Moto)
                {
                    precioTotalMoto += this.precioMoto;
                }
            }
            switch (tipoDeVehiculo) 
            {
                case EVehiculos.Auto:
                    totalDePrecios= precioTotalAuto;
                    break;
                case EVehiculos.Camion:
                    totalDePrecios = precioTotalCamion;
                    break;
                case EVehiculos.Moto:
                    totalDePrecios = precioTotalMoto;
                    break;
                default:
                    break;
            }
            return totalDePrecios;
        }
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo) 
        {
            bool respuesta = false;
            foreach(Vehiculo item in lavadero.Vehiculos) 
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
            return !(lavadero == vehiculo);
        }
        public static Lavadero operator +(Lavadero lavadero,Vehiculo vehiculo) 
        {
            if (lavadero != vehiculo) 
            {
                lavadero.Vehiculos.Add(vehiculo);
            }
            return lavadero;
        }
        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo) 
        {
            if (lavadero == vehiculo) 
            {
                lavadero.Vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }
    }
}