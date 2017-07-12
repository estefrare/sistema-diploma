namespace VISTA
{
    partial class FrmDIAEMPRESA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mtxtHora_Fin = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHora_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(120, 124);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 55);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(18, 124);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 55);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // mtxtHora_Fin
            // 
            this.mtxtHora_Fin.Location = new System.Drawing.Point(71, 81);
            this.mtxtHora_Fin.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtHora_Fin.Mask = "00:00";
            this.mtxtHora_Fin.Name = "mtxtHora_Fin";
            this.mtxtHora_Fin.Size = new System.Drawing.Size(48, 20);
            this.mtxtHora_Fin.TabIndex = 13;
            this.mtxtHora_Fin.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHora_Inicio
            // 
            this.mtxtHora_Inicio.Location = new System.Drawing.Point(71, 47);
            this.mtxtHora_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtHora_Inicio.Mask = "00:00";
            this.mtxtHora_Inicio.Name = "mtxtHora_Inicio";
            this.mtxtHora_Inicio.Size = new System.Drawing.Size(48, 20);
            this.mtxtHora_Inicio.TabIndex = 12;
            this.mtxtHora_Inicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(71, 9);
            this.txtDia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(159, 20);
            this.txtDia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Día:";
            // 
            // FrmDIAEMPRESA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(243, 182);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtxtHora_Fin);
            this.Controls.Add(this.mtxtHora_Inicio);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDIAEMPRESA";
            this.Text = "FrmDIAEMPRESA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox mtxtHora_Fin;
        private System.Windows.Forms.MaskedTextBox mtxtHora_Inicio;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}