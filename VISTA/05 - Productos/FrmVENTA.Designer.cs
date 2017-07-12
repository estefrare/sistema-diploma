namespace VISTA
{
    partial class FrmVENTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVENTA));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dgvListaCompra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.gbFechaFactura = new System.Windows.Forms.GroupBox();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.gbNumeroFactura = new System.Windows.Forms.GroupBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.BtnEditarFormaPago = new System.Windows.Forms.Button();
            this.rbDebitoAutomatico = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.gbTipoFactura = new System.Windows.Forms.GroupBox();
            this.rb_TipoC = new System.Windows.Forms.RadioButton();
            this.rb_TipoB = new System.Windows.Forms.RadioButton();
            this.rb_TipoA = new System.Windows.Forms.RadioButton();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ucAFILIADO1 = new VISTA.ucAFILIADO();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbFechaFactura.SuspendLayout();
            this.gbNumeroFactura.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.gbTipoFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1173, 256);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(94, 88);
            this.crystalReportViewer1.TabIndex = 68;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // dgvListaCompra
            // 
            this.dgvListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCompra.Location = new System.Drawing.Point(444, 130);
            this.dgvListaCompra.Name = "dgvListaCompra";
            this.dgvListaCompra.Size = new System.Drawing.Size(404, 523);
            this.dgvListaCompra.TabIndex = 60;
            this.dgvListaCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCompra_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Lista de compra";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(734, 666);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(780, 663);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(68, 22);
            this.txtTotal.TabIndex = 65;
            this.txtTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 666);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(358, 663);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 22);
            this.txtCantidad.TabIndex = 66;
            this.txtCantidad.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBusqueda);
            this.groupBox2.Controls.Add(this.chkStock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 91);
            this.groupBox2.TabIndex = 61;
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
            this.chkStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.Location = new System.Drawing.Point(17, 62);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(190, 20);
            this.chkStock.TabIndex = 27;
            this.chkStock.Text = "Mostrar productos sin stock";
            this.chkStock.UseVisualStyleBackColor = true;
            this.chkStock.CheckedChanged += new System.EventHandler(this.chkStock_CheckedChanged);
            // 
            // gbFechaFactura
            // 
            this.gbFechaFactura.Controls.Add(this.mtbFecha);
            this.gbFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechaFactura.Location = new System.Drawing.Point(1151, 12);
            this.gbFechaFactura.Name = "gbFechaFactura";
            this.gbFechaFactura.Size = new System.Drawing.Size(134, 54);
            this.gbFechaFactura.TabIndex = 59;
            this.gbFechaFactura.TabStop = false;
            this.gbFechaFactura.Text = "Fecha";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(16, 21);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.ReadOnly = true;
            this.mtbFecha.Size = new System.Drawing.Size(100, 22);
            this.mtbFecha.TabIndex = 5;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // gbNumeroFactura
            // 
            this.gbNumeroFactura.Controls.Add(this.txtNumeroFactura);
            this.gbNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumeroFactura.Location = new System.Drawing.Point(871, 12);
            this.gbNumeroFactura.Name = "gbNumeroFactura";
            this.gbNumeroFactura.Size = new System.Drawing.Size(134, 54);
            this.gbNumeroFactura.TabIndex = 58;
            this.gbNumeroFactura.TabStop = false;
            this.gbNumeroFactura.Text = "Número ";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(17, 21);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroFactura.TabIndex = 0;
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.BtnEditarFormaPago);
            this.gbPago.Controls.Add(this.rbDebitoAutomatico);
            this.gbPago.Controls.Add(this.rbEfectivo);
            this.gbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPago.Location = new System.Drawing.Point(871, 256);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(159, 81);
            this.gbPago.TabIndex = 57;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // BtnEditarFormaPago
            // 
            this.BtnEditarFormaPago.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarFormaPago.Image")));
            this.BtnEditarFormaPago.Location = new System.Drawing.Point(125, 12);
            this.BtnEditarFormaPago.Name = "BtnEditarFormaPago";
            this.BtnEditarFormaPago.Size = new System.Drawing.Size(28, 28);
            this.BtnEditarFormaPago.TabIndex = 29;
            this.BtnEditarFormaPago.UseVisualStyleBackColor = true;
            this.BtnEditarFormaPago.Click += new System.EventHandler(this.BtnEditarFormaPago_Click);
            // 
            // rbDebitoAutomatico
            // 
            this.rbDebitoAutomatico.AutoSize = true;
            this.rbDebitoAutomatico.Enabled = false;
            this.rbDebitoAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebitoAutomatico.Location = new System.Drawing.Point(13, 49);
            this.rbDebitoAutomatico.Name = "rbDebitoAutomatico";
            this.rbDebitoAutomatico.Size = new System.Drawing.Size(136, 20);
            this.rbDebitoAutomatico.TabIndex = 3;
            this.rbDebitoAutomatico.Text = "Debito Automático";
            this.rbDebitoAutomatico.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Enabled = false;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(13, 23);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(74, 20);
            this.rbEfectivo.TabIndex = 3;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // gbTipoFactura
            // 
            this.gbTipoFactura.Controls.Add(this.rb_TipoC);
            this.gbTipoFactura.Controls.Add(this.rb_TipoB);
            this.gbTipoFactura.Controls.Add(this.rb_TipoA);
            this.gbTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoFactura.Location = new System.Drawing.Point(1011, 12);
            this.gbTipoFactura.Name = "gbTipoFactura";
            this.gbTipoFactura.Size = new System.Drawing.Size(134, 54);
            this.gbTipoFactura.TabIndex = 56;
            this.gbTipoFactura.TabStop = false;
            this.gbTipoFactura.Text = "Tipo";
            // 
            // rb_TipoC
            // 
            this.rb_TipoC.AutoSize = true;
            this.rb_TipoC.Checked = true;
            this.rb_TipoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TipoC.Location = new System.Drawing.Point(89, 23);
            this.rb_TipoC.Name = "rb_TipoC";
            this.rb_TipoC.Size = new System.Drawing.Size(35, 20);
            this.rb_TipoC.TabIndex = 3;
            this.rb_TipoC.TabStop = true;
            this.rb_TipoC.Text = "C";
            this.rb_TipoC.UseVisualStyleBackColor = true;
            // 
            // rb_TipoB
            // 
            this.rb_TipoB.AutoSize = true;
            this.rb_TipoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TipoB.Location = new System.Drawing.Point(51, 23);
            this.rb_TipoB.Name = "rb_TipoB";
            this.rb_TipoB.Size = new System.Drawing.Size(35, 20);
            this.rb_TipoB.TabIndex = 3;
            this.rb_TipoB.Text = "B";
            this.rb_TipoB.UseVisualStyleBackColor = true;
            // 
            // rb_TipoA
            // 
            this.rb_TipoA.AutoSize = true;
            this.rb_TipoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TipoA.Location = new System.Drawing.Point(13, 23);
            this.rb_TipoA.Name = "rb_TipoA";
            this.rb_TipoA.Size = new System.Drawing.Size(35, 20);
            this.rb_TipoA.TabIndex = 3;
            this.rb_TipoA.Text = "A";
            this.rb_TipoA.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(22, 659);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(262, 30);
            this.btnAgregarProducto.TabIndex = 54;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Image = global::VISTA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1239, 631);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 58);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResetar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResetar.Location = new System.Drawing.Point(859, 513);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(99, 51);
            this.btnResetar.TabIndex = 52;
            this.btnResetar.Text = "Resetear venta";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuitarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitarProducto.Location = new System.Drawing.Point(859, 456);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(99, 51);
            this.btnQuitarProducto.TabIndex = 51;
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRealizar.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizar.Image")));
            this.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizar.Location = new System.Drawing.Point(1134, 631);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(99, 58);
            this.btnRealizar.TabIndex = 55;
            this.btnRealizar.Text = "REALIZAR";
            this.btnRealizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(22, 130);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(404, 523);
            this.dgvProductos.TabIndex = 50;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Productos";
            // 
            // ucAFILIADO1
            // 
            this.ucAFILIADO1.AFILIADO = null;
            this.ucAFILIADO1.Location = new System.Drawing.Point(871, 130);
            this.ucAFILIADO1.Name = "ucAFILIADO1";
            this.ucAFILIADO1.Size = new System.Drawing.Size(414, 120);
            this.ucAFILIADO1.TabIndex = 67;
            // 
            // FrmVENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.ucAFILIADO1);
            this.Controls.Add(this.dgvListaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFechaFactura);
            this.Controls.Add(this.gbNumeroFactura);
            this.Controls.Add(this.gbPago);
            this.Controls.Add(this.gbTipoFactura);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "FrmVENTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: VENTA DE PRODUCTOS ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbFechaFactura.ResumeLayout(false);
            this.gbFechaFactura.PerformLayout();
            this.gbNumeroFactura.ResumeLayout(false);
            this.gbNumeroFactura.PerformLayout();
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbTipoFactura.ResumeLayout(false);
            this.gbTipoFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ucAFILIADO ucAFILIADO1;
        private System.Windows.Forms.DataGridView dgvListaCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.GroupBox gbFechaFactura;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.GroupBox gbNumeroFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.Button BtnEditarFormaPago;
        private System.Windows.Forms.RadioButton rbDebitoAutomatico;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.GroupBox gbTipoFactura;
        private System.Windows.Forms.RadioButton rb_TipoC;
        private System.Windows.Forms.RadioButton rb_TipoB;
        private System.Windows.Forms.RadioButton rb_TipoA;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label2;
    }
}