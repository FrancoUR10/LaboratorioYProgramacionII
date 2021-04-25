using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_practica
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Cliente Dueño 
        {
            get 
            {
                return this._dueño;
            }
        }
        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set 
            {
                this._saldo = value;
            }
        }
        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this.Saldo = saldoInicial;
            this.Dueño.GetAlias();
        }
        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial)
        {
            Cliente nuevoCliente = new Cliente(tipo, nombre);
            this._dueño = nuevoCliente;
            this._numeroCuenta = numero;
            this.Saldo = saldoInicial;
            this.Dueño.GetAlias();
        }
        public static explicit operator int(CuentaOffShore cos) 
        {
            return cos._numeroCuenta;
        }
        public static bool operator ==(CuentaOffShore cos1,CuentaOffShore cos2) 
        {
            bool respuesta=false;
            if((object)cos1==null && (object)cos2 == null) 
            {
                respuesta = true;
            }
            else if ((object)cos1 != null && (object)cos2 != null)
            {
                if(cos1._numeroCuenta==cos2._numeroCuenta && cos1.Dueño.GetAlias() == cos2.Dueño.GetAlias()) 
                {
                    respuesta = true;
                }
            }    
                return respuesta;
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2) 
        {
            return !(cos1==cos2);
        }
    }
}
