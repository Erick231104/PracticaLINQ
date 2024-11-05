namespace BibliotecaLINQ
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
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnBuscarPorAutor = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnLibrosTitulosLargos = new System.Windows.Forms.Button();
            this.btnControlarLibrosPorGenero = new System.Windows.Forms.Button();
            this.btnLibrosConTitulosLargos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(86, 369);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(127, 69);
            this.btnAgregarLibro.TabIndex = 0;
            this.btnAgregarLibro.Text = "Agregar Libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(298, 26);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(474, 303);
            this.lstLibros.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(74, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(162, 87);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(74, 154);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(162, 204);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 5;
            // 
            // btnBuscarPorAutor
            // 
            this.btnBuscarPorAutor.Location = new System.Drawing.Point(273, 369);
            this.btnBuscarPorAutor.Name = "btnBuscarPorAutor";
            this.btnBuscarPorAutor.Size = new System.Drawing.Size(127, 69);
            this.btnBuscarPorAutor.TabIndex = 8;
            this.btnBuscarPorAutor.Text = "Bucar por Autor";
            this.btnBuscarPorAutor.UseVisualStyleBackColor = true;
            this.btnBuscarPorAutor.Click += new System.EventHandler(this.btnBuscarPorAutor_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(74, 270);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Genero:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(74, 211);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 10;
            this.lblAnio.Text = "Año:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(162, 151);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 11;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(162, 263);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 12;
            // 
            // btnLibrosTitulosLargos
            // 
            this.btnLibrosTitulosLargos.Location = new System.Drawing.Point(0, 0);
            this.btnLibrosTitulosLargos.Name = "btnLibrosTitulosLargos";
            this.btnLibrosTitulosLargos.Size = new System.Drawing.Size(75, 23);
            this.btnLibrosTitulosLargos.TabIndex = 15;
            // 
            // btnControlarLibrosPorGenero
            // 
            this.btnControlarLibrosPorGenero.Location = new System.Drawing.Point(634, 369);
            this.btnControlarLibrosPorGenero.Name = "btnControlarLibrosPorGenero";
            this.btnControlarLibrosPorGenero.Size = new System.Drawing.Size(127, 69);
            this.btnControlarLibrosPorGenero.TabIndex = 14;
            this.btnControlarLibrosPorGenero.Text = "Controlar Libros por Genero";
            this.btnControlarLibrosPorGenero.UseVisualStyleBackColor = true;
            this.btnControlarLibrosPorGenero.Click += new System.EventHandler(this.btnControlarLibrosPorGenero_Click);
            // 
            // btnLibrosConTitulosLargos
            // 
            this.btnLibrosConTitulosLargos.Location = new System.Drawing.Point(447, 369);
            this.btnLibrosConTitulosLargos.Name = "btnLibrosConTitulosLargos";
            this.btnLibrosConTitulosLargos.Size = new System.Drawing.Size(127, 69);
            this.btnLibrosConTitulosLargos.TabIndex = 16;
            this.btnLibrosConTitulosLargos.Text = "Libros Con titulos largos";
            this.btnLibrosConTitulosLargos.UseVisualStyleBackColor = true;
            this.btnLibrosConTitulosLargos.Click += new System.EventHandler(this.btnLibrosConTitulosLargos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLibrosConTitulosLargos);
            this.Controls.Add(this.btnControlarLibrosPorGenero);
            this.Controls.Add(this.btnLibrosTitulosLargos);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnBuscarPorAutor);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.btnAgregarLibro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnBuscarPorAutor;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnLibrosTitulosLargos;
        private System.Windows.Forms.Button btnControlarLibrosPorGenero;
        private System.Windows.Forms.Button btnLibrosConTitulosLargos;
    }
}

