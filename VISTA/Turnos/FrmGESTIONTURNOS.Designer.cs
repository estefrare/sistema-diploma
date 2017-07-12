namespace VISTA
{
    partial class FrmGESTIONTURNOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGESTIONTURNOS));
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.DGVTurnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.btnActualizar_Calendario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnular_Turno = new System.Windows.Forms.Button();
            this.btnRegistrar_Turno = new System.Windows.Forms.Button();
            this.btnBuscar_Turnos = new System.Windows.Forms.Button();
            this.btnConcurrio_Turno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // mcFecha
            // 
            this.mcFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mcFecha.Location = new System.Drawing.Point(14, 493);
            this.mcFecha.Margin = new System.Windows.Forms.Padding(7);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 28;
            this.mcFecha.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.mcFecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFecha_DateChanged);
            // 
            // DGVTurnos
            // 
            this.DGVTurnos.AllowUserToAddRows = false;
            this.DGVTurnos.AllowUserToDeleteRows = false;
            this.DGVTurnos.AllowUserToResizeColumns = false;
            this.DGVTurnos.AllowUserToResizeRows = false;
            this.DGVTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTurnos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTurnos.Location = new System.Drawing.Point(12, 12);
            this.DGVTurnos.MultiSelect = false;
            this.DGVTurnos.Name = "DGVTurnos";
            this.DGVTurnos.ReadOnly = true;
            this.DGVTurnos.RowHeadersVisible = false;
            this.DGVTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTurnos.Size = new System.Drawing.Size(876, 444);
            this.DGVTurnos.TabIndex = 23;
            this.DGVTurnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTurnos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Medico:";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(61, 462);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(325, 21);
            this.cmbMedicos.TabIndex = 21;
            this.cmbMedicos.SelectionChangeCommitted += new System.EventHandler(this.cmbMedicos_SelectionChangeCommitted);
            this.cmbMedicos.Click += new System.EventHandler(this.cmbMedicos_SelectionChangeCommitted);
            // 
            // btnActualizar_Calendario
            // 
            this.btnActualizar_Calendario.Image = global::VISTA.Properties.Resources.update;
            this.btnActualizar_Calendario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar_Calendario.Location = new System.Drawing.Point(216, 555);
            this.btnActualizar_Calendario.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar_Calendario.Name = "btnActualizar_Calendario";
            this.btnActualizar_Calendario.Size = new System.Drawing.Size(82, 61);
            this.btnActualizar_Calendario.TabIndex = 30;
            this.btnActualizar_Calendario.Text = "Actualizar Calendario";
            this.btnActualizar_Calendario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar_Calendario.UseVisualStyleBackColor = true;
            this.btnActualizar_Calendario.Click += new System.EventHandler(this.btnActualizar_Calendario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(806, 598);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 57);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnular_Turno
            // 
            this.btnAnular_Turno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular_Turno.Image = global::VISTA.Properties.Resources.cancel;
            this.btnAnular_Turno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular_Turno.Location = new System.Drawing.Point(806, 462);
            this.btnAnular_Turno.Name = "btnAnular_Turno";
            this.btnAnular_Turno.Size = new System.Drawing.Size(82, 57);
            this.btnAnular_Turno.TabIndex = 26;
            this.btnAnular_Turno.Text = "Anular";
            this.btnAnular_Turno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular_Turno.UseVisualStyleBackColor = true;
            this.btnAnular_Turno.Click += new System.EventHandler(this.btnAnular_Turno_Click);
            // 
            // btnRegistrar_Turno
            // 
            this.btnRegistrar_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar_Turno.Image = global::VISTA.Properties.Resources._005_Task_32x42_72;
            this.btnRegistrar_Turno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar_Turno.Location = new System.Drawing.Point(304, 493);
            this.btnRegistrar_Turno.Name = "btnRegistrar_Turno";
            this.btnRegistrar_Turno.Size = new System.Drawing.Size(82, 57);
            this.btnRegistrar_Turno.TabIndex = 25;
            this.btnRegistrar_Turno.Text = "Registrar";
            this.btnRegistrar_Turno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar_Turno.UseVisualStyleBackColor = true;
            this.btnRegistrar_Turno.Click += new System.EventHandler(this.btnRegistrar_Turno_Click);
            // 
            // btnBuscar_Turnos
            // 
            this.btnBuscar_Turnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar_Turnos.Image = global::VISTA.Properties.Resources.search;
            this.btnBuscar_Turnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar_Turnos.Location = new System.Drawing.Point(216, 493);
            this.btnBuscar_Turnos.Name = "btnBuscar_Turnos";
            this.btnBuscar_Turnos.Size = new System.Drawing.Size(82, 57);
            this.btnBuscar_Turnos.TabIndex = 24;
            this.btnBuscar_Turnos.Text = "Buscar";
            this.btnBuscar_Turnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar_Turnos.UseVisualStyleBackColor = true;
            this.btnBuscar_Turnos.Click += new System.EventHandler(this.btnBuscar_Turnos_Click);
            // 
            // btnConcurrio_Turno
            // 
            this.btnConcurrio_Turno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConcurrio_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcurrio_Turno.Image = ((System.Drawing.Image)(resources.GetObject("btnConcurrio_Turno.Image")));
            this.btnConcurrio_Turno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConcurrio_Turno.Location = new System.Drawing.Point(718, 462);
            this.btnConcurrio_Turno.Name = "btnConcurrio_Turno";
            this.btnConcurrio_Turno.Size = new System.Drawing.Size(82, 57);
            this.btnConcurrio_Turno.TabIndex = 31;
            this.btnConcurrio_Turno.Text = "Concurrio";
            this.btnConcurrio_Turno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConcurrio_Turno.UseVisualStyleBackColor = true;
            this.btnConcurrio_Turno.Click += new System.EventHandler(this.btnConcurrio_Turno_Click);
            // 
            // FrmGESTIONTURNOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 671);
            this.Controls.Add(this.btnConcurrio_Turno);
            this.Controls.Add(this.btnActualizar_Calendario);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnular_Turno);
            this.Controls.Add(this.btnRegistrar_Turno);
            this.Controls.Add(this.btnBuscar_Turnos);
            this.Controls.Add(this.DGVTurnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "FrmGESTIONTURNOS";
            this.Text = ".:: GESTIÓN DE TURNOS ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar_Calendario;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnular_Turno;
        private System.Windows.Forms.Button btnRegistrar_Turno;
        private System.Windows.Forms.Button btnBuscar_Turnos;
        private System.Windows.Forms.DataGridView DGVTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.Button btnConcurrio_Turno;
    }
}