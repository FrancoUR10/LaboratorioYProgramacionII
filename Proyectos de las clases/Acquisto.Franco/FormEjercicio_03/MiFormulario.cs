using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio_03
{
    public partial class MiFormulario : Form
    {
        public MiFormulario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double importe = int.Parse(this.txtImporte.Text);
            double descuento = 0;
            double total = 0;

            if(importe >= 3000 && importe <= 5000) 
            {
                descuento = 10;
            }
            else if(importe > 5000) 
            {
                descuento=20;
            }
            total += importe - ((importe * descuento) / 100);
            this.txtDescuento.Text = descuento.ToString();
            this.txtTotal.Text = total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control controles in this.grpboxInformacion.Controls) 
            {
                if (controles is TextBox) 
                {
                    controles.Text = "";
                }
            }
        }
    }
}
