namespace VISTA
{
    partial class FrmPRODUCTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockMinimoProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(106, 31);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(106, 57);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(190, 20);
            this.txtDescripcionProducto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca:";
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(106, 83);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(190, 20);
            this.txtMarcaProducto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stock Mínimo:";
            // 
            // txtStockMinimoProducto
            // 
            this.txtStockMinimoProducto.Location = new System.Drawing.Point(106, 109);
            this.txtStockMinimoProducto.Name = "txtStockMinimoProducto";
            this.txtStockMinimoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimoProducto.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(106, 135);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VISTA.Properties.Resources._305_Close_32x32_72;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(253, 235);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 53);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Image = global::VISTA.Properties.Resources.save_as;
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarProducto.Location = new System.Drawing.Point(165, 235);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(84, 53);
            this.btnGuardarProducto.TabIndex = 7;
            this.btnGuardarProducto.Text = "GUARDAR";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label1);
            this.gbProducto.Controls.Add(this.txtCodigoProducto);
            this.gbProducto.Controls.Add(this.label2);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.txtDescripcionProducto);
            this.gbProducto.Controls.Add(this.txtStockMinimoProducto);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.label6);
            this.gbProducto.Controls.Add(this.txtMarcaProducto);
            this.gbProducto.Controls.Add(this.label5);
            this.gbProducto.Location = new System.Drawing.Point(12, 12);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(325, 208);
            this.gbProducto.TabIndex = 9;
            this.gbProducto.TabStop = false;
            // 
            // FrmPRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 310);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarProducto);
            this.Name = "FrmPRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: PRODUCTO ::.";
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockMinimoProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.GroupBox gbProducto;
    }
}