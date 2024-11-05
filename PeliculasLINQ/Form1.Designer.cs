namespace PeliculasLINQ
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
            this.btnFiltrarPordirector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstpeliculas = new System.Windows.Forms.ListBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDirectorFiltrado = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGeberoFiltrado = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorGenero = new System.Windows.Forms.Button();
            this.btnMostrarPromedioAnios = new System.Windows.Forms.Button();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFiltrarPordirector
            // 
            this.btnFiltrarPordirector.Location = new System.Drawing.Point(298, 379);
            this.btnFiltrarPordirector.Name = "btnFiltrarPordirector";
            this.btnFiltrarPordirector.Size = new System.Drawing.Size(127, 59);
            this.btnFiltrarPordirector.TabIndex = 0;
            this.btnFiltrarPordirector.Text = "Filtrar por Directoor";
            this.btnFiltrarPordirector.UseVisualStyleBackColor = true;
            this.btnFiltrarPordirector.Click += new System.EventHandler(this.btnFiltrarPordirector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // lstpeliculas
            // 
            this.lstpeliculas.FormattingEnabled = true;
            this.lstpeliculas.Location = new System.Drawing.Point(298, 50);
            this.lstpeliculas.Name = "lstpeliculas";
            this.lstpeliculas.Size = new System.Drawing.Size(446, 290);
            this.lstpeliculas.TabIndex = 2;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(142, 156);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Director Filtrado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Genero Filtrado";
            // 
            // txtDirectorFiltrado
            // 
            this.txtDirectorFiltrado.Location = new System.Drawing.Point(142, 257);
            this.txtDirectorFiltrado.Name = "txtDirectorFiltrado";
            this.txtDirectorFiltrado.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorFiltrado.TabIndex = 10;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(142, 203);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 11;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(142, 102);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 12;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(142, 49);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 13;
            // 
            // txtGeberoFiltrado
            // 
            this.txtGeberoFiltrado.Location = new System.Drawing.Point(142, 318);
            this.txtGeberoFiltrado.Name = "txtGeberoFiltrado";
            this.txtGeberoFiltrado.Size = new System.Drawing.Size(100, 20);
            this.txtGeberoFiltrado.TabIndex = 14;
            // 
            // btnFiltrarPorGenero
            // 
            this.btnFiltrarPorGenero.Location = new System.Drawing.Point(464, 379);
            this.btnFiltrarPorGenero.Name = "btnFiltrarPorGenero";
            this.btnFiltrarPorGenero.Size = new System.Drawing.Size(127, 59);
            this.btnFiltrarPorGenero.TabIndex = 16;
            this.btnFiltrarPorGenero.Text = "Filtrar por Genero";
            this.btnFiltrarPorGenero.UseVisualStyleBackColor = true;
            this.btnFiltrarPorGenero.Click += new System.EventHandler(this.btnFiltrarPorGenero_Click);
            // 
            // btnMostrarPromedioAnios
            // 
            this.btnMostrarPromedioAnios.Location = new System.Drawing.Point(632, 379);
            this.btnMostrarPromedioAnios.Name = "btnMostrarPromedioAnios";
            this.btnMostrarPromedioAnios.Size = new System.Drawing.Size(127, 59);
            this.btnMostrarPromedioAnios.TabIndex = 17;
            this.btnMostrarPromedioAnios.Text = "Mostrar Promedio de Años";
            this.btnMostrarPromedioAnios.UseVisualStyleBackColor = true;
            this.btnMostrarPromedioAnios.Click += new System.EventHandler(this.btnMostrarPromedioAnios_Click);
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(127, 379);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(127, 59);
            this.btnAgregarPelicula.TabIndex = 18;
            this.btnAgregarPelicula.Text = "Agregar Pelicula";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarPelicula);
            this.Controls.Add(this.btnMostrarPromedioAnios);
            this.Controls.Add(this.btnFiltrarPorGenero);
            this.Controls.Add(this.txtGeberoFiltrado);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtDirectorFiltrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lstpeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrarPordirector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrarPordirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstpeliculas;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDirectorFiltrado;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGeberoFiltrado;
        private System.Windows.Forms.Button btnFiltrarPorGenero;
        private System.Windows.Forms.Button btnMostrarPromedioAnios;
        private System.Windows.Forms.Button btnAgregarPelicula;
    }
}

