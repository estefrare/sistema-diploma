namespace VISTA
{
    partial class FrmMEDICO
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
            this.label8 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTiempo_Por_Paciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar_Medico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail_Medico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtTel_Medico = new System.Windows.Forms.MaskedTextBox();
            this.txtEspecialidad_Medico = new System.Windows.Forms.TextBox();
            this.mtxtDNI_Medico = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre_Medico = new System.Windows.Forms.TextBox();
            this.txtMatricula_Medico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Estado:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(101, 270);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 35;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(261, 312);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 53);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tiempo Paciente:";
            // 
            // txtTiempo_Por_Paciente
            // 
            this.txtTiempo_Por_Paciente.Location = new System.Drawing.Point(101, 225);
            this.txtTiempo_Por_Paciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempo_Por_Paciente.Name = "txtTiempo_Por_Paciente";
            this.txtTiempo_Por_Paciente.Size = new System.Drawing.Size(60, 20);
            this.txtTiempo_Por_Paciente.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // btnGuardar_Medico
            // 
            this.btnGuardar_Medico.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardar_Medico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar_Medico.Location = new System.Drawing.Point(10, 312);
            this.btnGuardar_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar_Medico.Name = "btnGuardar_Medico";
            this.btnGuardar_Medico.Size = new System.Drawing.Size(84, 53);
            this.btnGuardar_Medico.TabIndex = 36;
            this.btnGuardar_Medico.Text = "Guardar";
            this.btnGuardar_Medico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar_Medico.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Especialidad:";
            // 
            // txtEmail_Medico
            // 
            this.txtEmail_Medico.Location = new System.Drawing.Point(101, 189);
            this.txtEmail_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_Medico.Name = "txtEmail_Medico";
            this.txtEmail_Medico.Size = new System.Drawing.Size(246, 20);
            this.txtEmail_Medico.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Matricula:";
            // 
            // mtxtTel_Medico
            // 
            this.mtxtTel_Medico.Location = new System.Drawing.Point(101, 154);
            this.mtxtTel_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtTel_Medico.Mask = "0000000000000000";
            this.mtxtTel_Medico.Name = "mtxtTel_Medico";
            this.mtxtTel_Medico.Size = new System.Drawing.Size(91, 20);
            this.mtxtTel_Medico.TabIndex = 32;
            // 
            // txtEspecialidad_Medico
            // 
            this.txtEspecialidad_Medico.Location = new System.Drawing.Point(101, 118);
            this.txtEspecialidad_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtEspecialidad_Medico.Name = "txtEspecialidad_Medico";
            this.txtEspecialidad_Medico.Size = new System.Drawing.Size(246, 20);
            this.txtEspecialidad_Medico.TabIndex = 31;
            // 
            // mtxtDNI_Medico
            // 
            this.mtxtDNI_Medico.Location = new System.Drawing.Point(101, 83);
            this.mtxtDNI_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDNI_Medico.Mask = "00000000";
            this.mtxtDNI_Medico.Name = "mtxtDNI_Medico";
            this.mtxtDNI_Medico.Size = new System.Drawing.Size(60, 20);
            this.mtxtDNI_Medico.TabIndex = 30;
            // 
            // txtNombre_Medico
            // 
            this.txtNombre_Medico.Location = new System.Drawing.Point(101, 12);
            this.txtNombre_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Medico.Name = "txtNombre_Medico";
            this.txtNombre_Medico.Size = new System.Drawing.Size(246, 20);
            this.txtNombre_Medico.TabIndex = 28;
            // 
            // txtMatricula_Medico
            // 
            this.txtMatricula_Medico.Location = new System.Drawing.Point(101, 47);
            this.txtMatricula_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula_Medico.Name = "txtMatricula_Medico";
            this.txtMatricula_Medico.Size = new System.Drawing.Size(140, 20);
            this.txtMatricula_Medico.TabIndex = 29;
            // 
            // FrmMEDICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 382);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTiempo_Por_Paciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar_Medico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail_Medico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtTel_Medico);
            this.Controls.Add(this.txtEspecialidad_Medico);
            this.Controls.Add(this.mtxtDNI_Medico);
            this.Controls.Add(this.txtNombre_Medico);
            this.Controls.Add(this.txtMatricula_Medico);
            this.Name = "FrmMEDICO";
            this.Text = "::.DATOS DEL MEDICO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTiempo_Por_Paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar_Medico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail_Medico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtTel_Medico;
        private System.Windows.Forms.TextBox txtEspecialidad_Medico;
        private System.Windows.Forms.MaskedTextBox mtxtDNI_Medico;
        private System.Windows.Forms.TextBox txtNombre_Medico;
        private System.Windows.Forms.TextBox txtMatricula_Medico;
    }
}