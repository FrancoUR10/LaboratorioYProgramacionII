using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaParcial;

namespace PracticaParcial_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Bar bar = null;
            bar = bar.GetBar();

            InitializeComponent();
            this.Text = "Contador de Acquisto.Franco";
            this.CenterToScreen();
            this.BackColor = Color.Green;
        }
    }
}
