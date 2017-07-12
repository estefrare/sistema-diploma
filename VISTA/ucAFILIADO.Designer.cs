namespace VISTA
{
    partial class ucAFILIADO
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre_Afiliado = new System.Windows.Forms.TextBox();
            this.txtDNI_Afiliado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre_Afiliado
            // 
            this.txtNombre_Afiliado.Location = new System.Drawing.Point(56, 77);
            this.txtNombre_Afiliado.Name = "txtNombre_Afiliado";
            this.txtNombre_Afiliado.Size = new System.Drawing.Size(236, 20);
            this.txtNombre_Afiliado.TabIndex = 2;
            // 
            // txtDNI_Afiliado
            // 
            this.txtDNI_Afiliado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDNI_Afiliado.Location = new System.Drawing.Point(56, 33);
            this.txtDNI_Afiliado.Name = "txtDNI_Afiliado";
            this.txtDNI_Afiliado.Size = new System.Drawing.Size(130, 20);
            this.txtDNI_Afiliado.TabIndex = 3;
            this.txtDNI_Afiliado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_Afiliado_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Afiliado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(53, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Haga click en el recuadro y pulse F5 para buscar";
            // 
            // ucAFILIADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDNI_Afiliado);
            this.Controls.Add(this.txtNombre_Afiliado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucAFILIADO";
            this.Size = new System.Drawing.Size(317, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre_Afiliado;
        private System.Windows.Forms.TextBox txtDNI_Afiliado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
