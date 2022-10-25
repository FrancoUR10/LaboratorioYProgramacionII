using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCoordenadas_Formulario
{
    public partial class FormCoordenadas : Form
    {
        public FormCoordenadas()
        {
            InitializeComponent();
            this.Text = "Coordenadas";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = int.Parse( e.X.ToString());
            int y = int.Parse(e.Y.ToString());
            x -= 126;
            y -= 156;
            this.lblXCoordenada.Text = $"X:{x.ToString()}";
            if(y > 0) 
            {
                this.lblYCoordenada.Text = $"Y:-{y.ToString()}";
            }
            else
            {
                y *= -1;
                this.lblYCoordenada.Text = $"Y:{y.ToString()}";
            }
        }
    }
}