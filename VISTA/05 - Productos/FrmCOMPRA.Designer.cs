namespace VISTA
{
    partial class FrmCOMPRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCOMPRA));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dgvListaCompra = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(749, 15);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(94, 88);
            this.crystalReportViewer1.TabIndex = 84;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // dgvListaCompra
            // 
            this.dgvListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCompra.Location = new System.Drawing.Point(439, 130);
            this.dgvListaCompra.Name = "dgvListaCompra";
            this.dgvListaCompra.Size = new System.Drawing.Size(404, 523);
            this.dgvListaCompra.TabIndex = 76;
            this.dgvListaCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCompra_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Lista de compra";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(729, 666);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 81;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(775, 663);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(68, 22);
            this.txtTotal.TabIndex = 82;
            this.txtTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 666);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(353, 663);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 22);
            this.txtCantidad.TabIndex = 83;
            this.txtCantidad.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBusqueda);
            this.groupBox2.Controls.Add(this.chkStock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 91);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de producto";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(17, 32);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(369, 22);
            this.txtBusqueda.TabIndex = 23;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Checked = true;
            this.chkStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.Location = new System.Drawing.Point(17, 62);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(190, 20);
            this.chkStock.TabIndex = 27;
            this.chkStock.Text = "Mostrar productos sin stock";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(17, 659);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(262, 30);
            this.btnAgregarProducto.TabIndex = 73;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResetar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResetar.Location = new System.Drawing.Point(849, 297);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(99, 51);
            this.btnResetar.TabIndex = 71;
            this.btnResetar.Text = "Resetear compra";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuitarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitarProducto.Location = new System.Drawing.Point(849, 240);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(99, 51);
            this.btnQuitarProducto.TabIndex = 70;
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 130);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(404, 523);
            this.dgvProductos.TabIndex = 69;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(849, 595);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 58);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRealizar.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizar.Image")));
            this.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizar.Location = new System.Drawing.Point(849, 531);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(99, 58);
            this.btnRealizar.TabIndex = 74;
            this.btnRealizar.Text = "REALIZAR";
            this.btnRealizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(439, 659);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(262, 30);
            this.btnNuevoProducto.TabIndex = 73;
            this.btnNuevoProducto.Text = "Agregar nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(854, 391);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(94, 88);
            this.crystalReportViewer2.TabIndex = 85;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer2.Visible = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(461, 46);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(193, 20);
            this.txtProveedor.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Proovedor";
            // 
            // FrmCOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 701);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dgvListaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "FrmCOMPRA";
            this.Text = ".::COMPRA::.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dgvListaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label3;
    }
}