
namespace PracticaParcial_Formulario
{
    partial class Form2
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
            this.rtbSalidaDeText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSalidaDeText
            // 
            this.rtbSalidaDeText.Location = new System.Drawing.Point(0, 0);
            this.rtbSalidaDeText.Name = "rtbSalidaDeText";
            this.rtbSalidaDeText.Size = new System.Drawing.Size(428, 349);
            this.rtbSalidaDeText.TabIndex = 0;
            this.rtbSalidaDeText.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 348);
            this.Controls.Add(this.rtbSalidaDeText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeText;
    }
}