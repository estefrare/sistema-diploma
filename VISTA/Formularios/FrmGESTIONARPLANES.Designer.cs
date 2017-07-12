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
            this.btnModificar_Afiliado = new System.Windows.Forms.Button();
            this.btnConsultar_Afiliado = new System.Windows.Forms.Button();
            this.btnAgregar_Afiliado = new System.Windows.Forms.Button();
            this.dgvPLANES = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLANES)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(729, 258);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar_Afiliado
            // 
            this.btnModificar_Afiliado.Image = global::VISTA.Properties.Resources.user_edit;
            this.btnModificar_Afiliado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar_Afiliado.Location = new System.Drawing.Point(147, 258);
            this.btnModificar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_Afiliado.Name = "btnModificar_Afiliado";
            this.btnModificar_Afiliado.Size = new System.Drawing.Size(81, 54);
            this.btnModificar_Afiliado.TabIndex = 22;
            this.btnModificar_Afiliado.Text = "Modificar";
            this.btnModificar_Afiliado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar_Afiliado.UseVisualStyleBackColor = true;
            // 
            // btnConsultar_Afiliado
            // 
            this.btnConsultar_Afiliado.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultar_Afiliado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar_Afiliado.Location = new System.Drawing.Point(281, 258);
            this.btnConsultar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar_Afiliado.Name = "btnConsultar_Afiliado";
            this.btnConsultar_Afiliado.Size = new System.Drawing.Size(81, 54);
            this.btnConsultar_Afiliado.TabIndex = 21;
            this.btnConsultar_Afiliado.Text = "Consultar";
            this.btnConsultar_Afiliado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar_Afiliado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar_Afiliado
            // 
            this.btnAgregar_Afiliado.Image = global::VISTA.Properties.Resources.user_add;
            this.btnAgregar_Afiliado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Afiliado.Location = new System.Drawing.Point(12, 258);
            this.btnAgregar_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Afiliado.Name = "btnAgregar_Afiliado";
            this.btnAgregar_Afiliado.Size = new System.Drawing.Size(81, 54);
            this.btnAgregar_Afiliado.TabIndex = 20;
            this.btnAgregar_Afiliado.Text = "Agregar";
            this.btnAgregar_Afiliado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Afiliado.UseVisualStyleBackColor = true;
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
            this.dgvPLANES.Location = new System.Drawing.Point(11, 11);
            this.dgvPLANES.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPLANES.Name = "dgvPLANES";
            this.dgvPLANES.ReadOnly = true;
            this.dgvPLANES.RowHeadersVisible = false;
            this.dgvPLANES.RowTemplate.Height = 24;
            this.dgvPLANES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPLANES.Size = new System.Drawing.Size(799, 243);
            this.dgvPLANES.TabIndex = 19;
            // 
            // FrmGESTIONARPLANES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 324);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar_Afiliado);
            this.Controls.Add(this.btnConsultar_Afiliado);
            this.Controls.Add(this.btnAgregar_Afiliado);
            this.Controls.Add(this.dgvPLANES);
            this.Name = "FrmGESTIONARPLANES";
            this.Text = "::.GESTIÓN DE PLANES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLANES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar_Afiliado;
        private System.Windows.Forms.Button btnConsultar_Afiliado;
        private System.Windows.Forms.Button btnAgregar_Afiliado;
        private System.Windows.Forms.DataGridView dgvPLANES;
    }
}