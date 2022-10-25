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
    public partial class FrmMostrar : Form
    {
        private Centralita.Centralita miCentralita;
        private Llamada.TipoLlamada tipoLlamada;

        public Llamada.TipoLlamada TipoLlamada 
        {
            set 
            {
                this.tipoLlamada = value;
            }
        }
        public FrmMostrar(Centralita.Centralita miCentralita)
        {
            this.miCentralita = miCentralita;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch (this.tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    this.rcbLista.Text = "Ganancias locales: " + this.miCentralita.GananciasPorLocal.ToString();
                    break;
                case Llamada.TipoLlamada.Provincial:
                    this.rcbLista.Text = "Ganancias provinciales: " + this.miCentralita.GananciasPorProvincial.ToString();
                    break;
                case Llamada.TipoLlamada.Todas:
                    this.rcbLista.Text = this.miCentralita.ToString();
                    break;
                default:
                    break;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rcbLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
