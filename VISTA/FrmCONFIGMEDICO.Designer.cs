namespace VISTA
{
    partial class FrmCONFIGMEDICO
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbDias_No_Laborables_Medicos = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Dia_No_Laborable = new System.Windows.Forms.Button();
            this.btnAgregar_Día_No_Laborable = new System.Windows.Forms.Button();
            this.dgvDiasNoLaborablesMedicos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar_Horario = new System.Windows.Forms.Button();
            this.btnAgregar_Horario = new System.Windows.Forms.Button();
            this.dgvHorariosMedico = new System.Windows.Forms.DataGridView();
            this.gbDias_No_Laborables_Medicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasNoLaborablesMedicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(168, 469);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 52);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbDias_No_Laborables_Medicos
            // 
            this.gbDias_No_Laborables_Medicos.Controls.Add(this.btnEliminar_Dia_No_Laborable);
            this.gbDias_No_Laborables_Medicos.Controls.Add(this.btnAgregar_Día_No_Laborable);
            this.gbDias_No_Laborables_Medicos.Controls.Add(this.dgvDiasNoLaborablesMedicos);
            this.gbDias_No_Laborables_Medicos.Location = new System.Drawing.Point(11, 241);
            this.gbDias_No_Laborables_Medicos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDias_No_Laborables_Medicos.Name = "gbDias_No_Laborables_Medicos";
            this.gbDias_No_Laborables_Medicos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDias_No_Laborables_Medicos.Size = new System.Drawing.Size(437, 210);
            this.gbDias_No_Laborables_Medicos.TabIndex = 6;
            this.gbDias_No_Laborables_Medicos.TabStop = false;
            this.gbDias_No_Laborables_Medicos.Text = "DÍAS NO LABORABLES";
            // 
            // btnEliminar_Dia_No_Laborable
            // 
            this.btnEliminar_Dia_No_Laborable.Image = global::VISTA.Properties.Resources.date_delete;
            this.btnEliminar_Dia_No_Laborable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar_Dia_No_Laborable.Location = new System.Drawing.Point(98, 154);
            this.btnEliminar_Dia_No_Laborable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar_Dia_No_Laborable.Name = "btnEliminar_Dia_No_Laborable";
            this.btnEliminar_Dia_No_Laborable.Size = new System.Drawing.Size(68, 52);
            this.btnEliminar_Dia_No_Laborable.TabIndex = 3;
            this.btnEliminar_Dia_No_Laborable.Text = "Eliminar";
            this.btnEliminar_Dia_No_Laborable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar_Dia_No_Laborable.UseVisualStyleBackColor = true;
            this.btnEliminar_Dia_No_Laborable.Click += new System.EventHandler(this.btnEliminar_Dia_No_Laborable_Click);
            // 
            // btnAgregar_Día_No_Laborable
            // 
            this.btnAgregar_Día_No_Laborable.Image = global::VISTA.Properties.Resources.date_add;
            this.btnAgregar_Día_No_Laborable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Día_No_Laborable.Location = new System.Drawing.Point(5, 154);
            this.btnAgregar_Día_No_Laborable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Día_No_Laborable.Name = "btnAgregar_Día_No_Laborable";
            this.btnAgregar_Día_No_Laborable.Size = new System.Drawing.Size(68, 52);
            this.btnAgregar_Día_No_Laborable.TabIndex = 2;
            this.btnAgregar_Día_No_Laborable.Text = "Agregar";
            this.btnAgregar_Día_No_Laborable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Día_No_Laborable.UseVisualStyleBackColor = true;
            this.btnAgregar_Día_No_Laborable.Click += new System.EventHandler(this.btnAgregar_Día_No_Laborable_Click);
            // 
            // dgvDiasNoLaborablesMedicos
            // 
            this.dgvDiasNoLaborablesMedicos.AllowUserToAddRows = false;
            this.dgvDiasNoLaborablesMedicos.AllowUserToDeleteRows = false;
            this.dgvDiasNoLaborablesMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiasNoLaborablesMedicos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDiasNoLaborablesMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiasNoLaborablesMedicos.Location = new System.Drawing.Point(5, 18);
            this.dgvDiasNoLaborablesMedicos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiasNoLaborablesMedicos.Name = "dgvDiasNoLaborablesMedicos";
            this.dgvDiasNoLaborablesMedicos.ReadOnly = true;
            this.dgvDiasNoLaborablesMedicos.RowHeadersVisible = false;
            this.dgvDiasNoLaborablesMedicos.RowTemplate.Height = 24;
            this.dgvDiasNoLaborablesMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiasNoLaborablesMedicos.Size = new System.Drawing.Size(428, 124);
            this.dgvDiasNoLaborablesMedicos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar_Horario);
            this.groupBox1.Controls.Add(this.btnAgregar_Horario);
            this.groupBox1.Controls.Add(this.dgvHorariosMedico);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HORARIOS";
            // 
            // btnEliminar_Horario
            // 
            this.btnEliminar_Horario.Image = global::VISTA.Properties.Resources.date_delete;
            this.btnEliminar_Horario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar_Horario.Location = new System.Drawing.Point(98, 144);
            this.btnEliminar_Horario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar_Horario.Name = "btnEliminar_Horario";
            this.btnEliminar_Horario.Size = new System.Drawing.Size(68, 52);
            this.btnEliminar_Horario.TabIndex = 2;
            this.btnEliminar_Horario.Text = "Eliminar";
            this.btnEliminar_Horario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar_Horario.UseVisualStyleBackColor = true;
            this.btnEliminar_Horario.Click += new System.EventHandler(this.btnEliminar_Horario_Click);
            // 
            // btnAgregar_Horario
            // 
            this.btnAgregar_Horario.Image = global::VISTA.Properties.Resources.date_add;
            this.btnAgregar_Horario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Horario.Location = new System.Drawing.Point(5, 144);
            this.btnAgregar_Horario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar_Horario.Name = "btnAgregar_Horario";
            this.btnAgregar_Horario.Size = new System.Drawing.Size(68, 52);
            this.btnAgregar_Horario.TabIndex = 1;
            this.btnAgregar_Horario.Text = "Agregar";
            this.btnAgregar_Horario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar_Horario.UseVisualStyleBackColor = true;
            this.btnAgregar_Horario.Click += new System.EventHandler(this.btnAgregar_Horario_Click);
            // 
            // dgvHorariosMedico
            // 
            this.dgvHorariosMedico.AllowUserToAddRows = false;
            this.dgvHorariosMedico.AllowUserToDeleteRows = false;
            this.dgvHorariosMedico.AllowUserToResizeColumns = false;
            this.dgvHorariosMedico.AllowUserToResizeRows = false;
            this.dgvHorariosMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorariosMedico.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHorariosMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorariosMedico.Location = new System.Drawing.Point(4, 17);
            this.dgvHorariosMedico.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHorariosMedico.Name = "dgvHorariosMedico";
            this.dgvHorariosMedico.ReadOnly = true;
            this.dgvHorariosMedico.RowHeadersVisible = false;
            this.dgvHorariosMedico.RowTemplate.Height = 24;
            this.dgvHorariosMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorariosMedico.Size = new System.Drawing.Size(428, 122);
            this.dgvHorariosMedico.TabIndex = 0;
            // 
            // FrmCONFIGMEDICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 523);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbDias_No_Laborables_Medicos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCONFIGMEDICO";
            this.Text = "::.CONFIGURACIÓN MEDICOS";
            this.gbDias_No_Laborables_Medicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasNoLaborablesMedicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbDias_No_Laborables_Medicos;
        private System.Windows.Forms.Button btnEliminar_Dia_No_Laborable;
        private System.Windows.Forms.Button btnAgregar_Día_No_Laborable;
        private System.Windows.Forms.DataGridView dgvDiasNoLaborablesMedicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar_Horario;
        private System.Windows.Forms.Button btnAgregar_Horario;
        private System.Windows.Forms.DataGridView dgvHorariosMedico;
    }
}