namespace VISTA
{
    partial class FrmGESTIONARAFILIADOS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ChkInactivos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar_Afiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar_Afiliado = new System.Windows.Forms.Button();
            this.btnConsultar_Afiliado = new System.Windows.Forms.Button();
            this.btnAgregar_Afiliado = new System.Windows.Forms.Button();
            this.dgvAFILIADOS = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFILIADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.ChkInactivos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscar_Afiliado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(326, 91);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(237, 60);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ChkInactivos
            // 
            this.ChkInactivos.AutoSize = true;
            this.ChkInactivos.Checked = true;
            this.ChkInactivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkInactivos.Location = new System.Drawing.Point(63, 64);
            this.ChkInactivos.Name = "ChkInactivos";
            this.ChkInactivos.Size = new System.Drawing.Size(151, 17);
            this.ChkInactivos.TabIndex = 3;
            this.ChkInactivos.Text = "Mostrar Usuarios Inactivos";
            this.ChkInactivos.UseVisualStyleBackColor = true;
            this.ChkInactivos.CheckedChanged += new System.EventHandler(this.ChkInactivos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inactivos:";
            // 
            // txtBuscar_Afiliado
            // 
            this.txtBuscar_Afiliado.Location = new System.Drawing.Point(57, 25);
            this.txtBuscar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar_Afiliado.Name = "txtBuscar_Afiliado";
            this.txtBuscar_Afiliado.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar_Afiliado.TabIndex = 1;
            this.txtBuscar_Afiliado.TextChanged += new System.EventHandler(this.txtBuscar_Afiliado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(808, 432);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar_Afiliado
            // 
            this.btnModificar_Afiliado.Image = global::VISTA.Properties.Resources.user_edit;
            this.btnModificar_Afiliado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar_Afiliado.Location = new System.Drawing.Point(146, 432);
            this.btnModificar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_Afiliado.Name = "btnModificar_Afiliado";
            this.btnModificar_Afiliado.Size = new System.Drawing.Size(81, 54);
            this.btnModificar_Afiliado.TabIndex = 24;
            this.btnModificar_Afiliado.Text = "Modificar";
            this.btnModificar_Afiliado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar_Afiliado.UseVisualStyleBackColor = true;
            this.btnModificar_Afiliado.Click += new System.EventHandler(this.btnModificar_Afiliado_Click);
            // 
            // btnConsultar_Afiliado
            // 
            this.btnConsultar_Afiliado.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultar_Afiliado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar_Afiliado.Location = new System.Drawing.Point(280, 432);
            this.btnConsultar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_Afiliado.Name = "btnConsultar_Afiliado";
            this.btnConsultar_Afiliado.Size = new System.Drawing.Size(81, 54);
            this.btnConsultar_Afiliado.TabIndex = 23;
            this.btnConsultar_Afiliado.Text = "Consultar";
            this.btnConsultar_Afiliado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar_Afiliado.UseVisualStyleBackColor = true;
            this.btnConsultar_Afiliado.Click += new System.EventHandler(this.btnConsultar_Afiliado_Click);
            // 
            // btnAgregar_Afiliado
            // 
            this.btnAgregar_Afiliado.Image = global::VISTA.Properties.Resources.user_add;
            this.btnAgregar_Afiliado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Afiliado.Location = new System.Drawing.Point(11, 432);
            this.btnAgregar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Afiliado.Name = "btnAgregar_Afiliado";
            this.btnAgregar_Afiliado.Size = new System.Drawing.Size(81, 54);
            this.btnAgregar_Afiliado.TabIndex = 22;
            this.btnAgregar_Afiliado.Text = "Agregar";
            this.btnAgregar_Afiliado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Afiliado.UseVisualStyleBackColor = true;
            this.btnAgregar_Afiliado.Click += new System.EventHandler(this.btnAgregar_Afiliado_Click);
            // 
            // dgvAFILIADOS
            // 
            this.dgvAFILIADOS.AllowUserToAddRows = false;
            this.dgvAFILIADOS.AllowUserToDeleteRows = false;
            this.dgvAFILIADOS.AllowUserToResizeColumns = false;
            this.dgvAFILIADOS.AllowUserToResizeRows = false;
            this.dgvAFILIADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAFILIADOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAFILIADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFILIADOS.Location = new System.Drawing.Point(11, 106);
            this.dgvAFILIADOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAFILIADOS.Name = "dgvAFILIADOS";
            this.dgvAFILIADOS.ReadOnly = true;
            this.dgvAFILIADOS.RowHeadersVisible = false;
            this.dgvAFILIADOS.RowTemplate.Height = 24;
            this.dgvAFILIADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAFILIADOS.Size = new System.Drawing.Size(878, 304);
            this.dgvAFILIADOS.TabIndex = 21;
            // 
            // FrmGESTIONARAFILIADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar_Afiliado);
            this.Controls.Add(this.btnConsultar_Afiliado);
            this.Controls.Add(this.btnAgregar_Afiliado);
            this.Controls.Add(this.dgvAFILIADOS);
            this.Name = "FrmGESTIONARAFILIADOS";
            this.Text = "::.GESTIÓN DE AFILIADOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFILIADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar_Afiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar_Afiliado;
        private System.Windows.Forms.Button btnConsultar_Afiliado;
        private System.Windows.Forms.Button btnAgregar_Afiliado;
        private System.Windows.Forms.DataGridView dgvAFILIADOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.CheckBox ChkInactivos;

    }
}