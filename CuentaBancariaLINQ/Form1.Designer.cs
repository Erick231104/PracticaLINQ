namespace CuentaBancariaLINQ
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
            this.btnDepositrar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lstTransacciones = new System.Windows.Forms.ListBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnMostrarTransaccionesRecientes = new System.Windows.Forms.Button();
            this.FiltrarTransaccionesAltas = new System.Windows.Forms.Button();
            this.btnMostrarPromedioTransacciones = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDepositrar
            // 
            this.btnDepositrar.Location = new System.Drawing.Point(65, 380);
            this.btnDepositrar.Name = "btnDepositrar";
            this.btnDepositrar.Size = new System.Drawing.Size(87, 46);
            this.btnDepositrar.TabIndex = 0;
            this.btnDepositrar.Text = "Depositar";
            this.btnDepositrar.UseVisualStyleBackColor = true;
            this.btnDepositrar.Click += new System.EventHandler(this.btnDepositrar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(158, 154);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // lstTransacciones
            // 
            this.lstTransacciones.Location = new System.Drawing.Point(353, 37);
            this.lstTransacciones.Name = "lstTransacciones";
            this.lstTransacciones.Size = new System.Drawing.Size(397, 303);
            this.lstTransacciones.TabIndex = 8;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(62, 154);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto:";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(195, 380);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(103, 46);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnMostrarTransaccionesRecientes
            // 
            this.btnMostrarTransaccionesRecientes.Location = new System.Drawing.Point(323, 380);
            this.btnMostrarTransaccionesRecientes.Name = "btnMostrarTransaccionesRecientes";
            this.btnMostrarTransaccionesRecientes.Size = new System.Drawing.Size(102, 58);
            this.btnMostrarTransaccionesRecientes.TabIndex = 5;
            this.btnMostrarTransaccionesRecientes.Text = "Mostrar Transacciones Recientes";
            this.btnMostrarTransaccionesRecientes.UseVisualStyleBackColor = true;
            this.btnMostrarTransaccionesRecientes.Click += new System.EventHandler(this.btnMostrarTransaccionesRecientes_Click);
            // 
            // FiltrarTransaccionesAltas
            // 
            this.FiltrarTransaccionesAltas.Location = new System.Drawing.Point(610, 380);
            this.FiltrarTransaccionesAltas.Name = "FiltrarTransaccionesAltas";
            this.FiltrarTransaccionesAltas.Size = new System.Drawing.Size(128, 46);
            this.FiltrarTransaccionesAltas.TabIndex = 6;
            this.FiltrarTransaccionesAltas.Text = "Filtrar transacciones altas";
            this.FiltrarTransaccionesAltas.UseVisualStyleBackColor = true;
            this.FiltrarTransaccionesAltas.Click += new System.EventHandler(this.FiltrarTransaccionesAltas_Click);
            // 
            // btnMostrarPromedioTransacciones
            // 
            this.btnMostrarPromedioTransacciones.Location = new System.Drawing.Point(458, 380);
            this.btnMostrarPromedioTransacciones.Name = "btnMostrarPromedioTransacciones";
            this.btnMostrarPromedioTransacciones.Size = new System.Drawing.Size(116, 46);
            this.btnMostrarPromedioTransacciones.TabIndex = 7;
            this.btnMostrarPromedioTransacciones.Text = "Mostrar Promedio Transacciones";
            this.btnMostrarPromedioTransacciones.UseVisualStyleBackColor = true;
            this.btnMostrarPromedioTransacciones.Click += new System.EventHandler(this.btnMostrarPromedioTransacciones_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(65, 246);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnMostrarPromedioTransacciones);
            this.Controls.Add(this.FiltrarTransaccionesAltas);
            this.Controls.Add(this.btnMostrarTransaccionesRecientes);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lstTransacciones);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnDepositrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositrar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ListBox lstTransacciones;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnMostrarTransaccionesRecientes;
        private System.Windows.Forms.Button FiltrarTransaccionesAltas;
        private System.Windows.Forms.Button btnMostrarPromedioTransacciones;
        private System.Windows.Forms.Label lblSaldo;
    }
}

