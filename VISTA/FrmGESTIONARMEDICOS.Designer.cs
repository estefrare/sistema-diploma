namespace VISTA
{
    partial class FrmGESTIONARMEDICOS
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
            this.btnConfigurar_Medico = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar_Medico = new System.Windows.Forms.Button();
            this.btnConsultar_Medico = new System.Windows.Forms.Button();
            this.btnAgregar_Medico = new System.Windows.Forms.Button();
            this.dgvMEDICOS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar_Medico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMEDICOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfigurar_Medico
            // 
            this.btnConfigurar_Medico.Image = global::VISTA.Properties.Resources.cog;
            this.btnConfigurar_Medico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfigurar_Medico.Location = new System.Drawing.Point(413, 432);
            this.btnConfigurar_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigurar_Medico.Name = "btnConfigurar_Medico";
            this.btnConfigurar_Medico.Size = new System.Drawing.Size(81, 54);
            this.btnConfigurar_Medico.TabIndex = 14;
            this.btnConfigurar_Medico.Text = "Configurar";
            this.btnConfigurar_Medico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfigurar_Medico.UseVisualStyleBackColor = true;
            this.btnConfigurar_Medico.Click += new System.EventHandler(this.btnConfigurar_Medico_Click);
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
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar_Medico
            // 
            this.btnModificar_Medico.Image = global::VISTA.Properties.Resources.user_edit;
            this.btnModificar_Medico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar_Medico.Location = new System.Drawing.Point(146, 432);
            this.btnModificar_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_Medico.Name = "btnModificar_Medico";
            this.btnModificar_Medico.Size = new System.Drawing.Size(81, 54);
            this.btnModificar_Medico.TabIndex = 11;
            this.btnModificar_Medico.Text = "Modificar";
            this.btnModificar_Medico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar_Medico.UseVisualStyleBackColor = true;
            this.btnModificar_Medico.Click += new System.EventHandler(this.btnModificar_Medico_Click);
            // 
            // btnConsultar_Medico
            // 
            this.btnConsultar_Medico.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultar_Medico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar_Medico.Location = new System.Drawing.Point(280, 432);
            this.btnConsultar_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_Medico.Name = "btnConsultar_Medico";
            this.btnConsultar_Medico.Size = new System.Drawing.Size(81, 54);
            this.btnConsultar_Medico.TabIndex = 10;
            this.btnConsultar_Medico.Text = "Consultar";
            this.btnConsultar_Medico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar_Medico.UseVisualStyleBackColor = true;
            this.btnConsultar_Medico.Click += new System.EventHandler(this.btnConsultar_Medico_Click);
            // 
            // btnAgregar_Medico
            // 
            this.btnAgregar_Medico.Image = global::VISTA.Properties.Resources.user_add;
            this.btnAgregar_Medico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Medico.Location = new System.Drawing.Point(11, 432);
            this.btnAgregar_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Medico.Name = "btnAgregar_Medico";
            this.btnAgregar_Medico.Size = new System.Drawing.Size(81, 54);
            this.btnAgregar_Medico.TabIndex = 9;
            this.btnAgregar_Medico.Text = "Agregar";
            this.btnAgregar_Medico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Medico.UseVisualStyleBackColor = true;
            this.btnAgregar_Medico.Click += new System.EventHandler(this.btnAgregar_Medico_Click);
            // 
            // dgvMEDICOS
            // 
            this.dgvMEDICOS.AllowUserToAddRows = false;
            this.dgvMEDICOS.AllowUserToDeleteRows = false;
            this.dgvMEDICOS.AllowUserToResizeColumns = false;
            this.dgvMEDICOS.AllowUserToResizeRows = false;
            this.dgvMEDICOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMEDICOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMEDICOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMEDICOS.Location = new System.Drawing.Point(11, 75);
            this.dgvMEDICOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMEDICOS.Name = "dgvMEDICOS";
            this.dgvMEDICOS.ReadOnly = true;
            this.dgvMEDICOS.RowHeadersVisible = false;
            this.dgvMEDICOS.RowTemplate.Height = 24;
            this.dgvMEDICOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMEDICOS.Size = new System.Drawing.Size(878, 331);
            this.dgvMEDICOS.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.txtBuscar_Medico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(326, 63);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // txtBuscar_Medico
            // 
            this.txtBuscar_Medico.Location = new System.Drawing.Point(57, 25);
            this.txtBuscar_Medico.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar_Medico.Name = "txtBuscar_Medico";
            this.txtBuscar_Medico.Size = new System.Drawing.Size(228, 20);
            this.txtBuscar_Medico.TabIndex = 1;
            this.txtBuscar_Medico.TextChanged += new System.EventHandler(this.txtBuscar_Medico_TextChanged);
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
            // BtnInforme
            // 
            this.BtnInforme.Image = global::VISTA.Properties.Resources._005_Task_32x42_72;
            this.BtnInforme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInforme.Location = new System.Drawing.Point(547, 432);
            this.BtnInforme.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInforme.Name = "BtnInforme";
            this.BtnInforme.Size = new System.Drawing.Size(81, 54);
            this.BtnInforme.TabIndex = 21;
            this.BtnInforme.Text = "Informe";
            this.BtnInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInforme.UseVisualStyleBackColor = true;
            this.BtnInforme.Click += new System.EventHandler(this.BtnInforme_Click);
            // 
            // FrmGESTIONARMEDICOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.BtnInforme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfigurar_Medico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar_Medico);
            this.Controls.Add(this.btnConsultar_Medico);
            this.Controls.Add(this.btnAgregar_Medico);
            this.Controls.Add(this.dgvMEDICOS);
            this.Name = "FrmGESTIONARMEDICOS";
            this.Text = "::.GESTIÓN DE MEDICOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMEDICOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurar_Medico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar_Medico;
        private System.Windows.Forms.Button btnConsultar_Medico;
        private System.Windows.Forms.Button btnAgregar_Medico;
        private System.Windows.Forms.DataGridView dgvMEDICOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar_Medico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInforme;
    }
}