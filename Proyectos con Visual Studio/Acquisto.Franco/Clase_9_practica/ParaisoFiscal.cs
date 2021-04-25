using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_practica
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }
        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }
        public void MostrarParaiso()
        {
            Console.WriteLine("\nFecha de inicio: {0:dd/MM/yyyy}", ParaisoFiscal.fechaInicioActividades);
            Console.WriteLine("Locación: {0}", this._lugar);
            Console.WriteLine("Cantidad de cuentitas: {0}", ParaisoFiscal.cantidadDeCuentas);
            Console.WriteLine("**************Listado de cuentas OffShores**************");
            foreach (CuentaOffShore item in this._listadoCuentas)
            {
                Console.Write(Cliente.RetornarDatos(item.Dueño));
                Console.WriteLine("Numero de cuentas: {0}",(int)item);
                Console.WriteLine("Saldo: {0}\n",item.Saldo);
            }
        }
        public static implicit operator ParaisoFiscal(eParaisosFiscales unLugar)
        {
            ParaisoFiscal nuevoParaiso = new ParaisoFiscal(unLugar);
            return nuevoParaiso;
        }
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool respuesta = false;
            foreach (CuentaOffShore item in pf._listadoCuentas)
            {
                if (item == cos)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }
        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf == cos)
            {
                pf._listadoCuentas.Remove(cos);
                ParaisoFiscal.cantidadDeCuentas--;
                Console.WriteLine("Se ha removido una cuenta al paraiso");
            }
            else 
            {
                Console.WriteLine("La cuenta no se encuentra en el paraiso");
            }
            return pf;
        }
        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos) 
        {
            int indice=-1;
            if(pf != cos) 
            {
                pf._listadoCuentas.Add(cos);
                ParaisoFiscal.cantidadDeCuentas++;
                Console.WriteLine("Se ha agregado una cuenta al paraiso");
            }
            else
            {
                indice = pf.BuscarIndice(cos);
                pf._listadoCuentas[indice].Saldo += cos.Saldo;
                Console.WriteLine("Se actualizo el saldo de la cuenta");
            }
            return pf;
        }
        public int BuscarIndice(CuentaOffShore cuentaABuscar) 
        {
            int indiceBusqueda = -1;
            for(int i = 0; i < this._listadoCuentas.Count; i++) 
            {
                if (this._listadoCuentas[i] == cuentaABuscar) 
                {
                    indiceBusqueda = i;
                    break;
                }
            }
            return indiceBusqueda;
        }
    }
}
