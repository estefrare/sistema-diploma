namespace VISTA
{
    partial class FrmGESTIONARPRODUCTOS
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 83);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1326, 548);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.chkStock);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(293, 67);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.Location = new System.Drawing.Point(17, 45);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(156, 17);
            this.chkStock.TabIndex = 28;
            this.chkStock.Text = "Mostrar productos sin stock";
            this.chkStock.UseVisualStyleBackColor = true;
            this.chkStock.CheckedChanged += new System.EventHandler(this.chkStock_CheckedChanged);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(17, 17);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(250, 20);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::VISTA.Properties.Resources._112_LeftArrowShort_Blue_32x42_72;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1257, 636);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 54);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultarProducto
            // 
            this.btnConsultarProducto.Image = global::VISTA.Properties.Resources.vcard;
            this.btnConsultarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarProducto.Location = new System.Drawing.Point(12, 636);
            this.btnConsultarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarProducto.Name = "btnConsultarProducto";
            this.btnConsultarProducto.Size = new System.Drawing.Size(81, 54);
            this.btnConsultarProducto.TabIndex = 25;
            this.btnConsultarProducto.Text = "Consultar";
            this.btnConsultarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarProducto.UseVisualStyleBackColor = true;
            this.btnConsultarProducto.Click += new System.EventHandler(this.btnConsultarProducto_Click);
            // 
            // FrmGESTIONARPRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Name = "FrmGESTIONARPRODUCTOS";
            this.Text = ".::GESTIONAR PRODUCTOS::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultarProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.CheckBox chkStock;
    }
}