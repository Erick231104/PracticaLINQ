namespace ProductoLINQ
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblLimiteBajoStock = new System.Windows.Forms.Label();
            this.lbFiltrarCategoria = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtLimiteBajoStock = new System.Windows.Forms.TextBox();
            this.txtFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnCalcularValorInventario = new System.Windows.Forms.Button();
            this.btnProductosBajoStock = new System.Windows.Forms.Button();
            this.btnFiltrarPorCategoria = new System.Windows.Forms.Button();
            this.btnMostrarProductosMasCaros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(41, 105);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(41, 157);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(41, 211);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblLimiteBajoStock
            // 
            this.lblLimiteBajoStock.AutoSize = true;
            this.lblLimiteBajoStock.Location = new System.Drawing.Point(41, 263);
            this.lblLimiteBajoStock.Name = "lblLimiteBajoStock";
            this.lblLimiteBajoStock.Size = new System.Drawing.Size(92, 13);
            this.lblLimiteBajoStock.TabIndex = 4;
            this.lblLimiteBajoStock.Text = "Limite Bajo Stock:";
            // 
            // lbFiltrarCategoria
            // 
            this.lbFiltrarCategoria.AutoSize = true;
            this.lbFiltrarCategoria.Location = new System.Drawing.Point(41, 316);
            this.lbFiltrarCategoria.Name = "lbFiltrarCategoria";
            this.lbFiltrarCategoria.Size = new System.Drawing.Size(80, 13);
            this.lbFiltrarCategoria.TabIndex = 5;
            this.lbFiltrarCategoria.Text = "Filtrar Categoria";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(180, 105);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(180, 204);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(180, 157);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 11;
            // 
            // txtLimiteBajoStock
            // 
            this.txtLimiteBajoStock.Location = new System.Drawing.Point(180, 256);
            this.txtLimiteBajoStock.Name = "txtLimiteBajoStock";
            this.txtLimiteBajoStock.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteBajoStock.TabIndex = 12;
            // 
            // txtFiltrarCategoria
            // 
            this.txtFiltrarCategoria.Location = new System.Drawing.Point(180, 309);
            this.txtFiltrarCategoria.Name = "txtFiltrarCategoria";
            this.txtFiltrarCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarCategoria.TabIndex = 13;
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(303, 28);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(499, 290);
            this.lstProductos.TabIndex = 14;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(95, 370);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(115, 59);
            this.btnAgregarProducto.TabIndex = 15;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCalcularValorInventario
            // 
            this.btnCalcularValorInventario.Location = new System.Drawing.Point(244, 370);
            this.btnCalcularValorInventario.Name = "btnCalcularValorInventario";
            this.btnCalcularValorInventario.Size = new System.Drawing.Size(115, 59);
            this.btnCalcularValorInventario.TabIndex = 16;
            this.btnCalcularValorInventario.Text = "Calcular el valor del Inventario";
            this.btnCalcularValorInventario.UseVisualStyleBackColor = true;
            this.btnCalcularValorInventario.Click += new System.EventHandler(this.btnCalcularValorInventario_Click);
            // 
            // btnProductosBajoStock
            // 
            this.btnProductosBajoStock.Location = new System.Drawing.Point(390, 370);
            this.btnProductosBajoStock.Name = "btnProductosBajoStock";
            this.btnProductosBajoStock.Size = new System.Drawing.Size(115, 59);
            this.btnProductosBajoStock.TabIndex = 17;
            this.btnProductosBajoStock.Text = "Productos bajo Stock";
            this.btnProductosBajoStock.UseVisualStyleBackColor = true;
            this.btnProductosBajoStock.Click += new System.EventHandler(this.btnProductosBajoStock_Click);
            // 
            // btnFiltrarPorCategoria
            // 
            this.btnFiltrarPorCategoria.Location = new System.Drawing.Point(545, 370);
            this.btnFiltrarPorCategoria.Name = "btnFiltrarPorCategoria";
            this.btnFiltrarPorCategoria.Size = new System.Drawing.Size(115, 59);
            this.btnFiltrarPorCategoria.TabIndex = 18;
            this.btnFiltrarPorCategoria.Text = "Filtrar por Categoria";
            this.btnFiltrarPorCategoria.UseVisualStyleBackColor = true;
            this.btnFiltrarPorCategoria.Click += new System.EventHandler(this.btnFiltrarPorCategoria_Click);
            // 
            // btnMostrarProductosMasCaros
            // 
            this.btnMostrarProductosMasCaros.Location = new System.Drawing.Point(687, 370);
            this.btnMostrarProductosMasCaros.Name = "btnMostrarProductosMasCaros";
            this.btnMostrarProductosMasCaros.Size = new System.Drawing.Size(115, 59);
            this.btnMostrarProductosMasCaros.TabIndex = 19;
            this.btnMostrarProductosMasCaros.Text = "Mostrar Productos mas Caros";
            this.btnMostrarProductosMasCaros.UseVisualStyleBackColor = true;
            this.btnMostrarProductosMasCaros.Click += new System.EventHandler(this.btnMostrarProductosMasCaros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnMostrarProductosMasCaros);
            this.Controls.Add(this.btnFiltrarPorCategoria);
            this.Controls.Add(this.btnProductosBajoStock);
            this.Controls.Add(this.btnCalcularValorInventario);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.txtFiltrarCategoria);
            this.Controls.Add(this.txtLimiteBajoStock);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbFiltrarCategoria);
            this.Controls.Add(this.lblLimiteBajoStock);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblLimiteBajoStock;
        private System.Windows.Forms.Label lbFiltrarCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtLimiteBajoStock;
        private System.Windows.Forms.TextBox txtFiltrarCategoria;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnCalcularValorInventario;
        private System.Windows.Forms.Button btnProductosBajoStock;
        private System.Windows.Forms.Button btnFiltrarPorCategoria;
        private System.Windows.Forms.Button btnMostrarProductosMasCaros;
    }
}

