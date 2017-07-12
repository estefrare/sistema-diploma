namespace VISTA
{
    partial class FrmSERVICIOS
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
            this.ChkBoxEstadoServicio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarServicio = new System.Windows.Forms.Button();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.MtbFechaCreacionServicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcionServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkBoxEstadoServicio
            // 
            this.ChkBoxEstadoServicio.AutoSize = true;
            this.ChkBoxEstadoServicio.Checked = true;
            this.ChkBoxEstadoServicio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBoxEstadoServicio.Location = new System.Drawing.Point(123, 193);
            this.ChkBoxEstadoServicio.Name = "ChkBoxEstadoServicio";
            this.ChkBoxEstadoServicio.Size = new System.Drawing.Size(56, 17);
            this.ChkBoxEstadoServicio.TabIndex = 40;
            this.ChkBoxEstadoServicio.Text = "Activo";
            this.ChkBoxEstadoServicio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Estado:";
            // 
            // btnCancelarServicio
            // 
            this.btnCancelarServicio.Image = global::VISTA.Properties.Resources._305_Close_32x32_72;
            this.btnCancelarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarServicio.Location = new System.Drawing.Point(261, 255);
            this.btnCancelarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarServicio.Name = "btnCancelarServicio";
            this.btnCancelarServicio.Size = new System.Drawing.Size(84, 53);
            this.btnCancelarServicio.TabIndex = 38;
            this.btnCancelarServicio.Text = "CANCELAR";
            this.btnCancelarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarServicio.UseVisualStyleBackColor = true;
            this.btnCancelarServicio.Click += new System.EventHandler(this.btnCancelarServicio_Click);
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarServicio.Location = new System.Drawing.Point(15, 255);
            this.btnGuardarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(84, 53);
            this.btnGuardarServicio.TabIndex = 37;
            this.btnGuardarServicio.Text = "GUARDAR";
            this.btnGuardarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarServicio.UseVisualStyleBackColor = true;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // MtbFechaCreacionServicio
            // 
            this.MtbFechaCreacionServicio.Location = new System.Drawing.Point(123, 152);
            this.MtbFechaCreacionServicio.Mask = "00/00/0000";
            this.MtbFechaCreacionServicio.Name = "MtbFechaCreacionServicio";
            this.MtbFechaCreacionServicio.Size = new System.Drawing.Size(70, 20);
            this.MtbFechaCreacionServicio.TabIndex = 36;
            this.MtbFechaCreacionServicio.ValidatingType = typeof(System.DateTime);
            this.MtbFechaCreacionServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtbFechaCreacionServicio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha de Creación:";
            // 
            // TxtDescripcionServicio
            // 
            this.TxtDescripcionServicio.Location = new System.Drawing.Point(123, 44);
            this.TxtDescripcionServicio.Multiline = true;
            this.TxtDescripcionServicio.Name = "TxtDescripcionServicio";
            this.TxtDescripcionServicio.Size = new System.Drawing.Size(222, 94);
            this.TxtDescripcionServicio.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descripción:";
            // 
            // TxtNombreServicio
            // 
            this.TxtNombreServicio.Location = new System.Drawing.Point(123, 6);
            this.TxtNombreServicio.Name = "TxtNombreServicio";
            this.TxtNombreServicio.Size = new System.Drawing.Size(222, 20);
            this.TxtNombreServicio.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre del Servicio:";
            // 
            // FrmSERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 316);
            this.Controls.Add(this.ChkBoxEstadoServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarServicio);
            this.Controls.Add(this.btnGuardarServicio);
            this.Controls.Add(this.MtbFechaCreacionServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDescripcionServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreServicio);
            this.Controls.Add(this.label1);
            this.Name = "FrmSERVICIOS";
            this.Text = "::.DATOS DEL SERVICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkBoxEstadoServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarServicio;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.MaskedTextBox MtbFechaCreacionServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcionServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreServicio;
        private System.Windows.Forms.Label label1;
    }
}