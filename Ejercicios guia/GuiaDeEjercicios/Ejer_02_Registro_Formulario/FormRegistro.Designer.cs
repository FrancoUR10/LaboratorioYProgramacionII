
namespace Ejer_02_Registro_Formulario
{
    partial class FormRegistro
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
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.chbCSharp = new System.Windows.Forms.CheckBox();
            this.chbCDoublePlus = new System.Windows.Forms.CheckBox();
            this.chbJavaScript = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.lsbPaises = new System.Windows.Forms.ListBox();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.numericUpDown1);
            this.grpDetalles.Controls.Add(this.txtDireccion);
            this.grpDetalles.Controls.Add(this.txtNombre);
            this.grpDetalles.Controls.Add(this.lblNombre);
            this.grpDetalles.Controls.Add(this.lblEdad);
            this.grpDetalles.Controls.Add(this.lblDireccion);
            this.grpDetalles.Location = new System.Drawing.Point(12, 12);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(200, 136);
            this.grpDetalles.TabIndex = 0;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles del usuario";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 98);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(69, 57);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(120, 23);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 98);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 57);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbNoBinario);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Controls.Add(this.rdbFemenino);
            this.grpGenero.Location = new System.Drawing.Point(243, 12);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(106, 100);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(6, 73);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdbNoBinario.TabIndex = 8;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 22);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 6;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 48);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 7;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.chbCSharp);
            this.grpCursos.Controls.Add(this.chbCDoublePlus);
            this.grpCursos.Controls.Add(this.chbJavaScript);
            this.grpCursos.Location = new System.Drawing.Point(243, 118);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(106, 100);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // chbCSharp
            // 
            this.chbCSharp.AutoSize = true;
            this.chbCSharp.Location = new System.Drawing.Point(3, 22);
            this.chbCSharp.Name = "chbCSharp";
            this.chbCSharp.Size = new System.Drawing.Size(41, 19);
            this.chbCSharp.TabIndex = 2;
            this.chbCSharp.Text = "C#";
            this.chbCSharp.UseVisualStyleBackColor = true;
            // 
            // chbCDoublePlus
            // 
            this.chbCDoublePlus.AutoSize = true;
            this.chbCDoublePlus.Location = new System.Drawing.Point(3, 47);
            this.chbCDoublePlus.Name = "chbCDoublePlus";
            this.chbCDoublePlus.Size = new System.Drawing.Size(50, 19);
            this.chbCDoublePlus.TabIndex = 1;
            this.chbCDoublePlus.Text = "C++";
            this.chbCDoublePlus.UseVisualStyleBackColor = true;
            // 
            // chbJavaScript
            // 
            this.chbJavaScript.AutoSize = true;
            this.chbJavaScript.Location = new System.Drawing.Point(3, 72);
            this.chbJavaScript.Name = "chbJavaScript";
            this.chbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chbJavaScript.TabIndex = 0;
            this.chbJavaScript.Text = "JavaScript";
            this.chbJavaScript.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(249, 225);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 151);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // lsbPaises
            // 
            this.lsbPaises.FormattingEnabled = true;
            this.lsbPaises.ItemHeight = 15;
            this.lsbPaises.Location = new System.Drawing.Point(12, 169);
            this.lsbPaises.Name = "lsbPaises";
            this.lsbPaises.Size = new System.Drawing.Size(200, 79);
            this.lsbPaises.TabIndex = 5;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 275);
            this.Controls.Add(this.lsbPaises);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDetalles);
            this.Name = "FormRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.CheckBox chbCSharp;
        private System.Windows.Forms.CheckBox chbCDoublePlus;
        private System.Windows.Forms.CheckBox chbJavaScript;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox lsbPaises;
    }
}

