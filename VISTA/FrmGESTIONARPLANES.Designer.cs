namespace VISTA
{
    partial class FrmGESTIONARPLANES
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
            this.btnModificar_Planes = new System.Windows.Forms.Button();
            this.btnConsultar_Planes = new System.Windows.Forms.Button();
            this.btnAgregar_Planes = new System.Windows.Forms.Button();
            this.dgvPLANES = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar_Plan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLANES)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(807, 432);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar_Planes
            // 
            this.btnModificar_Planes.Image = global::VISTA.Properties.Resources.user_edit;
            this.btnModificar_Planes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar_Planes.Location = new System.Drawing.Point(146, 432);
            this.btnModificar_Planes.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_Planes.Name = "btnModificar_Planes";
            this.btnModificar_Planes.Size = new System.Drawing.Size(81, 54);
            this.btnModificar_Planes.TabIndex = 22;
            this.btnModificar_Planes.Text = "Modificar";
            this.btnModificar_Planes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar_Planes.UseVisualStyleBackColor = true;
            this.btnModificar_Planes.Click += new System.EventHandler(this.btnModificar_Planes_Click);
            // 
            // btnConsultar_Planes
            // 
            this.btnConsultar_Planes.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultar_Planes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar_Planes.Location = new System.Drawing.Point(280, 432);
            this.btnConsultar_Planes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_Planes.Name = "btnConsultar_Planes";
            this.btnConsultar_Planes.Size = new System.Drawing.Size(81, 54);
            this.btnConsultar_Planes.TabIndex = 21;
            this.btnConsultar_Planes.Text = "Consultar";
            this.btnConsultar_Planes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar_Planes.UseVisualStyleBackColor = true;
            this.btnConsultar_Planes.Click += new System.EventHandler(this.btnConsultar_Planes_Click);
            // 
            // btnAgregar_Planes
            // 
            this.btnAgregar_Planes.Image = global::VISTA.Properties.Resources.user_add;
            this.btnAgregar_Planes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Planes.Location = new System.Drawing.Point(11, 432);
            this.btnAgregar_Planes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Planes.Name = "btnAgregar_Planes";
            this.btnAgregar_Planes.Size = new System.Drawing.Size(81, 54);
            this.btnAgregar_Planes.TabIndex = 20;
            this.btnAgregar_Planes.Text = "Agregar";
            this.btnAgregar_Planes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Planes.UseVisualStyleBackColor = true;
            this.btnAgregar_Planes.Click += new System.EventHandler(this.btnAgregar_Planes_Click);
            // 
            // dgvPLANES
            // 
            this.dgvPLANES.AllowUserToAddRows = false;
            this.dgvPLANES.AllowUserToDeleteRows = false;
            this.dgvPLANES.AllowUserToResizeColumns = false;
            this.dgvPLANES.AllowUserToResizeRows = false;
            this.dgvPLANES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPLANES.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPLANES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPLANES.Location = new System.Drawing.Point(11, 82);
            this.dgvPLANES.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPLANES.Name = "dgvPLANES";
            this.dgvPLANES.ReadOnly = true;
            this.dgvPLANES.RowHeadersVisible = false;
            this.dgvPLANES.RowTemplate.Height = 24;
            this.dgvPLANES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPLANES.Size = new System.Drawing.Size(877, 346);
            this.dgvPLANES.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.txtBuscar_Plan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(326, 67);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // txtBuscar_Plan
            // 
            this.txtBuscar_Plan.Location = new System.Drawing.Point(57, 25);
            this.txtBuscar_Plan.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar_Plan.Name = "txtBuscar_Plan";
            this.txtBuscar_Plan.Size = new System.Drawing.Size(250, 20);
            this.txtBuscar_Plan.TabIndex = 1;
            this.txtBuscar_Plan.TextChanged += new System.EventHandler(this.txtBuscar_Plan_TextChanged);
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
            // FrmGESTIONARPLANES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar_Planes);
            this.Controls.Add(this.btnConsultar_Planes);
            this.Controls.Add(this.btnAgregar_Planes);
            this.Controls.Add(this.dgvPLANES);
            this.Name = "FrmGESTIONARPLANES";
            this.Text = "::.GESTIÓN DE PLANES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLANES)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar_Planes;
        private System.Windows.Forms.Button btnConsultar_Planes;
        private System.Windows.Forms.Button btnAgregar_Planes;
        private System.Windows.Forms.DataGridView dgvPLANES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar_Plan;
        private System.Windows.Forms.Label label1;
    }
}