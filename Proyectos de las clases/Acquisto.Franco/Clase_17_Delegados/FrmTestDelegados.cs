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
    public partial class FrmTestDelegados : Form
    {
        public delegate void MiDelegado(string nombre);
        public MiDelegado delegado;
        
        public FrmTestDelegados()
        {
            InitializeComponent();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (delegado != null) 
            {
                delegado.Invoke(this.txtNombre.Text);
            }
        }
    }
}
