
namespace PruebaCoordenadas_Formulario
{
    partial class FormCoordenadas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXCoordenada = new System.Windows.Forms.Label();
            this.lblYCoordenada = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblXCoordenada
            // 
            this.lblXCoordenada.AutoSize = true;
            this.lblXCoordenada.Location = new System.Drawing.Point(82, 325);
            this.lblXCoordenada.Name = "lblXCoordenada";
            this.lblXCoordenada.Size = new System.Drawing.Size(14, 15);
            this.lblXCoordenada.TabIndex = 0;
            this.lblXCoordenada.Text = "X";
            // 
            // lblYCoordenada
            // 
            this.lblYCoordenada.AutoSize = true;
            this.lblYCoordenada.Location = new System.Drawing.Point(178, 325);
            this.lblYCoordenada.Name = "lblYCoordenada";
            this.lblYCoordenada.Size = new System.Drawing.Size(14, 15);
            this.lblYCoordenada.TabIndex = 1;
            this.lblYCoordenada.Text = "Y";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "                                         5",
            "",
            "                                         4",
            "",
            "                                         3",
            "",
            "                                         2",
            " ",
            "                                         1",
            "",
            " -5    -4    -3    -2    -1     0     1     2     3     4     5",
            "",
            "                                       -1",
            "",
            "                                       -2",
            "",
            "                                       -3",
            "",
            "                                       -4",
            "",
            "                                       -5"});
            this.listBox1.Location = new System.Drawing.Point(12, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 319);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // FormCoordenadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 347);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblYCoordenada);
            this.Controls.Add(this.lblXCoordenada);
            this.Name = "FormCoordenadas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXCoordenada;
        private System.Windows.Forms.Label lblYCoordenada;
        private System.Windows.Forms.ListBox listBox1;
    }
}

