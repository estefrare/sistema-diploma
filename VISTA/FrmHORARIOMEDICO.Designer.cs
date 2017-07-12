namespace VISTA
{
    partial class FrmHORARIOMEDICO
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
            this.mtxtHoraFin = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar_Horario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtHoraFin
            // 
            this.mtxtHoraFin.Location = new System.Drawing.Point(76, 80);
            this.mtxtHoraFin.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtHoraFin.Mask = "00:00";
            this.mtxtHoraFin.Name = "mtxtHoraFin";
            this.mtxtHoraFin.Size = new System.Drawing.Size(41, 20);
            this.mtxtHoraFin.TabIndex = 15;
            this.mtxtHoraFin.ValidatingType = typeof(System.DateTime);
            this.mtxtHoraFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtHoraFin_KeyPress_1);
            this.mtxtHoraFin.Leave += new System.EventHandler(this.mtxtHoraFin_Leave);
            // 
            // mtxtHoraInicio
            // 
            this.mtxtHoraInicio.Location = new System.Drawing.Point(76, 48);
            this.mtxtHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtHoraInicio.Mask = "00:00";
            this.mtxtHoraInicio.Name = "mtxtHoraInicio";
            this.mtxtHoraInicio.Size = new System.Drawing.Size(41, 20);
            this.mtxtHoraInicio.TabIndex = 14;
            this.mtxtHoraInicio.ValidatingType = typeof(System.DateTime);
            this.mtxtHoraInicio.Leave += new System.EventHandler(this.mtxtHoraInicio_Leave);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(76, 17);
            this.txtDia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(153, 20);
            this.txtDia.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(157, 115);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 51);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar_Horario
            // 
            this.btnGuardar_Horario.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardar_Horario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar_Horario.Location = new System.Drawing.Point(23, 115);
            this.btnGuardar_Horario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar_Horario.Name = "btnGuardar_Horario";
            this.btnGuardar_Horario.Size = new System.Drawing.Size(71, 51);
            this.btnGuardar_Horario.TabIndex = 11;
            this.btnGuardar_Horario.Text = "Guardar";
            this.btnGuardar_Horario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar_Horario.UseVisualStyleBackColor = true;
            this.btnGuardar_Horario.Click += new System.EventHandler(this.btnGuardar_Horario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Día:";
            // 
            // FrmHORARIOMEDICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 178);
            this.Controls.Add(this.mtxtHoraFin);
            this.Controls.Add(this.mtxtHoraInicio);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar_Horario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHORARIOMEDICO";
            this.Text = "::.HORARIOS DE LOS MEDICOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtHoraFin;
        private System.Windows.Forms.MaskedTextBox mtxtHoraInicio;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar_Horario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}