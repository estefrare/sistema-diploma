namespace VISTA
{
    partial class FrmPLANES
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChkBoxEstadoPlan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtNombrePlan = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCostoPlan = new System.Windows.Forms.TextBox();
            this.TxtDescripcionPlan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChkListServicios = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 326);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChkBoxEstadoPlan);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.BtnCancelar);
            this.tabPage1.Controls.Add(this.TxtNombrePlan);
            this.tabPage1.Controls.Add(this.BtnGuardar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TxtCostoPlan);
            this.tabPage1.Controls.Add(this.TxtDescripcionPlan);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Planes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChkBoxEstadoPlan
            // 
            this.ChkBoxEstadoPlan.AutoSize = true;
            this.ChkBoxEstadoPlan.Checked = true;
            this.ChkBoxEstadoPlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBoxEstadoPlan.Location = new System.Drawing.Point(100, 196);
            this.ChkBoxEstadoPlan.Name = "ChkBoxEstadoPlan";
            this.ChkBoxEstadoPlan.Size = new System.Drawing.Size(56, 17);
            this.ChkBoxEstadoPlan.TabIndex = 28;
            this.ChkBoxEstadoPlan.Text = "Activo";
            this.ChkBoxEstadoPlan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre del Plan:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::VISTA.Properties.Resources._305_Close_32x32_72;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(242, 242);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 53);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtNombrePlan
            // 
            this.TxtNombrePlan.Location = new System.Drawing.Point(100, 11);
            this.TxtNombrePlan.Name = "TxtNombrePlan";
            this.TxtNombrePlan.Size = new System.Drawing.Size(226, 20);
            this.TxtNombrePlan.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::VISTA.Properties.Resources.save_as;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(154, 242);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(84, 53);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Descripción:";
            // 
            // TxtCostoPlan
            // 
            this.TxtCostoPlan.Location = new System.Drawing.Point(100, 151);
            this.TxtCostoPlan.Name = "TxtCostoPlan";
            this.TxtCostoPlan.Size = new System.Drawing.Size(226, 20);
            this.TxtCostoPlan.TabIndex = 3;
            this.TxtCostoPlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoPlan_KeyPress);
            // 
            // TxtDescripcionPlan
            // 
            this.TxtDescripcionPlan.Location = new System.Drawing.Point(100, 51);
            this.TxtDescripcionPlan.Multiline = true;
            this.TxtDescripcionPlan.Name = "TxtDescripcionPlan";
            this.TxtDescripcionPlan.Size = new System.Drawing.Size(226, 73);
            this.TxtDescripcionPlan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Costo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChkListServicios);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servicios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChkListServicios
            // 
            this.ChkListServicios.FormattingEnabled = true;
            this.ChkListServicios.Location = new System.Drawing.Point(9, 47);
            this.ChkListServicios.Name = "ChkListServicios";
            this.ChkListServicios.Size = new System.Drawing.Size(331, 169);
            this.ChkListServicios.TabIndex = 3;
            this.ChkListServicios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkListServicios_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servicios del Plan:";
            // 
            // FrmPLANES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 348);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPLANES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: DATOS DEL PLAN ::.";
            this.Load += new System.EventHandler(this.FrmPLANES_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox ChkBoxEstadoPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtNombrePlan;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCostoPlan;
        private System.Windows.Forms.TextBox TxtDescripcionPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox ChkListServicios;
        private System.Windows.Forms.Label label2;
    }
}