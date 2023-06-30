using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_17_Delegados
{
    public partial class FrmPrincipal : Form
    {
        FrmMostrar mostrar;
        FrmTestDelegados testDelegados;
        public FrmPrincipal()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.mostrar = new FrmMostrar();
            this.testDelegados = new FrmTestDelegados();
            this.mostrar.MdiParent = this;
            this.testDelegados.MdiParent = this;
            this.testDelegados.delegado += this.mostrar.ActualizarNombre;
            foreach (ToolStripItem unItem in this.menuStrip.Items)
            {
                if (unItem.Text == "Mostrar") 
                {
                    unItem.Enabled = false;
                }
            }
        }
        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.testDelegados.Show();
            foreach (ToolStripItem unItem in this.menuStrip.Items)
            {
                if (unItem.Text == "Mostrar")
                {
                    unItem.Enabled = true;
                }
            }
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mostrar.Show();
        }
    }
}
