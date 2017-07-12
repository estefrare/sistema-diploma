namespace VISTA.Parametros
{
    partial class frmPARAMETROS_EQUIPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPARAMETROS_EQUIPO));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.pDATOS = new System.Windows.Forms.Panel();
            this.btnBUSCAR_DIRECTORIO = new System.Windows.Forms.Button();
            this.txtEQUIPO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDIRECTORIO_IMAGENES = new System.Windows.Forms.TextBox();
            this.gbPARAMETROS_MAIL = new System.Windows.Forms.GroupBox();
            this.txtMAIL_CLAVE = new System.Windows.Forms.TextBox();
            this.txtMAIL_CUENTA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkENVIO_MAILS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pDATOS.SuspendLayout();
            this.gbPARAMETROS_MAIL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(529, 271);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(101, 62);
            this.btnCANCELAR.TabIndex = 4;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(417, 271);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(107, 62);
            this.btnGUARDAR.TabIndex = 3;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // pDATOS
            // 
            this.pDATOS.Controls.Add(this.btnBUSCAR_DIRECTORIO);
            this.pDATOS.Controls.Add(this.txtEQUIPO);
            this.pDATOS.Controls.Add(this.label8);
            this.pDATOS.Controls.Add(this.txtDIRECTORIO_IMAGENES);
            this.pDATOS.Controls.Add(this.gbPARAMETROS_MAIL);
            this.pDATOS.Controls.Add(this.chkENVIO_MAILS);
            this.pDATOS.Controls.Add(this.label2);
            this.pDATOS.Controls.Add(this.label1);
            this.pDATOS.Location = new System.Drawing.Point(11, 7);
            this.pDATOS.Name = "pDATOS";
            this.pDATOS.Size = new System.Drawing.Size(619, 245);
            this.pDATOS.TabIndex = 5;
            // 
            // btnBUSCAR_DIRECTORIO
            // 
            this.btnBUSCAR_DIRECTORIO.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR_DIRECTORIO.Image")));
            this.btnBUSCAR_DIRECTORIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBUSCAR_DIRECTORIO.Location = new System.Drawing.Point(473, 15);
            this.btnBUSCAR_DIRECTORIO.Name = "btnBUSCAR_DIRECTORIO";
            this.btnBUSCAR_DIRECTORIO.Size = new System.Drawing.Size(83, 52);
            this.btnBUSCAR_DIRECTORIO.TabIndex = 13;
            this.btnBUSCAR_DIRECTORIO.Text = "Buscar";
            this.btnBUSCAR_DIRECTORIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR_DIRECTORIO.UseVisualStyleBackColor = true;
            this.btnBUSCAR_DIRECTORIO.Click += new System.EventHandler(this.btnBUSCAR_DIRECTORIO_Click);
            // 
            // txtEQUIPO
            // 
            this.txtEQUIPO.Location = new System.Drawing.Point(127, 15);
            this.txtEQUIPO.Name = "txtEQUIPO";
            this.txtEQUIPO.ReadOnly = true;
            this.txtEQUIPO.Size = new System.Drawing.Size(340, 20);
            this.txtEQUIPO.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Equipo:";
            // 
            // txtDIRECTORIO_IMAGENES
            // 
            this.txtDIRECTORIO_IMAGENES.Location = new System.Drawing.Point(127, 44);
            this.txtDIRECTORIO_IMAGENES.Name = "txtDIRECTORIO_IMAGENES";
            this.txtDIRECTORIO_IMAGENES.ReadOnly = true;
            this.txtDIRECTORIO_IMAGENES.Size = new System.Drawing.Size(340, 20);
            this.txtDIRECTORIO_IMAGENES.TabIndex = 10;
            // 
            // gbPARAMETROS_MAIL
            // 
            this.gbPARAMETROS_MAIL.Controls.Add(this.txtMAIL_CLAVE);
            this.gbPARAMETROS_MAIL.Controls.Add(this.txtMAIL_CUENTA);
            this.gbPARAMETROS_MAIL.Controls.Add(this.label6);
            this.gbPARAMETROS_MAIL.Controls.Add(this.label5);
            this.gbPARAMETROS_MAIL.Location = new System.Drawing.Point(24, 95);
            this.gbPARAMETROS_MAIL.Name = "gbPARAMETROS_MAIL";
            this.gbPARAMETROS_MAIL.Size = new System.Drawing.Size(555, 106);
            this.gbPARAMETROS_MAIL.TabIndex = 3;
            this.gbPARAMETROS_MAIL.TabStop = false;
            this.gbPARAMETROS_MAIL.Text = "Configuración de cuenta de correo electrónico";
            // 
            // txtMAIL_CLAVE
            // 
            this.txtMAIL_CLAVE.Location = new System.Drawing.Point(132, 58);
            this.txtMAIL_CLAVE.Name = "txtMAIL_CLAVE";
            this.txtMAIL_CLAVE.PasswordChar = '*';
            this.txtMAIL_CLAVE.Size = new System.Drawing.Size(340, 20);
            this.txtMAIL_CLAVE.TabIndex = 8;
            this.txtMAIL_CLAVE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMAIL_CLAVE_KeyPress);
            // 
            // txtMAIL_CUENTA
            // 
            this.txtMAIL_CUENTA.Location = new System.Drawing.Point(132, 30);
            this.txtMAIL_CUENTA.Name = "txtMAIL_CUENTA";
            this.txtMAIL_CUENTA.Size = new System.Drawing.Size(340, 20);
            this.txtMAIL_CUENTA.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Clave de correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cuenta de correo:";
            // 
            // chkENVIO_MAILS
            // 
            this.chkENVIO_MAILS.AutoSize = true;
            this.chkENVIO_MAILS.Location = new System.Drawing.Point(104, 74);
            this.chkENVIO_MAILS.Name = "chkENVIO_MAILS";
            this.chkENVIO_MAILS.Size = new System.Drawing.Size(64, 17);
            this.chkENVIO_MAILS.TabIndex = 2;
            this.chkENVIO_MAILS.Text = "Habilitar";
            this.chkENVIO_MAILS.UseVisualStyleBackColor = true;
            this.chkENVIO_MAILS.CheckedChanged += new System.EventHandler(this.chkENVIO_MAILS_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Envío de mails:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directorio imágenes:";
            // 
            // frmPARAMETROS_EQUIPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 350);
            this.Controls.Add(this.pDATOS);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPARAMETROS_EQUIPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: PARAMETROS DEL EQUIPO ::.";
            this.TopMost = true;
            this.pDATOS.ResumeLayout(false);
            this.pDATOS.PerformLayout();
            this.gbPARAMETROS_MAIL.ResumeLayout(false);
            this.gbPARAMETROS_MAIL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Panel pDATOS;
        private System.Windows.Forms.Button btnBUSCAR_DIRECTORIO;
        private System.Windows.Forms.TextBox txtEQUIPO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDIRECTORIO_IMAGENES;
        private System.Windows.Forms.GroupBox gbPARAMETROS_MAIL;
        private System.Windows.Forms.TextBox txtMAIL_CLAVE;
        private System.Windows.Forms.TextBox txtMAIL_CUENTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkENVIO_MAILS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}