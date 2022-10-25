using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_PruebaTamaños
{
    public partial class FormTamaños : Form
    {
        public FormTamaños()
        {
            this.MinimumSize = new Size(200, 200);
            this.MaximumSize = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
    }
}
