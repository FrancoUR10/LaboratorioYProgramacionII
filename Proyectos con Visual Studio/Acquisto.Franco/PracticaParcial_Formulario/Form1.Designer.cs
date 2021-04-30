
namespace PracticaParcial_Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInforme = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.numEmpleados = new System.Windows.Forms.NumericUpDown();
            this.numGente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(345, 207);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(113, 58);
            this.btnInforme.TabIndex = 0;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(187, 83);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(59, 13);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Location = new System.Drawing.Point(187, 159);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(36, 13);
            this.lblGente.TabIndex = 2;
            this.lblGente.Text = "Gente";
            // 
            // numEmpleados
            // 
            this.numEmpleados.Location = new System.Drawing.Point(345, 76);
            this.numEmpleados.Name = "numEmpleados";
            this.numEmpleados.Size = new System.Drawing.Size(120, 20);
            this.numEmpleados.TabIndex = 3;
            // 
            // numGente
            // 
            this.numGente.Location = new System.Drawing.Point(345, 152);
            this.numGente.Name = "numGente";
            this.numGente.Size = new System.Drawing.Size(120, 20);
            this.numGente.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 323);
            this.Controls.Add(this.numGente);
            this.Controls.Add(this.numEmpleados);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btnInforme);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.NumericUpDown numEmpleados;
        private System.Windows.Forms.NumericUpDown numGente;
    }
}

