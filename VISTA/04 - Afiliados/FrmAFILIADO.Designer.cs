namespace VISTA
{
    partial class FrmAFILIADO
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
            this.GB_FormasPago = new System.Windows.Forms.GroupBox();
            this.RbEfectivo = new System.Windows.Forms.RadioButton();
            this.RbDebitoAutomatico = new System.Windows.Forms.RadioButton();
            this.ChkEstado = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtContrato_Afiliado = new System.Windows.Forms.TextBox();
            this.Txtsexo_Afiliado = new System.Windows.Forms.TextBox();
            this.txtEmail_Afiliado = new System.Windows.Forms.TextBox();
            this.txtDirecion_Afiliado = new System.Windows.Forms.TextBox();
            this.txtNombre_Afiliado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBPlanes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtbFecha_Nacimiento = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar_AFILIADO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtTel_Afiliado = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDNI_Afiliado = new System.Windows.Forms.MaskedTextBox();
            this.gbTarjeta = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mtbVencimientoTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.GB_FormasPago.SuspendLayout();
            this.gbTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_FormasPago
            // 
            this.GB_FormasPago.Controls.Add(this.RbEfectivo);
            this.GB_FormasPago.Controls.Add(this.RbDebitoAutomatico);
            this.GB_FormasPago.Location = new System.Drawing.Point(90, 248);
            this.GB_FormasPago.Name = "GB_FormasPago";
            this.GB_FormasPago.Size = new System.Drawing.Size(246, 32);
            this.GB_FormasPago.TabIndex = 54;
            this.GB_FormasPago.TabStop = false;
            // 
            // RbEfectivo
            // 
            this.RbEfectivo.AutoSize = true;
            this.RbEfectivo.Checked = true;
            this.RbEfectivo.Location = new System.Drawing.Point(27, 10);
            this.RbEfectivo.Name = "RbEfectivo";
            this.RbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.RbEfectivo.TabIndex = 53;
            this.RbEfectivo.TabStop = true;
            this.RbEfectivo.Text = "Efectivo";
            this.RbEfectivo.UseVisualStyleBackColor = true;
            this.RbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivo_CheckedChanged);
            // 
            // RbDebitoAutomatico
            // 
            this.RbDebitoAutomatico.AutoSize = true;
            this.RbDebitoAutomatico.Location = new System.Drawing.Point(115, 10);
            this.RbDebitoAutomatico.Name = "RbDebitoAutomatico";
            this.RbDebitoAutomatico.Size = new System.Drawing.Size(112, 17);
            this.RbDebitoAutomatico.TabIndex = 53;
            this.RbDebitoAutomatico.Text = "Debito Automático";
            this.RbDebitoAutomatico.UseVisualStyleBackColor = true;
            this.RbDebitoAutomatico.CheckedChanged += new System.EventHandler(this.RbDebitoAutomatico_CheckedChanged);
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Checked = true;
            this.ChkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkEstado.Location = new System.Drawing.Point(90, 414);
            this.ChkEstado.Margin = new System.Windows.Forms.Padding(2);
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Size = new System.Drawing.Size(56, 17);
            this.ChkEstado.TabIndex = 13;
            this.ChkEstado.Text = "Activo";
            this.ChkEstado.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 415);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 260);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Forma Pago:";
            // 
            // TxtContrato_Afiliado
            // 
            this.TxtContrato_Afiliado.Location = new System.Drawing.Point(90, 27);
            this.TxtContrato_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContrato_Afiliado.Name = "TxtContrato_Afiliado";
            this.TxtContrato_Afiliado.Size = new System.Drawing.Size(102, 20);
            this.TxtContrato_Afiliado.TabIndex = 1;
            // 
            // Txtsexo_Afiliado
            // 
            this.Txtsexo_Afiliado.Location = new System.Drawing.Point(89, 123);
            this.Txtsexo_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.Txtsexo_Afiliado.Name = "Txtsexo_Afiliado";
            this.Txtsexo_Afiliado.Size = new System.Drawing.Size(246, 20);
            this.Txtsexo_Afiliado.TabIndex = 7;
            // 
            // txtEmail_Afiliado
            // 
            this.txtEmail_Afiliado.Location = new System.Drawing.Point(89, 196);
            this.txtEmail_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_Afiliado.Name = "txtEmail_Afiliado";
            this.txtEmail_Afiliado.Size = new System.Drawing.Size(246, 20);
            this.txtEmail_Afiliado.TabIndex = 10;
            // 
            // txtDirecion_Afiliado
            // 
            this.txtDirecion_Afiliado.Location = new System.Drawing.Point(89, 148);
            this.txtDirecion_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirecion_Afiliado.Name = "txtDirecion_Afiliado";
            this.txtDirecion_Afiliado.Size = new System.Drawing.Size(246, 20);
            this.txtDirecion_Afiliado.TabIndex = 8;
            // 
            // txtNombre_Afiliado
            // 
            this.txtNombre_Afiliado.Location = new System.Drawing.Point(89, 51);
            this.txtNombre_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Afiliado.Name = "txtNombre_Afiliado";
            this.txtNombre_Afiliado.Size = new System.Drawing.Size(246, 20);
            this.txtNombre_Afiliado.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Contrato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "F_Nacimiento:";
            // 
            // CBPlanes
            // 
            this.CBPlanes.FormattingEnabled = true;
            this.CBPlanes.Location = new System.Drawing.Point(90, 221);
            this.CBPlanes.Name = "CBPlanes";
            this.CBPlanes.Size = new System.Drawing.Size(121, 21);
            this.CBPlanes.TabIndex = 11;
            this.CBPlanes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CBPlanes_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Plan:";
            // 
            // MtbFecha_Nacimiento
            // 
            this.MtbFecha_Nacimiento.Location = new System.Drawing.Point(89, 99);
            this.MtbFecha_Nacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.MtbFecha_Nacimiento.Mask = "00/00/0000";
            this.MtbFecha_Nacimiento.Name = "MtbFecha_Nacimiento";
            this.MtbFecha_Nacimiento.Size = new System.Drawing.Size(68, 20);
            this.MtbFecha_Nacimiento.TabIndex = 6;
            this.MtbFecha_Nacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources._305_Close_32x32_72;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(189, 457);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 53);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // btnGuardar_AFILIADO
            // 
            this.btnGuardar_AFILIADO.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardar_AFILIADO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar_AFILIADO.Location = new System.Drawing.Point(86, 457);
            this.btnGuardar_AFILIADO.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar_AFILIADO.Name = "btnGuardar_AFILIADO";
            this.btnGuardar_AFILIADO.Size = new System.Drawing.Size(84, 53);
            this.btnGuardar_AFILIADO.TabIndex = 14;
            this.btnGuardar_AFILIADO.Text = "GUARDAR";
            this.btnGuardar_AFILIADO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar_AFILIADO.UseVisualStyleBackColor = true;
            this.btnGuardar_AFILIADO.Click += new System.EventHandler(this.btnGuardar_AFILIADO_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefono:";
            // 
            // mtxtTel_Afiliado
            // 
            this.mtxtTel_Afiliado.Location = new System.Drawing.Point(90, 172);
            this.mtxtTel_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtTel_Afiliado.Mask = "0000000000000000";
            this.mtxtTel_Afiliado.Name = "mtxtTel_Afiliado";
            this.mtxtTel_Afiliado.Size = new System.Drawing.Size(91, 20);
            this.mtxtTel_Afiliado.TabIndex = 9;
            // 
            // mtxtDNI_Afiliado
            // 
            this.mtxtDNI_Afiliado.Location = new System.Drawing.Point(89, 75);
            this.mtxtDNI_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDNI_Afiliado.Mask = "00000000";
            this.mtxtDNI_Afiliado.Name = "mtxtDNI_Afiliado";
            this.mtxtDNI_Afiliado.Size = new System.Drawing.Size(60, 20);
            this.mtxtDNI_Afiliado.TabIndex = 5;
            // 
            // gbTarjeta
            // 
            this.gbTarjeta.Controls.Add(this.label15);
            this.gbTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.gbTarjeta.Controls.Add(this.label14);
            this.gbTarjeta.Controls.Add(this.mtbVencimientoTarjeta);
            this.gbTarjeta.Enabled = false;
            this.gbTarjeta.Location = new System.Drawing.Point(21, 286);
            this.gbTarjeta.Name = "gbTarjeta";
            this.gbTarjeta.Size = new System.Drawing.Size(315, 93);
            this.gbTarjeta.TabIndex = 54;
            this.gbTarjeta.TabStop = false;
            this.gbTarjeta.Text = "Datos de la tarjeta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Vencimiento:";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(69, 28);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(234, 20);
            this.txtNumeroTarjeta.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Número:";
            // 
            // mtbVencimientoTarjeta
            // 
            this.mtbVencimientoTarjeta.Location = new System.Drawing.Point(87, 52);
            this.mtbVencimientoTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.mtbVencimientoTarjeta.Mask = "00/0000";
            this.mtbVencimientoTarjeta.Name = "mtbVencimientoTarjeta";
            this.mtbVencimientoTarjeta.Size = new System.Drawing.Size(68, 20);
            this.mtbVencimientoTarjeta.TabIndex = 6;
            // 
            // FrmAFILIADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 533);
            this.Controls.Add(this.gbTarjeta);
            this.Controls.Add(this.GB_FormasPago);
            this.Controls.Add(this.ChkEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtxtDNI_Afiliado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtxtTel_Afiliado);
            this.Controls.Add(this.TxtContrato_Afiliado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtsexo_Afiliado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail_Afiliado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDirecion_Afiliado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre_Afiliado);
            this.Controls.Add(this.btnGuardar_AFILIADO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBPlanes);
            this.Controls.Add(this.MtbFecha_Nacimiento);
            this.Controls.Add(this.label1);
            this.Name = "FrmAFILIADO";
            this.Text = ".:: DATOS DEL AFILIADO ::.";
            this.Load += new System.EventHandler(this.FrmAFILIADO_Load);
            this.GB_FormasPago.ResumeLayout(false);
            this.GB_FormasPago.PerformLayout();
            this.gbTarjeta.ResumeLayout(false);
            this.gbTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ChkEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtContrato_Afiliado;
        private System.Windows.Forms.TextBox Txtsexo_Afiliado;
        private System.Windows.Forms.TextBox txtEmail_Afiliado;
        private System.Windows.Forms.TextBox txtDirecion_Afiliado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtbFecha_Nacimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar_AFILIADO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtTel_Afiliado;
        private System.Windows.Forms.MaskedTextBox mtxtDNI_Afiliado;
        private System.Windows.Forms.TextBox txtNombre_Afiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbDebitoAutomatico;
        private System.Windows.Forms.RadioButton RbEfectivo;
        private System.Windows.Forms.GroupBox GB_FormasPago;
        private System.Windows.Forms.GroupBox gbTarjeta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtbVencimientoTarjeta;
    }
}