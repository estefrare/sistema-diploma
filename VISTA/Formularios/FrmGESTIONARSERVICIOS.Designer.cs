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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar_Servicio = new System.Windows.Forms.Button();
            this.btnConsultar_Servicio = new System.Windows.Forms.Button();
            this.btnAgregar_Servicio = new System.Windows.Forms.Button();
            this.dgvSERVICIOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSERVICIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = global::VISTA.Properties.Resources.cog;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(427, 338);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(81, 54);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(811, 338);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar_Servicio
            // 
            this.btnModificar_Servicio.Image = global::VISTA.Properties.Resources.user_edit;
            this.btnModificar_Servicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar_Servicio.Location = new System.Drawing.Point(146, 338);
            this.btnModificar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_Servicio.Name = "btnModificar_Servicio";
            this.btnModificar_Servicio.Size = new System.Drawing.Size(81, 54);
            this.btnModificar_Servicio.TabIndex = 22;
            this.btnModificar_Servicio.Text = "Modificar";
            this.btnModificar_Servicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar_Servicio.UseVisualStyleBackColor = true;
            // 
            // btnConsultar_Servicio
            // 
            this.btnConsultar_Servicio.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultar_Servicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar_Servicio.Location = new System.Drawing.Point(280, 338);
            this.btnConsultar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_Servicio.Name = "btnConsultar_Servicio";
            this.btnConsultar_Servicio.Size = new System.Drawing.Size(81, 54);
            this.btnConsultar_Servicio.TabIndex = 21;
            this.btnConsultar_Servicio.Text = "Consultar";
            this.btnConsultar_Servicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar_Servicio.UseVisualStyleBackColor = true;
            // 
            // btnAgregar_Servicio
            // 
            this.btnAgregar_Servicio.Image = global::VISTA.Properties.Resources.user_add;
            this.btnAgregar_Servicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Servicio.Location = new System.Drawing.Point(11, 338);
            this.btnAgregar_Servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Servicio.Name = "btnAgregar_Servicio";
            this.btnAgregar_Servicio.Size = new System.Drawing.Size(81, 54);
            this.btnAgregar_Servicio.TabIndex = 20;
            this.btnAgregar_Servicio.Text = "Agregar";
            this.btnAgregar_Servicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Servicio.UseVisualStyleBackColor = true;
            // 
            // dgvSERVICIOS
            // 
            this.dgvSERVICIOS.AllowUserToAddRows = false;
            this.dgvSERVICIOS.AllowUserToDeleteRows = false;
            this.dgvSERVICIOS.AllowUserToResizeColumns = false;
            this.dgvSERVICIOS.AllowUserToResizeRows = false;
            this.dgvSERVICIOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSERVICIOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSERVICIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSERVICIOS.Location = new System.Drawing.Point(11, 11);
            this.dgvSERVICIOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSERVICIOS.Name = "dgvSERVICIOS";
            this.dgvSERVICIOS.ReadOnly = true;
            this.dgvSERVICIOS.RowHeadersVisible = false;
            this.dgvSERVICIOS.RowTemplate.Height = 24;
            this.dgvSERVICIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSERVICIOS.Size = new System.Drawing.Size(881, 323);
            this.dgvSERVICIOS.TabIndex = 19;
            // 
            // FrmGESTIONARSERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 403);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar_Servicio);
            this.Controls.Add(this.btnConsultar_Servicio);
            this.Controls.Add(this.btnAgregar_Servicio);
            this.Controls.Add(this.dgvSERVICIOS);
            this.Name = "FrmGESTIONARSERVICIOS";
            this.Text = "::.GESTIÓN DE SERVICIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSERVICIOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar_Servicio;
        private System.Windows.Forms.Button btnConsultar_Servicio;
        private System.Windows.Forms.Button btnAgregar_Servicio;
        private System.Windows.Forms.DataGridView dgvSERVICIOS;
    }
}