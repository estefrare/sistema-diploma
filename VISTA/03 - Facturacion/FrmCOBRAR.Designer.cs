namespace VISTA
{
    partial class FrmCOBRAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCOBRAR));
            this.txtNombre_Afiliado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtDNI_Afiliado = new System.Windows.Forms.MaskedTextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Total_a_pagar = new System.Windows.Forms.TextBox();
            this.DgvTotalDeudas = new System.Windows.Forms.DataGridView();
            this.DgvDeudasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalDeudas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeudasSeleccionadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre_Afiliado
            // 
            this.txtNombre_Afiliado.Location = new System.Drawing.Point(76, 35);
            this.txtNombre_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_Afiliado.Name = "txtNombre_Afiliado";
            this.txtNombre_Afiliado.Size = new System.Drawing.Size(246, 20);
            this.txtNombre_Afiliado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "DNI:";
            // 
            // mtxtDNI_Afiliado
            // 
            this.mtxtDNI_Afiliado.Location = new System.Drawing.Point(76, 59);
            this.mtxtDNI_Afiliado.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDNI_Afiliado.Mask = "00000000";
            this.mtxtDNI_Afiliado.Name = "mtxtDNI_Afiliado";
            this.mtxtDNI_Afiliado.Size = new System.Drawing.Size(60, 20);
            this.mtxtDNI_Afiliado.TabIndex = 24;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCobrar.Location = new System.Drawing.Point(925, 346);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(103, 78);
            this.btnCobrar.TabIndex = 32;
            this.btnCobrar.Text = "Cobrar e imprimir";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(925, 431);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 57);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(941, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total a pagar:";
            // 
            // txt_Total_a_pagar
            // 
            this.txt_Total_a_pagar.Location = new System.Drawing.Point(936, 222);
            this.txt_Total_a_pagar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Total_a_pagar.Name = "txt_Total_a_pagar";
            this.txt_Total_a_pagar.ReadOnly = true;
            this.txt_Total_a_pagar.Size = new System.Drawing.Size(79, 20);
            this.txt_Total_a_pagar.TabIndex = 23;
            this.txt_Total_a_pagar.Text = "0";
            // 
            // DgvTotalDeudas
            // 
            this.DgvTotalDeudas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvTotalDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTotalDeudas.Location = new System.Drawing.Point(28, 122);
            this.DgvTotalDeudas.Name = "DgvTotalDeudas";
            this.DgvTotalDeudas.Size = new System.Drawing.Size(436, 366);
            this.DgvTotalDeudas.TabIndex = 34;
            this.DgvTotalDeudas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTotalDeudas_CellDoubleClick);
            // 
            // DgvDeudasSeleccionadas
            // 
            this.DgvDeudasSeleccionadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvDeudasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeudasSeleccionadas.Location = new System.Drawing.Point(470, 122);
            this.DgvDeudasSeleccionadas.Name = "DgvDeudasSeleccionadas";
            this.DgvDeudasSeleccionadas.Size = new System.Drawing.Size(436, 366);
            this.DgvDeudasSeleccionadas.TabIndex = 34;
            this.DgvDeudasSeleccionadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDeudasSeleccionadas_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total deudas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Deudas seleccionadas:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(736, 11);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(170, 105);
            this.crystalReportViewer1.TabIndex = 36;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // FrmCOBRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 611);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.DgvDeudasSeleccionadas);
            this.Controls.Add(this.DgvTotalDeudas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txt_Total_a_pagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre_Afiliado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtDNI_Afiliado);
            this.Name = "FrmCOBRAR";
            this.Text = ".:: COBRAR ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalDeudas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeudasSeleccionadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre_Afiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtDNI_Afiliado;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Total_a_pagar;
        private System.Windows.Forms.DataGridView DgvTotalDeudas;
        private System.Windows.Forms.DataGridView DgvDeudasSeleccionadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}