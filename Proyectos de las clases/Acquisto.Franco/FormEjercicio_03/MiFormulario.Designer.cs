
namespace FormEjercicio_03
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
            this.grpboxInformacion = new System.Windows.Forms.GroupBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblDescuentoRecibido = new System.Windows.Forms.Label();
            this.lblImporteCobrar = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpboxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxInformacion
            // 
            this.grpboxInformacion.Controls.Add(this.lblTotalPagar);
            this.grpboxInformacion.Controls.Add(this.lblDescuentoRecibido);
            this.grpboxInformacion.Controls.Add(this.lblImporteCobrar);
            this.grpboxInformacion.Controls.Add(this.txtTotal);
            this.grpboxInformacion.Controls.Add(this.txtImporte);
            this.grpboxInformacion.Controls.Add(this.txtDescuento);
            this.grpboxInformacion.Location = new System.Drawing.Point(12, 12);
            this.grpboxInformacion.Name = "grpboxInformacion";
            this.grpboxInformacion.Size = new System.Drawing.Size(277, 147);
            this.grpboxInformacion.TabIndex = 0;
            this.grpboxInformacion.TabStop = false;
            this.grpboxInformacion.Text = "Información";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPagar.Location = new System.Drawing.Point(38, 98);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(80, 15);
            this.lblTotalPagar.TabIndex = 7;
            this.lblTotalPagar.Text = "Total a pagar:";
            // 
            // lblDescuentoRecibido
            // 
            this.lblDescuentoRecibido.AutoSize = true;
            this.lblDescuentoRecibido.Location = new System.Drawing.Point(33, 64);
            this.lblDescuentoRecibido.Name = "lblDescuentoRecibido";
            this.lblDescuentoRecibido.Size = new System.Drawing.Size(112, 15);
            this.lblDescuentoRecibido.TabIndex = 6;
            this.lblDescuentoRecibido.Text = "Descuento recibido:";
            // 
            // lblImporteCobrar
            // 
            this.lblImporteCobrar.AutoSize = true;
            this.lblImporteCobrar.Location = new System.Drawing.Point(16, 27);
            this.lblImporteCobrar.Name = "lblImporteCobrar";
            this.lblImporteCobrar.Size = new System.Drawing.Size(139, 15);
            this.lblImporteCobrar.TabIndex = 5;
            this.lblImporteCobrar.Text = "Ingrese importe a cobrar:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(161, 95);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 2;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(161, 24);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 23);
            this.txtImporte.TabIndex = 1;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(161, 61);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(50, 178);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(173, 178);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MiFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 231);
            this.Controls.Add(this.grpboxInformacion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "MiFormulario";
            this.Text = "Descuento";
            this.grpboxInformacion.ResumeLayout(false);
            this.grpboxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxInformacion;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblDescuentoRecibido;
        private System.Windows.Forms.Label lblImporteCobrar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

