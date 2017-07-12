namespace VISTA
{
    partial class FrmTURNO
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGuardarTurno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre_Medico = new System.Windows.Forms.TextBox();
            this.txtMatricula_Medico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEstado_Turno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMotivo_Turno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha_Turno = new System.Windows.Forms.TextBox();
            this.lblMensaje_Ayuda = new System.Windows.Forms.Label();
            this.ucAFILIADO1 = new VISTA.ucAFILIADO();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::VISTA.Properties.Resources._305_Close_32x32_72;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(355, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "CANCELAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancelar_Turno_Click);
            // 
            // BtnGuardarTurno
            // 
            this.BtnGuardarTurno.Image = global::VISTA.Properties.Resources.save_as;
            this.BtnGuardarTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardarTurno.Location = new System.Drawing.Point(14, 387);
            this.BtnGuardarTurno.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarTurno.Name = "BtnGuardarTurno";
            this.BtnGuardarTurno.Size = new System.Drawing.Size(83, 55);
            this.BtnGuardarTurno.TabIndex = 14;
            this.BtnGuardarTurno.Text = "GUARDAR";
            this.BtnGuardarTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarTurno.UseVisualStyleBackColor = true;
            this.BtnGuardarTurno.Click += new System.EventHandler(this.btnGuardar_Turno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtNombre_Medico);
            this.groupBox1.Controls.Add(this.txtMatricula_Medico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(424, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médico";
            // 
            // txtNombre_Medico
            // 
            this.txtNombre_Medico.Location = new System.Drawing.Point(65, 60);
            this.txtNombre_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Medico.Name = "txtNombre_Medico";
            this.txtNombre_Medico.Size = new System.Drawing.Size(262, 20);
            this.txtNombre_Medico.TabIndex = 1;
            // 
            // txtMatricula_Medico
            // 
            this.txtMatricula_Medico.Location = new System.Drawing.Point(64, 27);
            this.txtMatricula_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula_Medico.Name = "txtMatricula_Medico";
            this.txtMatricula_Medico.Size = new System.Drawing.Size(116, 20);
            this.txtMatricula_Medico.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricula:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txtEstado_Turno);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtMotivo_Turno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFecha_Turno);
            this.groupBox2.Location = new System.Drawing.Point(14, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(424, 146);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno";
            // 
            // txtEstado_Turno
            // 
            this.txtEstado_Turno.Location = new System.Drawing.Point(64, 110);
            this.txtEstado_Turno.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado_Turno.Name = "txtEstado_Turno";
            this.txtEstado_Turno.Size = new System.Drawing.Size(116, 20);
            this.txtEstado_Turno.TabIndex = 6;
            this.txtEstado_Turno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_Turno_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estado:";
            // 
            // TxtMotivo_Turno
            // 
            this.TxtMotivo_Turno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMotivo_Turno.Location = new System.Drawing.Point(64, 73);
            this.TxtMotivo_Turno.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMotivo_Turno.Name = "TxtMotivo_Turno";
            this.TxtMotivo_Turno.Size = new System.Drawing.Size(345, 20);
            this.TxtMotivo_Turno.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Motivo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha:";
            // 
            // txtFecha_Turno
            // 
            this.txtFecha_Turno.Location = new System.Drawing.Point(65, 38);
            this.txtFecha_Turno.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha_Turno.Name = "txtFecha_Turno";
            this.txtFecha_Turno.Size = new System.Drawing.Size(115, 20);
            this.txtFecha_Turno.TabIndex = 1;
            // 
            // lblMensaje_Ayuda
            // 
            this.lblMensaje_Ayuda.AutoSize = true;
            this.lblMensaje_Ayuda.Location = new System.Drawing.Point(22, 504);
            this.lblMensaje_Ayuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje_Ayuda.Name = "lblMensaje_Ayuda";
            this.lblMensaje_Ayuda.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje_Ayuda.TabIndex = 17;
            // 
            // ucAFILIADO1
            // 
            this.ucAFILIADO1.AFILIADO = null;
            this.ucAFILIADO1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucAFILIADO1.Location = new System.Drawing.Point(12, 4);
            this.ucAFILIADO1.Name = "ucAFILIADO1";
            this.ucAFILIADO1.Size = new System.Drawing.Size(426, 105);
            this.ucAFILIADO1.TabIndex = 18;
            // 
            // FrmTURNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 453);
            this.Controls.Add(this.ucAFILIADO1);
            this.Controls.Add(this.lblMensaje_Ayuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGuardarTurno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmTURNO";
            this.Text = "::.NUEVO TURNO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGuardarTurno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre_Medico;
        private System.Windows.Forms.TextBox txtMatricula_Medico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEstado_Turno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMotivo_Turno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFecha_Turno;
        private System.Windows.Forms.Label lblMensaje_Ayuda;
        private ucAFILIADO ucAFILIADO1;


    }
}