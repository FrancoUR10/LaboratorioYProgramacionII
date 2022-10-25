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
    public partial class FormSaludo : Form
    {
        public FormSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.lblTitulo.Text = titulo;
            this.lblSaludo.Text = mensaje;
        }
    }
}
