namespace VehiculoLINQ
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
            this.lblKilo0metrajeMinimo = new System.Windows.Forms.Label();
            this.txtKilometrajeMinimo = new System.Windows.Forms.TextBox();
            this.lstAutos = new System.Windows.Forms.ListBox();
            this.btnAnalisisCompleto = new System.Windows.Forms.Button();
            this.lblPrecioMax = new System.Windows.Forms.Label();
            this.txtPrecioMaximo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKilo0metrajeMinimo
            // 
            this.lblKilo0metrajeMinimo.AutoSize = true;
            this.lblKilo0metrajeMinimo.Location = new System.Drawing.Point(61, 64);
            this.lblKilo0metrajeMinimo.Name = "lblKilo0metrajeMinimo";
            this.lblKilo0metrajeMinimo.Size = new System.Drawing.Size(94, 13);
            this.lblKilo0metrajeMinimo.TabIndex = 0;
            this.lblKilo0metrajeMinimo.Text = "Kilometraje Minimo";
            // 
            // txtKilometrajeMinimo
            // 
            this.txtKilometrajeMinimo.Location = new System.Drawing.Point(203, 57);
            this.txtKilometrajeMinimo.Name = "txtKilometrajeMinimo";
            this.txtKilometrajeMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtKilometrajeMinimo.TabIndex = 1;
            // 
            // lstAutos
            // 
            this.lstAutos.FormattingEnabled = true;
            this.lstAutos.Location = new System.Drawing.Point(337, 44);
            this.lstAutos.Name = "lstAutos";
            this.lstAutos.Size = new System.Drawing.Size(312, 394);
            this.lstAutos.TabIndex = 2;
            // 
            // btnAnalisisCompleto
            // 
            this.btnAnalisisCompleto.Location = new System.Drawing.Point(12, 366);
            this.btnAnalisisCompleto.Name = "btnAnalisisCompleto";
            this.btnAnalisisCompleto.Size = new System.Drawing.Size(133, 52);
            this.btnAnalisisCompleto.TabIndex = 4;
            this.btnAnalisisCompleto.Text = "ANALISIS COMPLETO";
            this.btnAnalisisCompleto.UseVisualStyleBackColor = true;
            this.btnAnalisisCompleto.Click += new System.EventHandler(this.btnAnalisisCompleto_Click);
            // 
            // lblPrecioMax
            // 
            this.lblPrecioMax.AutoSize = true;
            this.lblPrecioMax.Location = new System.Drawing.Point(61, 126);
            this.lblPrecioMax.Name = "lblPrecioMax";
            this.lblPrecioMax.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioMax.TabIndex = 5;
            this.lblPrecioMax.Text = "Precio Maximo";
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.Location = new System.Drawing.Point(203, 119);
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMaximo.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(203, 200);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(203, 262);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(64, 200);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(36, 17);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca";
            this.lblMarca.UseCompatibleTextRendering = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(64, 265);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(41, 17);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.UseCompatibleTextRendering = true;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(170, 366);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(133, 52);
            this.btnAgregarVehiculo.TabIndex = 11;
            this.btnAgregarVehiculo.Text = "AGREGAR VEHICULO";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 458);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecioMaximo);
            this.Controls.Add(this.lblPrecioMax);
            this.Controls.Add(this.btnAnalisisCompleto);
            this.Controls.Add(this.lstAutos);
            this.Controls.Add(this.txtKilometrajeMinimo);
            this.Controls.Add(this.lblKilo0metrajeMinimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilo0metrajeMinimo;
        private System.Windows.Forms.TextBox txtKilometrajeMinimo;
        private System.Windows.Forms.ListBox lstAutos;
        private System.Windows.Forms.Button btnAnalisisCompleto;
        private System.Windows.Forms.Label lblPrecioMax;
        private System.Windows.Forms.TextBox txtPrecioMaximo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
    }
}

