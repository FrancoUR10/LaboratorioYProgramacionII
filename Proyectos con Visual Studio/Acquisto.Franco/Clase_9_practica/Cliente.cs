using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_practica
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }
        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
        }
        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._tipoDeCliente = tipoCliente;
            this._nombre = nombre;
        }
        private void CrearAlias()
        {
            int nuevoNumeroAlias = 0;
            Random aliasCreado = new Random();
            nuevoNumeroAlias = aliasCreado.Next(1000, 9999);
            this._aliasParaIncognito = nuevoNumeroAlias.ToString() + this._tipoDeCliente.ToString();
        }
        public string GetAlias()
        {
            if (this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }
            return this._aliasParaIncognito;
        }
        private string RetornarDatos() 
        {
            StringBuilder datosCliente = new StringBuilder();
            datosCliente.AppendLine($"Nombre del cliente: {this._nombre}");
            datosCliente.AppendLine($"Tipo de cliente: {this._tipoDeCliente}");
            datosCliente.AppendLine($"Alias: {this._aliasParaIncognito}");
            return datosCliente.ToString();
        }
        public static string RetornarDatos(Cliente unCliente) 
        {
            return unCliente.RetornarDatos();
        }
    }
}
/*
 1. Constructor: El constructor (privado) por default inicializará al nombre con “NN”, al alias con “Sin alias” y al tipo como 
eTipoCliente.SinTipo. Las otras sobrecargas deberán inicializarán los atributos que correspondan, siempre 
reutilizando las demás sobrecargas.
2. Métodos de instancia:
 El método privado “CrearAlias” inicializará al atributo _aliasParaIncognito con un número al azar (utilizar 
Random de 1000 a 9999) concatenado al atributo _tipoDeCliente. Ejemplo: “1536Financista”.
 El método público “GetAlias” se encargará de retornar el alias del cliente. Si el valor del atributo 
_aliasParaIncognito es igual a “Sin alias”, se deberá invocar al método descrito anteriormente.
 El método privado “RetornarDatos” retornará la información del Cliente. Usar la clase StringBuilder.
 El método público y de clase “RetornarDatos” retornará un string conteniendo los datos de la instancia de tipo 
Cliente que recibe como parámetro. Reutilizar código.
 */