namespace EstudianteLINQ
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
            this.btnEstudianteConPromediioMayorA = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtFiltrarCurso = new System.Windows.Forms.TextBox();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.txtPromedioMin = new System.Windows.Forms.TextBox();
            this.txtPromedioMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEstudianteConMayorPromedio = new System.Windows.Forms.Button();
            this.btnEstudiantePorRandoDePromedio = new System.Windows.Forms.Button();
            this.btnCantidaddEstuiantePorCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstudianteConPromediioMayorA
            // 
            this.btnEstudianteConPromediioMayorA.Location = new System.Drawing.Point(610, 402);
            this.btnEstudianteConPromediioMayorA.Name = "btnEstudianteConPromediioMayorA";
            this.btnEstudianteConPromediioMayorA.Size = new System.Drawing.Size(224, 23);
            this.btnEstudianteConPromediioMayorA.TabIndex = 0;
            this.btnEstudianteConPromediioMayorA.Text = "Estudiante con primedio mayor A";
            this.btnEstudianteConPromediioMayorA.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(364, 402);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(211, 23);
            this.btnAgregarEstudiante.TabIndex = 1;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.Location = new System.Drawing.Point(301, 52);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(231, 329);
            this.lstEstudiantes.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Promedio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FiltrarCurso";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(161, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(161, 194);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 10;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(161, 264);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 11;
            // 
            // txtFiltrarCurso
            // 
            this.txtFiltrarCurso.Location = new System.Drawing.Point(161, 345);
            this.txtFiltrarCurso.Name = "txtFiltrarCurso";
            this.txtFiltrarCurso.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarCurso.TabIndex = 12;
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(557, 51);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(231, 329);
            this.lstCursos.TabIndex = 13;
            // 
            // txtPromedioMin
            // 
            this.txtPromedioMin.Location = new System.Drawing.Point(161, 464);
            this.txtPromedioMin.Name = "txtPromedioMin";
            this.txtPromedioMin.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioMin.TabIndex = 14;
            // 
            // txtPromedioMax
            // 
            this.txtPromedioMax.Location = new System.Drawing.Point(161, 402);
            this.txtPromedioMax.Name = "txtPromedioMax";
            this.txtPromedioMax.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioMax.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Promedio Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Promedio Max";
            // 
            // btnEstudianteConMayorPromedio
            // 
            this.btnEstudianteConMayorPromedio.Location = new System.Drawing.Point(301, 464);
            this.btnEstudianteConMayorPromedio.Name = "btnEstudianteConMayorPromedio";
            this.btnEstudianteConMayorPromedio.Size = new System.Drawing.Size(168, 23);
            this.btnEstudianteConMayorPromedio.TabIndex = 18;
            this.btnEstudianteConMayorPromedio.Text = "Estudiante Promedio Mayor";
            this.btnEstudianteConMayorPromedio.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantePorRandoDePromedio
            // 
            this.btnEstudiantePorRandoDePromedio.Location = new System.Drawing.Point(488, 464);
            this.btnEstudiantePorRandoDePromedio.Name = "btnEstudiantePorRandoDePromedio";
            this.btnEstudiantePorRandoDePromedio.Size = new System.Drawing.Size(168, 23);
            this.btnEstudiantePorRandoDePromedio.TabIndex = 19;
            this.btnEstudiantePorRandoDePromedio.Text = "Est Rango De Promedio";
            this.btnEstudiantePorRandoDePromedio.UseVisualStyleBackColor = true;
            // 
            // btnCantidaddEstuiantePorCurso
            // 
            this.btnCantidaddEstuiantePorCurso.Location = new System.Drawing.Point(708, 464);
            this.btnCantidaddEstuiantePorCurso.Name = "btnCantidaddEstuiantePorCurso";
            this.btnCantidaddEstuiantePorCurso.Size = new System.Drawing.Size(168, 23);
            this.btnCantidaddEstuiantePorCurso.TabIndex = 20;
            this.btnCantidaddEstuiantePorCurso.Text = "Est Cantidad por Curso";
            this.btnCantidaddEstuiantePorCurso.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 541);
            this.Controls.Add(this.btnCantidaddEstuiantePorCurso);
            this.Controls.Add(this.btnEstudiantePorRandoDePromedio);
            this.Controls.Add(this.btnEstudianteConMayorPromedio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPromedioMax);
            this.Controls.Add(this.txtPromedioMin);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.txtFiltrarCurso);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstEstudiantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.btnEstudianteConPromediioMayorA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstudianteConPromediioMayorA;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtFiltrarCurso;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.TextBox txtPromedioMin;
        private System.Windows.Forms.TextBox txtPromedioMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEstudianteConMayorPromedio;
        private System.Windows.Forms.Button btnEstudiantePorRandoDePromedio;
        private System.Windows.Forms.Button btnCantidaddEstuiantePorCurso;
    }
}

