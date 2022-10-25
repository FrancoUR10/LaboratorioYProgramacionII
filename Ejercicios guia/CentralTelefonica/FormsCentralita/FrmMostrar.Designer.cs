
namespace FormsCentralita
{
    partial class FrmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rcbLista = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rcbLista
            // 
            this.rcbLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcbLista.Location = new System.Drawing.Point(0, 0);
            this.rcbLista.Name = "rcbLista";
            this.rcbLista.Size = new System.Drawing.Size(572, 464);
            this.rcbLista.TabIndex = 0;
            this.rcbLista.Text = "";
            this.rcbLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rcbLista_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Location = new System.Drawing.Point(0, 441);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(572, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 464);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rcbLista);
            this.MinimumSize = new System.Drawing.Size(588, 503);
            this.Name = "FrmMostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rcbLista;
        private System.Windows.Forms.Button btnSalir;
    }
}