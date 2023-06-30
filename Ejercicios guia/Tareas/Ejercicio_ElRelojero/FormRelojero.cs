using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_ElRelojero
{
    public partial class FormRelojero : Form
    {
        public FormRelojero()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void FormRelojero_Load(object sender, EventArgs e)
        {
            Task.Run(() => { this.CambiarHora(); });
            //this.tiempo.Start();
        }
        private void tiempo_Tick(object sender, EventArgs e)
        {
            this.AsignarHora();
        }
        private void AsignarHora() 
        {
            if (this.lblHora.InvokeRequired) 
            {
                Action accion = new Action(this.AsignarHora);
                this.lblHora.Invoke(accion);

                /*
                this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblHora.Text = "Cambio desde aqui";
                }
                );
                */
            }
            else 
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }
        private void CambiarHora() 
        {
            while (true) 
            {
                this.AsignarHora();
                Thread.Sleep(1000);
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrear form = new FormCrear();
            form.Show();
        }
    }
}
