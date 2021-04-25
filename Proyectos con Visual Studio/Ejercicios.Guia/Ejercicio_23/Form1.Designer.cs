
namespace Ejercicio_23
{
    partial class Cotizaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizaciones));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.btnConvertirPeso = new System.Windows.Forms.Button();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPesoCotizacion = new System.Windows.Forms.TextBox();
            this.txtDolarCotizacion = new System.Windows.Forms.TextBox();
            this.txtEuroCotizacion = new System.Windows.Forms.TextBox();
            this.txtPesoCantidad = new System.Windows.Forms.TextBox();
            this.txtDolarCantidad = new System.Windows.Forms.TextBox();
            this.txtEuroCantidad = new System.Windows.Forms.TextBox();
            this.lblPeso1 = new System.Windows.Forms.Label();
            this.lblDolar1 = new System.Windows.Forms.Label();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(63, 15);
            this.lblCotizacion.Margin = new System.Windows.Forms.Padding(0);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(80, 16);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(171, 12);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(75, 23);
            this.btnLockCotizacion.TabIndex = 1;
            this.btnLockCotizacion.Text = "Abierto";
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.Location = new System.Drawing.Point(171, 78);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirEuro.TabIndex = 2;
            this.btnConvertirEuro.Text = "->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Location = new System.Drawing.Point(171, 111);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirDolar.TabIndex = 3;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // btnConvertirPeso
            // 
            this.btnConvertirPeso.Location = new System.Drawing.Point(171, 146);
            this.btnConvertirPeso.Name = "btnConvertirPeso";
            this.btnConvertirPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirPeso.TabIndex = 4;
            this.btnConvertirPeso.Text = "->";
            this.btnConvertirPeso.UseVisualStyleBackColor = true;
            this.btnConvertirPeso.Click += new System.EventHandler(this.btnConvertirPeso_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(5, 81);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(5, 114);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 6;
            this.lblDolar.Text = "Dólar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(5, 152);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso";
            // 
            // txtPesoCotizacion
            // 
            this.txtPesoCotizacion.Location = new System.Drawing.Point(481, 12);
            this.txtPesoCotizacion.Name = "txtPesoCotizacion";
            this.txtPesoCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCotizacion.TabIndex = 8;
            // 
            // txtDolarCotizacion
            // 
            this.txtDolarCotizacion.Enabled = false;
            this.txtDolarCotizacion.Location = new System.Drawing.Point(375, 12);
            this.txtDolarCotizacion.Name = "txtDolarCotizacion";
            this.txtDolarCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtDolarCotizacion.TabIndex = 9;
            this.txtDolarCotizacion.Text = "1";
            // 
            // txtEuroCotizacion
            // 
            this.txtEuroCotizacion.Location = new System.Drawing.Point(269, 12);
            this.txtEuroCotizacion.Name = "txtEuroCotizacion";
            this.txtEuroCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtEuroCotizacion.TabIndex = 10;
            // 
            // txtPesoCantidad
            // 
            this.txtPesoCantidad.Location = new System.Drawing.Point(43, 146);
            this.txtPesoCantidad.Name = "txtPesoCantidad";
            this.txtPesoCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCantidad.TabIndex = 11;
            // 
            // txtDolarCantidad
            // 
            this.txtDolarCantidad.Location = new System.Drawing.Point(43, 114);
            this.txtDolarCantidad.Name = "txtDolarCantidad";
            this.txtDolarCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtDolarCantidad.TabIndex = 12;
            // 
            // txtEuroCantidad
            // 
            this.txtEuroCantidad.Location = new System.Drawing.Point(43, 81);
            this.txtEuroCantidad.Name = "txtEuroCantidad";
            this.txtEuroCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtEuroCantidad.TabIndex = 13;
            // 
            // lblPeso1
            // 
            this.lblPeso1.AutoSize = true;
            this.lblPeso1.Location = new System.Drawing.Point(513, 52);
            this.lblPeso1.Name = "lblPeso1";
            this.lblPeso1.Size = new System.Drawing.Size(31, 13);
            this.lblPeso1.TabIndex = 14;
            this.lblPeso1.Text = "Peso";
            // 
            // lblDolar1
            // 
            this.lblDolar1.AutoSize = true;
            this.lblDolar1.Location = new System.Drawing.Point(401, 52);
            this.lblDolar1.Name = "lblDolar1";
            this.lblDolar1.Size = new System.Drawing.Size(32, 13);
            this.lblDolar1.TabIndex = 15;
            this.lblDolar1.Text = "Dólar";
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(298, 52);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(29, 13);
            this.lblEuro1.TabIndex = 16;
            this.lblEuro1.Text = "Euro";
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Enabled = false;
            this.txtPesoAEuro.Location = new System.Drawing.Point(269, 148);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAEuro.TabIndex = 17;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Enabled = false;
            this.txtPesoADolar.Location = new System.Drawing.Point(375, 149);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoADolar.TabIndex = 18;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(269, 111);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 19;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Enabled = false;
            this.txtPesoAPeso.Location = new System.Drawing.Point(481, 148);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAPeso.TabIndex = 20;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Enabled = false;
            this.txtDolarAPeso.Location = new System.Drawing.Point(481, 111);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPeso.TabIndex = 21;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(269, 78);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 22;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Location = new System.Drawing.Point(481, 78);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPeso.TabIndex = 23;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(375, 78);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 24;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(375, 111);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 25;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "candado abierto.png");
            this.imageList1.Images.SetKeyName(1, "candado cerrado.png");
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 188);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.lblDolar1);
            this.Controls.Add(this.lblPeso1);
            this.Controls.Add(this.txtEuroCantidad);
            this.Controls.Add(this.txtDolarCantidad);
            this.Controls.Add(this.txtPesoCantidad);
            this.Controls.Add(this.txtEuroCotizacion);
            this.Controls.Add(this.txtDolarCotizacion);
            this.Controls.Add(this.txtPesoCotizacion);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.lblCotizacion);
            this.Name = "Cotizaciones";
            this.Text = "Cotizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.Button btnConvertirEuro;
        private System.Windows.Forms.Button btnConvertirDolar;
        private System.Windows.Forms.Button btnConvertirPeso;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPesoCotizacion;
        private System.Windows.Forms.TextBox txtDolarCotizacion;
        private System.Windows.Forms.TextBox txtEuroCotizacion;
        private System.Windows.Forms.TextBox txtPesoCantidad;
        private System.Windows.Forms.TextBox txtDolarCantidad;
        private System.Windows.Forms.TextBox txtEuroCantidad;
        private System.Windows.Forms.Label lblPeso1;
        private System.Windows.Forms.Label lblDolar1;
        private System.Windows.Forms.Label lblEuro1;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.ImageList imageList1;
    }
}

