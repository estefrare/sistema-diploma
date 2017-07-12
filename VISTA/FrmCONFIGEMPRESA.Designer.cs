namespace VISTA
{
    partial class FrmCONFIGEMPRESA
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
            this.dgvDiasNoLaborablesEmp = new System.Windows.Forms.GroupBox();
            this.btnEliminarDiaNoLaborable = new System.Windows.Forms.Button();
            this.btnAgregarDiaNoLaborable = new System.Windows.Forms.Button();
            this.dgvDiasNoLab = new System.Windows.Forms.DataGridView();
            this.gbDias_Empresa = new System.Windows.Forms.GroupBox();
            this.btnEliminarDiaLaborable = new System.Windows.Forms.Button();
            this.AgregarDiaLaborable = new System.Windows.Forms.Button();
            this.dgvDias_Empresa = new System.Windows.Forms.DataGridView();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.gbDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiasNoLaborablesEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasNoLab)).BeginInit();
            this.gbDias_Empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDias_Empresa)).BeginInit();
            this.gbDatosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiasNoLaborablesEmp
            // 
            this.dgvDiasNoLaborablesEmp.Controls.Add(this.btnEliminarDiaNoLaborable);
            this.dgvDiasNoLaborablesEmp.Controls.Add(this.btnAgregarDiaNoLaborable);
            this.dgvDiasNoLaborablesEmp.Controls.Add(this.dgvDiasNoLab);
            this.dgvDiasNoLaborablesEmp.Location = new System.Drawing.Point(11, 413);
            this.dgvDiasNoLaborablesEmp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiasNoLaborablesEmp.Name = "dgvDiasNoLaborablesEmp";
            this.dgvDiasNoLaborablesEmp.Padding = new System.Windows.Forms.Padding(2);
            this.dgvDiasNoLaborablesEmp.Size = new System.Drawing.Size(518, 254);
            this.dgvDiasNoLaborablesEmp.TabIndex = 13;
            this.dgvDiasNoLaborablesEmp.TabStop = false;
            this.dgvDiasNoLaborablesEmp.Text = "DÍAS NO LABORABLES EMPRESA";
            // 
            // btnEliminarDiaNoLaborable
            // 
            this.btnEliminarDiaNoLaborable.Image = global::VISTA.Properties.Resources.date_delete;
            this.btnEliminarDiaNoLaborable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarDiaNoLaborable.Location = new System.Drawing.Point(107, 197);
            this.btnEliminarDiaNoLaborable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarDiaNoLaborable.Name = "btnEliminarDiaNoLaborable";
            this.btnEliminarDiaNoLaborable.Size = new System.Drawing.Size(70, 52);
            this.btnEliminarDiaNoLaborable.TabIndex = 9;
            this.btnEliminarDiaNoLaborable.Text = "Eliminar";
            this.btnEliminarDiaNoLaborable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarDiaNoLaborable.UseVisualStyleBackColor = true;
            this.btnEliminarDiaNoLaborable.Click += new System.EventHandler(this.btnEliminarDiaNoLaborable_Click);
            // 
            // btnAgregarDiaNoLaborable
            // 
            this.btnAgregarDiaNoLaborable.Image = global::VISTA.Properties.Resources.date_add;
            this.btnAgregarDiaNoLaborable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarDiaNoLaborable.Location = new System.Drawing.Point(5, 197);
            this.btnAgregarDiaNoLaborable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDiaNoLaborable.Name = "btnAgregarDiaNoLaborable";
            this.btnAgregarDiaNoLaborable.Size = new System.Drawing.Size(70, 52);
            this.btnAgregarDiaNoLaborable.TabIndex = 8;
            this.btnAgregarDiaNoLaborable.Text = "Agregar";
            this.btnAgregarDiaNoLaborable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarDiaNoLaborable.UseVisualStyleBackColor = true;
            this.btnAgregarDiaNoLaborable.Click += new System.EventHandler(this.btnAgregarDiaNoLaborable_Click);
            // 
            // dgvDiasNoLab
            // 
            this.dgvDiasNoLab.AllowUserToAddRows = false;
            this.dgvDiasNoLab.AllowUserToDeleteRows = false;
            this.dgvDiasNoLab.AllowUserToResizeColumns = false;
            this.dgvDiasNoLab.AllowUserToResizeRows = false;
            this.dgvDiasNoLab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiasNoLab.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDiasNoLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiasNoLab.Location = new System.Drawing.Point(5, 17);
            this.dgvDiasNoLab.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiasNoLab.Name = "dgvDiasNoLab";
            this.dgvDiasNoLab.ReadOnly = true;
            this.dgvDiasNoLab.RowHeadersVisible = false;
            this.dgvDiasNoLab.RowTemplate.Height = 24;
            this.dgvDiasNoLab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiasNoLab.Size = new System.Drawing.Size(508, 171);
            this.dgvDiasNoLab.TabIndex = 1;
            // 
            // gbDias_Empresa
            // 
            this.gbDias_Empresa.Controls.Add(this.btnEliminarDiaLaborable);
            this.gbDias_Empresa.Controls.Add(this.AgregarDiaLaborable);
            this.gbDias_Empresa.Controls.Add(this.dgvDias_Empresa);
            this.gbDias_Empresa.Location = new System.Drawing.Point(11, 150);
            this.gbDias_Empresa.Margin = new System.Windows.Forms.Padding(2);
            this.gbDias_Empresa.Name = "gbDias_Empresa";
            this.gbDias_Empresa.Padding = new System.Windows.Forms.Padding(2);
            this.gbDias_Empresa.Size = new System.Drawing.Size(518, 250);
            this.gbDias_Empresa.TabIndex = 12;
            this.gbDias_Empresa.TabStop = false;
            this.gbDias_Empresa.Text = "DÍAS EMPRESA";
            // 
            // btnEliminarDiaLaborable
            // 
            this.btnEliminarDiaLaborable.Image = global::VISTA.Properties.Resources.date_delete;
            this.btnEliminarDiaLaborable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarDiaLaborable.Location = new System.Drawing.Point(107, 193);
            this.btnEliminarDiaLaborable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarDiaLaborable.Name = "btnEliminarDiaLaborable";
            this.btnEliminarDiaLaborable.Size = new System.Drawing.Size(70, 52);
            this.btnEliminarDiaLaborable.TabIndex = 8;
            this.btnEliminarDiaLaborable.Text = "Eliminar";
            this.btnEliminarDiaLaborable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarDiaLaborable.UseVisualStyleBackColor = true;
            this.btnEliminarDiaLaborable.Click += new System.EventHandler(this.btnEliminarDia_Click);
            // 
            // AgregarDiaLaborable
            // 
            this.AgregarDiaLaborable.Image = global::VISTA.Properties.Resources.date_add;
            this.AgregarDiaLaborable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarDiaLaborable.Location = new System.Drawing.Point(5, 193);
            this.AgregarDiaLaborable.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarDiaLaborable.Name = "AgregarDiaLaborable";
            this.AgregarDiaLaborable.Size = new System.Drawing.Size(70, 52);
            this.AgregarDiaLaborable.TabIndex = 7;
            this.AgregarDiaLaborable.Text = "Agregar";
            this.AgregarDiaLaborable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarDiaLaborable.UseVisualStyleBackColor = true;
            this.AgregarDiaLaborable.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDias_Empresa
            // 
            this.dgvDias_Empresa.AllowUserToAddRows = false;
            this.dgvDias_Empresa.AllowUserToDeleteRows = false;
            this.dgvDias_Empresa.AllowUserToResizeColumns = false;
            this.dgvDias_Empresa.AllowUserToResizeRows = false;
            this.dgvDias_Empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDias_Empresa.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDias_Empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDias_Empresa.Location = new System.Drawing.Point(5, 17);
            this.dgvDias_Empresa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDias_Empresa.Name = "dgvDias_Empresa";
            this.dgvDias_Empresa.ReadOnly = true;
            this.dgvDias_Empresa.RowHeadersVisible = false;
            this.dgvDias_Empresa.RowTemplate.Height = 24;
            this.dgvDias_Empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDias_Empresa.Size = new System.Drawing.Size(508, 171);
            this.dgvDias_Empresa.TabIndex = 0;
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Image = global::VISTA.Properties.Resources.page_white_edit;
            this.btnModificarDatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarDatos.Location = new System.Drawing.Point(458, 34);
            this.btnModificarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(70, 67);
            this.btnModificarDatos.TabIndex = 11;
            this.btnModificarDatos.Text = "Modificar Datos";
            this.btnModificarDatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarDatos.UseVisualStyleBackColor = true;
            this.btnModificarDatos.Visible = false;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // gbDatosEmpresa
            // 
            this.gbDatosEmpresa.Controls.Add(this.btnCancelar);
            this.gbDatosEmpresa.Controls.Add(this.btnGuardarDatos);
            this.gbDatosEmpresa.Controls.Add(this.txtLocalidad);
            this.gbDatosEmpresa.Controls.Add(this.txtDueño);
            this.gbDatosEmpresa.Controls.Add(this.txtNombre);
            this.gbDatosEmpresa.Controls.Add(this.label3);
            this.gbDatosEmpresa.Controls.Add(this.label2);
            this.gbDatosEmpresa.Controls.Add(this.label1);
            this.gbDatosEmpresa.Location = new System.Drawing.Point(11, 10);
            this.gbDatosEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosEmpresa.Name = "gbDatosEmpresa";
            this.gbDatosEmpresa.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosEmpresa.Size = new System.Drawing.Size(434, 128);
            this.gbDatosEmpresa.TabIndex = 10;
            this.gbDatosEmpresa.TabStop = false;
            this.gbDatosEmpresa.Text = "DATOS EMPRESA";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(348, 64);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 52);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarDatos.Location = new System.Drawing.Point(348, 7);
            this.btnGuardarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(70, 52);
            this.btnGuardarDatos.TabIndex = 6;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(72, 90);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(242, 20);
            this.txtLocalidad.TabIndex = 5;
            // 
            // txtDueño
            // 
            this.txtDueño.Location = new System.Drawing.Point(72, 57);
            this.txtDueño.Margin = new System.Windows.Forms.Padding(2);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(242, 20);
            this.txtDueño.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dueño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmCONFIGEMPRESA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 671);
            this.Controls.Add(this.dgvDiasNoLaborablesEmp);
            this.Controls.Add(this.gbDias_Empresa);
            this.Controls.Add(this.btnModificarDatos);
            this.Controls.Add(this.gbDatosEmpresa);
            this.Name = "FrmCONFIGEMPRESA";
            this.Text = "::.CONFIGURACIÓN DE DATOS DE LA EMPRESA";
            this.dgvDiasNoLaborablesEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasNoLab)).EndInit();
            this.gbDias_Empresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDias_Empresa)).EndInit();
            this.gbDatosEmpresa.ResumeLayout(false);
            this.gbDatosEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dgvDiasNoLaborablesEmp;
        private System.Windows.Forms.Button btnEliminarDiaNoLaborable;
        private System.Windows.Forms.Button btnAgregarDiaNoLaborable;
        private System.Windows.Forms.DataGridView dgvDiasNoLab;
        private System.Windows.Forms.GroupBox gbDias_Empresa;
        private System.Windows.Forms.Button btnEliminarDiaLaborable;
        private System.Windows.Forms.Button AgregarDiaLaborable;
        private System.Windows.Forms.DataGridView dgvDias_Empresa;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.GroupBox gbDatosEmpresa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}