using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita;

namespace FormsCentralita
{
    public partial class FrmLlamador : Form
    {
        private Centralita.Centralita miCentralita;
        public Centralita.Centralita Centralita 
        {
            get 
            {
                return this.miCentralita;
            }
        }
        public FrmLlamador(Centralita.Centralita miCentralita)
        {
            this.miCentralita = miCentralita;
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }

        private void grpNumeros_Enter(object sender, EventArgs e)
        {
            foreach (Control unControl in this.grpNumeros.Controls)
            {
                if(unControl is Button) 
                {
                    if (unControl.Focused) 
                    {
                        if (!((Button)unControl).Text.Contains("#")) 
                        {
                            this.txtDestino.Text += ((Button)unControl).Text;
                        }
                        else if (!this.txtDestino.Text.Contains("#") && this.txtDestino.Text.Length == 0) 
                        {
                            this.txtDestino.Text += ((Button)unControl).Text;
                        }
                    }
                }
            }
            this.ComprobarRegion();
            this.btnLimpiar.Focus();
        }
        private void ComprobarRegion() 
        {
            if (txtDestino.Text.Contains("#"))
            {
                this.cmbFranja.Enabled=true;
            }
            else 
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtDestino.Clear();
            this.ComprobarRegion();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random valorAleatorio = new Random();
            float auxDuracion = valorAleatorio.Next(1, 50);
            float auxCosto;
            if (valorAleatorio.Next(0, 1) == 0)  
            {
                auxCosto = 0.5f;
            }
            else 
            {
                auxCosto = 5.6f;
            }
            try 
            {
                if (this.txtDestino.Text.Contains("#")) 
                {
                    Provincial.Franja franjas;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                    Provincial llamadaProvincial = new Provincial(this.txtOrigen.Text,franjas,auxDuracion,this.txtDestino.Text.Replace("#",""));
                    this.miCentralita += llamadaProvincial;
                }
                else 
                {
                    Local llamadaLocal = new Local(this.txtOrigen.Text, auxDuracion, this.txtDestino.Text, auxCosto);
                    this.miCentralita += llamadaLocal;

                }
                this.DialogResult = DialogResult.OK;
            }
            catch(CentralitaException exception) 
            {
                MessageBox.Show($"{exception.Message}\n Nombre de la clase: {exception.NombreClase}\n Metodo: {exception.NombreMetodo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
