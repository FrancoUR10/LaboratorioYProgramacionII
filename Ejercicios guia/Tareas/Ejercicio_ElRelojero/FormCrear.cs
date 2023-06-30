using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_ElRelojero
{
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Task.Run(this.AbrirFormulario);
        }
        private void AbrirFormulario() 
        {
            FormSegundoPlano segundo = new FormSegundoPlano();
            if (segundo.InvokeRequired)
            {
                Action delegado = new Action(this.AbrirFormulario);
                this.Invoke(delegado);
            }
            else 
            {
                segundo.Show();
            }
        }
    }
}
