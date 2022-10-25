using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejer_02_FormRegistro;

namespace Ejer_02_Registro_Formulario
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            string[] listaPaises = {"Argentina","Chile","Uruguay"};
            foreach(string unPais in listaPaises) 
            {
                this.lsbPaises.Items.Add(unPais);
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresante unIngresante;
            string genero = "";
            string[] cursos=new string[3];
            int indice = 0;
            foreach(Control unControl in this.grpGenero.Controls) 
            {
                if(unControl is RadioButton) 
                {
                    if (((RadioButton)unControl).Checked) 
                    {
                        genero = unControl.Text;
                    }
                }
            }
            foreach(Control unControl in this.grpCursos.Controls) 
            {
                if(unControl is CheckBox)
                {
                    if (((CheckBox)unControl).Checked) 
                    {
                        cursos[indice] = unControl.Text;
                        indice++;
                    }
                }
            }
            if (string.IsNullOrEmpty(cursos[0])) 
            {
                cursos[0] = "Ninguno";
            }
            unIngresante = new Ingresante(this.txtNombre.Text,this.txtDireccion.Text,genero,this.lsbPaises.SelectedItem.ToString(),cursos,int.Parse(this.numericUpDown1.Value.ToString()));
            MessageBox.Show(unIngresante.Mostrar());
        }
    }
}
