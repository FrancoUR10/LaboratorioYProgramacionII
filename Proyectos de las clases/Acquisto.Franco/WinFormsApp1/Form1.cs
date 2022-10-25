using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MiFormulario : Form
    {
        public MiFormulario()
        {
            InitializeComponent();
        }

        private void MiFormulario_Load(object sender, EventArgs e)
        {
            this.Text = "Saludo desde un form";
            this.lblMiLabel.Text = "¡¡¡Hola mundo WinForm!!!";
            this.lblMiLabel.Visible = false;
        }

        private void MiBoton_Click(object sender, EventArgs e)
        {
            this.lblMiLabel.Visible = true;
        }
    }
}
