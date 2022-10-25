
namespace FormEjercicio_04
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
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rdbAscendente = new System.Windows.Forms.RadioButton();
            this.rdbDescendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.grpIngreso = new System.Windows.Forms.GroupBox();
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.grpListaNumeros = new System.Windows.Forms.GroupBox();
            this.grpIngreso.SuspendLayout();
            this.grpOrden.SuspendLayout();
            this.grpListaNumeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(7, 31);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 23);
            this.txtIngreso.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(120, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Checked = true;
            this.rdbAscendente.Location = new System.Drawing.Point(7, 22);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(87, 19);
            this.rdbAscendente.TabIndex = 4;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "Ascendente";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(6, 47);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(93, 19);
            this.rdbDescendente.TabIndex = 5;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(120, 36);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 244);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(233, 31);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 15;
            this.lsbLista.Location = new System.Drawing.Point(6, 22);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(163, 214);
            this.lsbLista.TabIndex = 8;
            // 
            // grpIngreso
            // 
            this.grpIngreso.Controls.Add(this.txtIngreso);
            this.grpIngreso.Controls.Add(this.btnAgregar);
            this.grpIngreso.Location = new System.Drawing.Point(12, 35);
            this.grpIngreso.Name = "grpIngreso";
            this.grpIngreso.Size = new System.Drawing.Size(221, 106);
            this.grpIngreso.TabIndex = 9;
            this.grpIngreso.TabStop = false;
            this.grpIngreso.Text = "Ingrese un nuevo número";
            // 
            // grpOrden
            // 
            this.grpOrden.Controls.Add(this.btnOrdenar);
            this.grpOrden.Controls.Add(this.rdbDescendente);
            this.grpOrden.Controls.Add(this.rdbAscendente);
            this.grpOrden.Location = new System.Drawing.Point(12, 147);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(233, 81);
            this.grpOrden.TabIndex = 0;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Orden";
            // 
            // grpListaNumeros
            // 
            this.grpListaNumeros.Controls.Add(this.lsbLista);
            this.grpListaNumeros.Location = new System.Drawing.Point(282, 35);
            this.grpListaNumeros.Name = "grpListaNumeros";
            this.grpListaNumeros.Size = new System.Drawing.Size(175, 240);
            this.grpListaNumeros.TabIndex = 10;
            this.grpListaNumeros.TabStop = false;
            this.grpListaNumeros.Text = "Lista de números";
            // 
            // MiFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 292);
            this.Controls.Add(this.grpListaNumeros);
            this.Controls.Add(this.grpOrden);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpIngreso);
            this.Name = "MiFormulario";
            this.Text = "Ordenamiento";
            this.grpIngreso.ResumeLayout(false);
            this.grpIngreso.PerformLayout();
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.grpListaNumeros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rdbAscendente;
        private System.Windows.Forms.RadioButton rdbDescendente;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.GroupBox grpIngreso;
        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.GroupBox grpListaNumeros;
    }
}

