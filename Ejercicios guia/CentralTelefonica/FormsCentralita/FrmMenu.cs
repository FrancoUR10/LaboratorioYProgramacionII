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
    public partial class FrmMenu : Form
    {
        private Centralita.Centralita miCentralita;
        public FrmMenu()
        {
            this.miCentralita = new Centralita.Centralita("Mega Llamadas");
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FrmLlamador formLlamador = new FrmLlamador(this.miCentralita);
            formLlamador.ShowDialog();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar formMostrar = new FrmMostrar(this.miCentralita);
            formMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            formMostrar.ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar formMostrar = new FrmMostrar(this.miCentralita);
            formMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            formMostrar.ShowDialog();
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar formMostrar = new FrmMostrar(this.miCentralita);
            formMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            formMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
