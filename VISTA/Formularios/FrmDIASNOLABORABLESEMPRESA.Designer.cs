namespace VISTA
{
    partial class FrmDIASNOLABORABLESEMPRESA
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
            this.BtnGUARDAR = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(166, 87);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 56);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGUARDAR
            // 
            this.BtnGUARDAR.Image = global::VISTA.Properties.Resources.save_as;
            this.BtnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGUARDAR.Location = new System.Drawing.Point(54, 87);
            this.BtnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGUARDAR.Name = "BtnGUARDAR";
            this.BtnGUARDAR.Size = new System.Drawing.Size(77, 56);
            this.BtnGUARDAR.TabIndex = 10;
            this.BtnGUARDAR.Text = "Guardar";
            this.BtnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGUARDAR.UseVisualStyleBackColor = true;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(54, 53);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(216, 20);
            this.txtMotivo.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(54, 9);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(112, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha:";
            // 
            // FrmDIASNOLABORABLESEMPRESA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 154);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGUARDAR);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDIASNOLABORABLESEMPRESA";
            this.Text = "::.DÍAS NO LABORABLES EMPRESA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnGUARDAR;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}