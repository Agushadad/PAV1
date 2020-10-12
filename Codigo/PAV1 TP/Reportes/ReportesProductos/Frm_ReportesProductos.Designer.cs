namespace PAV1_TP.Reportes.ReportesProdcutos
{
    partial class Frm_ReportesProductos
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
            this.Rv_Productos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscTP = new System.Windows.Forms.Button();
            this.txt_MesTPMV = new System.Windows.Forms.TextBox();
            this.Rv_TipoProdMasVendido = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_BuscPMV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RV_ProdMV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rv_Productos);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1035, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin restriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rv_Productos
            // 
            this.Rv_Productos.Location = new System.Drawing.Point(9, 58);
            this.Rv_Productos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rv_Productos.Name = "Rv_Productos";
            this.Rv_Productos.ServerReport.BearerToken = null;
            this.Rv_Productos.Size = new System.Drawing.Size(1001, 438);
            this.Rv_Productos.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(9, 9);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(100, 28);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Rv_TipoProdMasVendido);
            this.tabPage2.Controls.Add(this.txt_MesTPMV);
            this.tabPage2.Controls.Add(this.btn_BuscTP);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1035, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo producto mas vendido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RV_ProdMV);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_BuscPMV);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1035, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Producto mas vendido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes";
            // 
            // btn_BuscTP
            // 
            this.btn_BuscTP.Location = new System.Drawing.Point(298, 27);
            this.btn_BuscTP.Name = "btn_BuscTP";
            this.btn_BuscTP.Size = new System.Drawing.Size(87, 22);
            this.btn_BuscTP.TabIndex = 1;
            this.btn_BuscTP.Text = "Buscar";
            this.btn_BuscTP.UseVisualStyleBackColor = true;
            // 
            // txt_MesTPMV
            // 
            this.txt_MesTPMV.Location = new System.Drawing.Point(77, 27);
            this.txt_MesTPMV.Name = "txt_MesTPMV";
            this.txt_MesTPMV.Size = new System.Drawing.Size(206, 22);
            this.txt_MesTPMV.TabIndex = 2;
            // 
            // Rv_TipoProdMasVendido
            // 
            this.Rv_TipoProdMasVendido.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.Rv_TipoProdMasVendido.Location = new System.Drawing.Point(8, 81);
            this.Rv_TipoProdMasVendido.Margin = new System.Windows.Forms.Padding(4);
            this.Rv_TipoProdMasVendido.Name = "Rv_TipoProdMasVendido";
            this.Rv_TipoProdMasVendido.ServerReport.BearerToken = null;
            this.Rv_TipoProdMasVendido.Size = new System.Drawing.Size(1007, 409);
            this.Rv_TipoProdMasVendido.TabIndex = 9;
            // 
            // btn_BuscPMV
            // 
            this.btn_BuscPMV.Location = new System.Drawing.Point(330, 21);
            this.btn_BuscPMV.Name = "btn_BuscPMV";
            this.btn_BuscPMV.Size = new System.Drawing.Size(98, 22);
            this.btn_BuscPMV.TabIndex = 0;
            this.btn_BuscPMV.Text = "Buscar";
            this.btn_BuscPMV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 2;
            // 
            // RV_ProdMV
            // 
            this.RV_ProdMV.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.RV_ProdMV.Location = new System.Drawing.Point(13, 69);
            this.RV_ProdMV.Margin = new System.Windows.Forms.Padding(4);
            this.RV_ProdMV.Name = "RV_ProdMV";
            this.RV_ProdMV.ServerReport.BearerToken = null;
            this.RV_ProdMV.Size = new System.Drawing.Size(1007, 431);
            this.RV_ProdMV.TabIndex = 10;
            // 
            // Frm_ReportesProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ReportesProductos";
            this.Text = "Frm_ReportesProductos";
            this.Load += new System.EventHandler(this.Frm_ReportesProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Productos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MesTPMV;
        private System.Windows.Forms.Button btn_BuscTP;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_TipoProdMasVendido;
        private Microsoft.Reporting.WinForms.ReportViewer RV_ProdMV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscPMV;
    }
}