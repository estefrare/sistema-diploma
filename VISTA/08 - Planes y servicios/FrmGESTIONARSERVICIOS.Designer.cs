namespace VISTA
{
    partial class FrmGESTIONARSERVICIOS
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar_Servicio = new System.Windows.Forms.Button();
            this.btnConsultar_Servicio = new System.Windows.Forms.Button();
            this.btnAgregar_Servicio = new System.Windows.Forms.Button();
            this.dgvSERVICIOS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar_Servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSERVICIOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1244, 606);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar_Servicio
            // 
            this.btnModificar_Servicio.Image = global::VISTA.Properties.Resources.user_edit;
            this.btnModificar_Servicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar_Servicio.Location = new System.Drawing.Point(96, 606);
            this.btnModificar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_Servicio.Name = "btnModificar_Servicio";
            this.btnModificar_Servicio.Size = new System.Drawing.Size(81, 54);
            this.btnModificar_Servicio.TabIndex = 22;
            this.btnModificar_Servicio.Text = "Modificar";
            this.btnModificar_Servicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar_Servicio.UseVisualStyleBackColor = true;
            this.btnModificar_Servicio.Click += new System.EventHandler(this.btnModificar_Servicio_Click);
            // 
            // btnConsultar_Servicio
            // 
            this.btnConsultar_Servicio.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultar_Servicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar_Servicio.Location = new System.Drawing.Point(181, 606);
            this.btnConsultar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_Servicio.Name = "btnConsultar_Servicio";
            this.btnConsultar_Servicio.Size = new System.Drawing.Size(81, 54);
            this.btnConsultar_Servicio.TabIndex = 21;
            this.btnConsultar_Servicio.Text = "Consultar";
            this.btnConsultar_Servicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar_Servicio.UseVisualStyleBackColor = true;
            this.btnConsultar_Servicio.Click += new System.EventHandler(this.btnConsultar_Servicio_Click);
            // 
            // btnAgregar_Servicio
            // 
            this.btnAgregar_Servicio.Image = global::VISTA.Properties.Resources.user_add;
            this.btnAgregar_Servicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Servicio.Location = new System.Drawing.Point(11, 606);
            this.btnAgregar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Servicio.Name = "btnAgregar_Servicio";
            this.btnAgregar_Servicio.Size = new System.Drawing.Size(81, 54);
            this.btnAgregar_Servicio.TabIndex = 20;
            this.btnAgregar_Servicio.Text = "Agregar";
            this.btnAgregar_Servicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Servicio.UseVisualStyleBackColor = true;
            this.btnAgregar_Servicio.Click += new System.EventHandler(this.btnAgregar_Servicio_Click);
            // 
            // dgvSERVICIOS
            // 
            this.dgvSERVICIOS.AllowUserToAddRows = false;
            this.dgvSERVICIOS.AllowUserToDeleteRows = false;
            this.dgvSERVICIOS.AllowUserToResizeColumns = false;
            this.dgvSERVICIOS.AllowUserToResizeRows = false;
            this.dgvSERVICIOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSERVICIOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSERVICIOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSERVICIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSERVICIOS.Location = new System.Drawing.Point(11, 82);
            this.dgvSERVICIOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSERVICIOS.Name = "dgvSERVICIOS";
            this.dgvSERVICIOS.ReadOnly = true;
            this.dgvSERVICIOS.RowHeadersVisible = false;
            this.dgvSERVICIOS.RowTemplate.Height = 24;
            this.dgvSERVICIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSERVICIOS.Size = new System.Drawing.Size(1314, 520);
            this.dgvSERVICIOS.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.txtBuscar_Servicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(448, 67);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // txtBuscar_Servicio
            // 
            this.txtBuscar_Servicio.Location = new System.Drawing.Point(57, 25);
            this.txtBuscar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar_Servicio.Name = "txtBuscar_Servicio";
            this.txtBuscar_Servicio.Size = new System.Drawing.Size(372, 20);
            this.txtBuscar_Servicio.TabIndex = 1;
            this.txtBuscar_Servicio.TextChanged += new System.EventHandler(this.txtBuscar_Servicio_TextChanged);
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
            // FrmGESTIONARSERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1336, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar_Servicio);
            this.Controls.Add(this.btnConsultar_Servicio);
            this.Controls.Add(this.btnAgregar_Servicio);
            this.Controls.Add(this.dgvSERVICIOS);
            this.Name = "FrmGESTIONARSERVICIOS";
            this.Text = ".:: GESTIÓN DE SERVICIOS ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSERVICIOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar_Servicio;
        private System.Windows.Forms.Button btnConsultar_Servicio;
        private System.Windows.Forms.Button btnAgregar_Servicio;
        private System.Windows.Forms.DataGridView dgvSERVICIOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar_Servicio;
        private System.Windows.Forms.Label label1;
    }
}