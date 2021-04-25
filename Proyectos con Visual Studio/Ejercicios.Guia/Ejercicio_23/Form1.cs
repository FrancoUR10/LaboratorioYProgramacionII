using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
{
    public partial class Cotizaciones : Form
    {
        Euro euro = new Euro(0);
        Dolar dolar = new Dolar(0);
        Pesos peso = new Pesos(0);
        public Cotizaciones()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.Text == "Abierto") 
            {
                this.txtEuroCotizacion.Enabled = false;
                this.txtDolarCotizacion.Enabled = false;
                this.txtPesoCotizacion.Enabled = false;
                this.btnLockCotizacion.Text = "Cerrado";
            }
            else 
            {
                this.txtEuroCotizacion.Enabled = true;
                this.txtPesoCotizacion.Enabled = true;
                this.btnLockCotizacion.Text = "Abierto";
            }
        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            Euro.SetCotizacion(double.Parse(this.txtEuroCotizacion.Text));
            Pesos.SetCotizacion(double.Parse(this.txtPesoCotizacion.Text));

            this.euro = double.Parse(this.txtEuroCantidad.Text);
            this.txtEuroAEuro.Text = this.euro.GetCantidad().ToString();

            Dolar auxDolar = new Dolar(0);
            auxDolar=(Dolar)this.euro;
            this.txtEuroADolar.Text = auxDolar.GetCantidad().ToString();

            Pesos auxPesos = new Pesos(0);
            auxPesos = (Pesos)this.euro;
            this.txtEuroAPeso.Text = auxPesos.GetCantidad().ToString();

        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            Euro.SetCotizacion(double.Parse(this.txtEuroCotizacion.Text));
            Pesos.SetCotizacion(double.Parse(this.txtPesoCotizacion.Text));

            this.dolar = double.Parse(this.txtDolarCantidad.Text);
            this.txtDolarADolar.Text = this.dolar.GetCantidad().ToString();

            Euro auxEuro = new Euro(0);
            auxEuro = (Euro)this.dolar;
            this.txtDolarAEuro.Text = auxEuro.GetCantidad().ToString();

            Pesos auxPesos = new Pesos(0);
            auxPesos = (Pesos)this.dolar;
            this.txtDolarAPeso.Text = auxPesos.GetCantidad().ToString();
        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            Euro.SetCotizacion(double.Parse(this.txtEuroCotizacion.Text));
            Pesos.SetCotizacion(double.Parse(this.txtPesoCotizacion.Text));

            this.peso = double.Parse(this.txtPesoCantidad.Text);
            this.txtPesoAPeso.Text = this.peso.GetCantidad().ToString();

            Dolar auxDolar = new Dolar(0);
            auxDolar = (Dolar)this.peso;
            this.txtPesoADolar.Text = auxDolar.GetCantidad().ToString();

            Euro auxEuro = new Euro(0);
            auxEuro = (Euro)this.peso;
            this.txtPesoAEuro.Text = auxEuro.GetCantidad().ToString();
        }
    }
}
