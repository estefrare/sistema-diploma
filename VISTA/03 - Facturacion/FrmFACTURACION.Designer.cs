namespace VISTA
{
    partial class FrmFACTURACION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFACTURACION));
            this.dgvAFILIADOS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ChkInactivos = new System.Windows.Forms.CheckBox();
            this.txtBuscar_Afiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkDebitoAutomatico = new System.Windows.Forms.CheckBox();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblDebitar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFILIADOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAFILIADOS
            // 
            this.dgvAFILIADOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAFILIADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFILIADOS.Location = new System.Drawing.Point(12, 130);
            this.dgvAFILIADOS.Name = "dgvAFILIADOS";
            this.dgvAFILIADOS.Size = new System.Drawing.Size(851, 382);
            this.dgvAFILIADOS.TabIndex = 0;
            this.dgvAFILIADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAFILIADOS_CellContentClick);
            this.dgvAFILIADOS.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAFILIADOS_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.ChkInactivos);
            this.groupBox1.Controls.Add(this.txtBuscar_Afiliado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(433, 91);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(353, 60);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // ChkInactivos
            // 
            this.ChkInactivos.AutoSize = true;
            this.ChkInactivos.Checked = true;
            this.ChkInactivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkInactivos.Location = new System.Drawing.Point(8, 64);
            this.ChkInactivos.Name = "ChkInactivos";
            this.ChkInactivos.Size = new System.Drawing.Size(151, 17);
            this.ChkInactivos.TabIndex = 3;
            this.ChkInactivos.Text = "Mostrar Usuarios Inactivos";
            this.ChkInactivos.UseVisualStyleBackColor = true;
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
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCobrar.Location = new System.Drawing.Point(11, 518);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(82, 57);
            this.btnCobrar.TabIndex = 32;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(782, 521);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkDebitoAutomatico
            // 
            this.chkDebitoAutomatico.AutoSize = true;
            this.chkDebitoAutomatico.Location = new System.Drawing.Point(20, 107);
            this.chkDebitoAutomatico.Name = "chkDebitoAutomatico";
            this.chkDebitoAutomatico.Size = new System.Drawing.Size(251, 17);
            this.chkDebitoAutomatico.TabIndex = 3;
            this.chkDebitoAutomatico.Text = "Mostrar solo los afiliados con Debito Automatico";
            this.chkDebitoAutomatico.UseVisualStyleBackColor = true;
            this.chkDebitoAutomatico.CheckedChanged += new System.EventHandler(this.chkDebitoAutomatico_CheckedChanged);
            // 
            // btnDebitar
            // 
            this.btnDebitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnDebitar.Image = ((System.Drawing.Image)(resources.GetObject("btnDebitar.Image")));
            this.btnDebitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDebitar.Location = new System.Drawing.Point(99, 518);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(105, 57);
            this.btnDebitar.TabIndex = 34;
            this.btnDebitar.Text = "Debitar todos";
            this.btnDebitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDebitar.UseVisualStyleBackColor = true;
            this.btnDebitar.Click += new System.EventHandler(this.btnDebitar_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(578, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 112);
            this.crystalReportViewer1.TabIndex = 35;
            this.crystalReportViewer1.Visible = false;
            // 
            // lblDebitar
            // 
            this.lblDebitar.AutoSize = true;
            this.lblDebitar.ForeColor = System.Drawing.Color.Red;
            this.lblDebitar.Location = new System.Drawing.Point(236, 543);
            this.lblDebitar.Name = "lblDebitar";
            this.lblDebitar.Size = new System.Drawing.Size(35, 13);
            this.lblDebitar.TabIndex = 36;
            this.lblDebitar.Text = "label2";
            this.lblDebitar.Visible = false;
            // 
            // FrmFACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 586);
            this.Controls.Add(this.lblDebitar);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnDebitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chkDebitoAutomatico);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAFILIADOS);
            this.Name = "FrmFACTURACION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".::FACTURACION::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFACTURACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFILIADOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAFILIADOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.CheckBox ChkInactivos;
        private System.Windows.Forms.TextBox txtBuscar_Afiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkDebitoAutomatico;
        private System.Windows.Forms.Button btnDebitar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lblDebitar;
    }
}