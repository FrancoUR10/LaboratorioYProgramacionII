
namespace Ejer_01_HolaWindowsForms
{
    partial class MiForm
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(138, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(138, 23);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(138, 152);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(100, 23);
            this.btnMensaje.TabIndex = 4;
            this.btnMensaje.Text = "Saludar";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(12, 93);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(93, 15);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Materia favorita:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(12, 111);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(226, 23);
            this.cmbMateria.TabIndex = 6;
            // 
            // MiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 187);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Name = "MiForm";
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.MiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
    }
}

