using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio_02
{
    public partial class MiFormulario : Form
    {
        public MiFormulario()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int numeroIngresado=0;
            int multiplicacion = 0;
            string tabla = "";
            if ((char)e.KeyChar == (char)Keys.Enter) 
            {
                numeroIngresado=int.Parse(this.txtNumero.Text);
                for(int i = 1; i <= 10; i++) 
                {
                    multiplicacion = numeroIngresado * i;
                    tabla=($"{numeroIngresado} * {i} = {multiplicacion}");
                    this.lstTabla.Items.Add(tabla);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Clear();
            this.lstTabla.Items.Clear();
        }

        private void MiFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
    }
}
