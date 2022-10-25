using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEjercicio_04
{
    public partial class MiFormulario : Form
    {
        public MiFormulario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.lsbLista.Items.Add(this.txtIngreso.Text);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            OrdenarLista comparacion = new OrdenarLista();

            foreach(string objeto in this.lsbLista.Items)
            {
                lista.Add(objeto);
            }
            this.lsbLista.Items.Clear();
            if (this.rdbAscendente.Checked == true) 
            {
                lista.Sort();
            }
            else 
            {
                lista.Sort(comparacion);
            }
            foreach(string objeto in lista) 
            {
                this.lsbLista.Items.Add(objeto);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(Control unControl in this.Controls) 
            {
                if(unControl is GroupBox) 
                {
                    foreach(Control unGrupo in unControl.Controls)
                    {
                        if(unGrupo is TextBox) 
                        {
                            ((TextBox)unGrupo).Text = "";
                        }
                        if (unGrupo is ListBox)
                        {
                            ((ListBox)unGrupo).Items.Clear();
                        }
                        if (unGrupo is RadioButton)
                        {
                            ((RadioButton)unGrupo).Checked=false;
                        }
                    }
                }
            }
        }
    }
}
