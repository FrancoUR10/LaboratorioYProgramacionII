
namespace FormEjercicio_02
{
    partial class MiFormulario
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
            this.lblMiLabel = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lstTabla = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMiLabel
            // 
            this.lblMiLabel.AutoSize = true;
            this.lblMiLabel.Location = new System.Drawing.Point(25, 54);
            this.lblMiLabel.Name = "lblMiLabel";
            this.lblMiLabel.Size = new System.Drawing.Size(110, 15);
            this.lblMiLabel.TabIndex = 0;
            this.lblMiLabel.Text = "Ingrese un número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(155, 51);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lstTabla
            // 
            this.lstTabla.FormattingEnabled = true;
            this.lstTabla.ItemHeight = 15;
            this.lstTabla.Location = new System.Drawing.Point(25, 93);
            this.lstTabla.Name = "lstTabla";
            this.lstTabla.Size = new System.Drawing.Size(230, 199);
            this.lstTabla.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(104, 307);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MiFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 342);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstTabla);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblMiLabel);
            this.Name = "MiFormulario";
            this.Text = "Tabla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiFormulario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiLabel;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstTabla;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

