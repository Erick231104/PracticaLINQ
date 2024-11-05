namespace ZoologicoLINQ
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
            this.txtNombreExibicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAnimales = new System.Windows.Forms.ListBox();
            this.btnAgregarExhibicion = new System.Windows.Forms.Button();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreAnimal = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtBuscarEspecie = new System.Windows.Forms.TextBox();
            this.btbAgregarAnimasl = new System.Windows.Forms.Button();
            this.btnBuscarPorEspecie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreExibicion
            // 
            this.txtNombreExibicion.Location = new System.Drawing.Point(160, 54);
            this.txtNombreExibicion.Name = "txtNombreExibicion";
            this.txtNombreExibicion.Size = new System.Drawing.Size(100, 20);
            this.txtNombreExibicion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Exibicion";
            // 
            // lstAnimales
            // 
            this.lstAnimales.FormattingEnabled = true;
            this.lstAnimales.Location = new System.Drawing.Point(383, 11);
            this.lstAnimales.Name = "lstAnimales";
            this.lstAnimales.Size = new System.Drawing.Size(351, 329);
            this.lstAnimales.TabIndex = 2;
            // 
            // btnAgregarExhibicion
            // 
            this.btnAgregarExhibicion.Location = new System.Drawing.Point(160, 373);
            this.btnAgregarExhibicion.Name = "btnAgregarExhibicion";
            this.btnAgregarExhibicion.Size = new System.Drawing.Size(131, 65);
            this.btnAgregarExhibicion.TabIndex = 3;
            this.btnAgregarExhibicion.Text = "Agregar Exhibicion ";
            this.btnAgregarExhibicion.UseVisualStyleBackColor = true;
            this.btnAgregarExhibicion.Click += new System.EventHandler(this.btnAgregarExhibicion_Click);
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(160, 251);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDeNacimiento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha De Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre Animal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar Especie ";
            // 
            // txtNombreAnimal
            // 
            this.txtNombreAnimal.Location = new System.Drawing.Point(160, 113);
            this.txtNombreAnimal.Name = "txtNombreAnimal";
            this.txtNombreAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAnimal.TabIndex = 9;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(151, 179);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 10;
            // 
            // txtBuscarEspecie
            // 
            this.txtBuscarEspecie.Location = new System.Drawing.Point(151, 326);
            this.txtBuscarEspecie.Name = "txtBuscarEspecie";
            this.txtBuscarEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarEspecie.TabIndex = 11;
            // 
            // btbAgregarAnimasl
            // 
            this.btbAgregarAnimasl.Location = new System.Drawing.Point(360, 373);
            this.btbAgregarAnimasl.Name = "btbAgregarAnimasl";
            this.btbAgregarAnimasl.Size = new System.Drawing.Size(131, 65);
            this.btbAgregarAnimasl.TabIndex = 12;
            this.btbAgregarAnimasl.Text = "Agregaar Animal";
            this.btbAgregarAnimasl.UseVisualStyleBackColor = true;
            this.btbAgregarAnimasl.Click += new System.EventHandler(this.btbAgregarAnimasl_Click);
            // 
            // btnBuscarPorEspecie
            // 
            this.btnBuscarPorEspecie.Location = new System.Drawing.Point(564, 373);
            this.btnBuscarPorEspecie.Name = "btnBuscarPorEspecie";
            this.btnBuscarPorEspecie.Size = new System.Drawing.Size(131, 65);
            this.btnBuscarPorEspecie.TabIndex = 13;
            this.btnBuscarPorEspecie.Text = "Buscar Por Especie";
            this.btnBuscarPorEspecie.UseVisualStyleBackColor = true;
            this.btnBuscarPorEspecie.Click += new System.EventHandler(this.btnBuscarPorEspecie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarPorEspecie);
            this.Controls.Add(this.btbAgregarAnimasl);
            this.Controls.Add(this.txtBuscarEspecie);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtNombreAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.btnAgregarExhibicion);
            this.Controls.Add(this.lstAnimales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreExibicion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreExibicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAnimales;
        private System.Windows.Forms.Button btnAgregarExhibicion;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreAnimal;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtBuscarEspecie;
        private System.Windows.Forms.Button btbAgregarAnimasl;
        private System.Windows.Forms.Button btnBuscarPorEspecie;
    }
}

