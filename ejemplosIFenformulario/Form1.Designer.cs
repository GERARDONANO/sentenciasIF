namespace ejemplosIFenformulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblguardado = new System.Windows.Forms.Label();
            this.cmbxnacionalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa Nacionalidad";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(110, 182);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(113, 140);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(113, 96);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(100, 20);
            this.txtrut.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresa Rut";
            // 
            // lblguardado
            // 
            this.lblguardado.AutoSize = true;
            this.lblguardado.Location = new System.Drawing.Point(110, 218);
            this.lblguardado.Name = "lblguardado";
            this.lblguardado.Size = new System.Drawing.Size(0, 13);
            this.lblguardado.TabIndex = 6;
            // 
            // cmbxnacionalidad
            // 
            this.cmbxnacionalidad.FormattingEnabled = true;
            this.cmbxnacionalidad.Items.AddRange(new object[] {
            "",
            "Chileno",
            "Argentino",
            "Otro"});
            this.cmbxnacionalidad.Location = new System.Drawing.Point(114, 61);
            this.cmbxnacionalidad.Name = "cmbxnacionalidad";
            this.cmbxnacionalidad.Size = new System.Drawing.Size(99, 21);
            this.cmbxnacionalidad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(111, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ALUMNO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxnacionalidad);
            this.Controls.Add(this.lblguardado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblguardado;
        private System.Windows.Forms.ComboBox cmbxnacionalidad;
        private System.Windows.Forms.Label label3;
    }
}

