namespace VISTA
{
    partial class FrmBUSCARAFILIADO
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
            this.dgvAFILIADOS = new System.Windows.Forms.DataGridView();
            this.gbFiltroAfiliado = new System.Windows.Forms.GroupBox();
            this.txtNombre_Afiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFILIADOS)).BeginInit();
            this.gbFiltroAfiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAFILIADOS
            // 
            this.dgvAFILIADOS.AllowUserToAddRows = false;
            this.dgvAFILIADOS.AllowUserToDeleteRows = false;
            this.dgvAFILIADOS.AllowUserToResizeColumns = false;
            this.dgvAFILIADOS.AllowUserToResizeRows = false;
            this.dgvAFILIADOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAFILIADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAFILIADOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAFILIADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFILIADOS.Location = new System.Drawing.Point(11, 84);
            this.dgvAFILIADOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAFILIADOS.Name = "dgvAFILIADOS";
            this.dgvAFILIADOS.ReadOnly = true;
            this.dgvAFILIADOS.RowHeadersVisible = false;
            this.dgvAFILIADOS.RowTemplate.Height = 24;
            this.dgvAFILIADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAFILIADOS.Size = new System.Drawing.Size(978, 325);
            this.dgvAFILIADOS.TabIndex = 3;
            this.dgvAFILIADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAFILIADOS_CellContentDoubleClick);
            // 
            // gbFiltroAfiliado
            // 
            this.gbFiltroAfiliado.Controls.Add(this.txtNombre_Afiliado);
            this.gbFiltroAfiliado.Controls.Add(this.label1);
            this.gbFiltroAfiliado.Location = new System.Drawing.Point(11, 11);
            this.gbFiltroAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltroAfiliado.Name = "gbFiltroAfiliado";
            this.gbFiltroAfiliado.Padding = new System.Windows.Forms.Padding(2);
            this.gbFiltroAfiliado.Size = new System.Drawing.Size(301, 69);
            this.gbFiltroAfiliado.TabIndex = 2;
            this.gbFiltroAfiliado.TabStop = false;
            this.gbFiltroAfiliado.Text = "FILTRO";
            // 
            // txtNombre_Afiliado
            // 
            this.txtNombre_Afiliado.Location = new System.Drawing.Point(56, 37);
            this.txtNombre_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Afiliado.Name = "txtNombre_Afiliado";
            this.txtNombre_Afiliado.Size = new System.Drawing.Size(215, 20);
            this.txtNombre_Afiliado.TabIndex = 1;
            this.txtNombre_Afiliado.TextChanged += new System.EventHandler(this.txtNombre_Afiliado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmBUSCARAFILIADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 425);
            this.Controls.Add(this.dgvAFILIADOS);
            this.Controls.Add(this.gbFiltroAfiliado);
            this.Name = "FrmBUSCARAFILIADO";
            this.Text = ".:: BÚSQUEDA DE AFILIADOS ::.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFILIADOS)).EndInit();
            this.gbFiltroAfiliado.ResumeLayout(false);
            this.gbFiltroAfiliado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAFILIADOS;
        private System.Windows.Forms.GroupBox gbFiltroAfiliado;
        private System.Windows.Forms.TextBox txtNombre_Afiliado;
        private System.Windows.Forms.Label label1;
    }
}