
namespace WinFormsApp1
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
            this.btnMiBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMiLabel
            // 
            this.lblMiLabel.AutoSize = true;
            this.lblMiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMiLabel.Location = new System.Drawing.Point(164, 93);
            this.lblMiLabel.Name = "lblMiLabel";
            this.lblMiLabel.Size = new System.Drawing.Size(122, 21);
            this.lblMiLabel.TabIndex = 0;
            this.lblMiLabel.Text = "Texto del label";
            // 
            // btnMiBoton
            // 
            this.btnMiBoton.Location = new System.Drawing.Point(164, 280);
            this.btnMiBoton.Name = "btnMiBoton";
            this.btnMiBoton.Size = new System.Drawing.Size(129, 40);
            this.btnMiBoton.TabIndex = 1;
            this.btnMiBoton.Text = "Haga click aquí";
            this.btnMiBoton.UseVisualStyleBackColor = true;
            this.btnMiBoton.Click += new System.EventHandler(this.MiBoton_Click);
            // 
            // MiFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 355);
            this.Controls.Add(this.btnMiBoton);
            this.Controls.Add(this.lblMiLabel);
            this.Name = "MiFormulario";
            this.Text = "MiForm";
            this.Load += new System.EventHandler(this.MiFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiLabel;
        private System.Windows.Forms.Button btnMiBoton;
    }
}

