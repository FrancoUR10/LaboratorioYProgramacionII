using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_01_HolaWindowsForms
{
    public partial class MiForm : Form
    {
        public MiForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void btnMensaje_Click(object sender, EventArgs e)
        {
            string camposIncompletos = "";
            if(string.IsNullOrWhiteSpace(this.txtNombre.Text) || string.IsNullOrWhiteSpace(this.txtApellido.Text)) 
            {
                if (string.IsNullOrWhiteSpace(this.txtNombre.Text)) 
                {
                    camposIncompletos += "Nombre\n";
                }
                if (string.IsNullOrWhiteSpace(this.txtApellido.Text)) 
                {
                    camposIncompletos += "Apellido\n";
                }
                MessageBox.Show($"Se debe completar el siguiente campo:\n{camposIncompletos}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                string mensaje = $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.cmbMateria.SelectedItem}.";
                FormSaludo form = new FormSaludo("¡Hola, Windows Forms!",mensaje);
                form.ShowDialog();
            }
        }

        private void MiForm_Load(object sender, EventArgs e)
        {
            string[] materias ={"Sistemas Operativos","Metodología","Inglés II","Programación II","Laboratorio II","Estadística"};
            this.cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(string unaMateria in materias) 
            {
                cmbMateria.Items.Add(unaMateria);
            }
            cmbMateria.SelectedIndex = 0;
        }
    }
}
