
namespace Ejercicio_ElRelojero
{
    partial class FormRelojero
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
            this.components = new System.ComponentModel.Container();
            this.richTxtReloj = new System.Windows.Forms.RichTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtReloj
            // 
            this.richTxtReloj.Location = new System.Drawing.Point(89, 61);
            this.richTxtReloj.Name = "richTxtReloj";
            this.richTxtReloj.Size = new System.Drawing.Size(221, 202);
            this.richTxtReloj.TabIndex = 0;
            this.richTxtReloj.Text = "";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(89, 43);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 15);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(150, 290);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(108, 50);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Formulario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FormRelojero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 352);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.richTxtReloj);
            this.Name = "FormRelojero";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRelojero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtReloj;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Button btnCrear;
    }
}

