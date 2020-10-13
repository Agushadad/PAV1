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
            this.Rv_TipoProdMasVendido = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_MesTPMV = new System.Windows.Forms.TextBox();
            this.btn_BuscTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RV_ProdMV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_PMV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscPMV = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rv_Productos);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin restriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rv_Productos
            // 
            this.Rv_Productos.Location = new System.Drawing.Point(7, 47);
            this.Rv_Productos.Name = "Rv_Productos";
            this.Rv_Productos.ServerReport.BearerToken = null;
            this.Rv_Productos.Size = new System.Drawing.Size(751, 356);
            this.Rv_Productos.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(7, 18);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo producto mas vendido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Rv_TipoProdMasVendido
            // 
            this.Rv_TipoProdMasVendido.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.Rv_TipoProdMasVendido.Location = new System.Drawing.Point(6, 37);
            this.Rv_TipoProdMasVendido.Name = "Rv_TipoProdMasVendido";
            this.Rv_TipoProdMasVendido.ServerReport.BearerToken = null;
            this.Rv_TipoProdMasVendido.Size = new System.Drawing.Size(756, 362);
            this.Rv_TipoProdMasVendido.TabIndex = 9;
            // 
            // txt_MesTPMV
            // 
            this.txt_MesTPMV.Location = new System.Drawing.Point(37, 10);
            this.txt_MesTPMV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MesTPMV.Name = "txt_MesTPMV";
            this.txt_MesTPMV.Size = new System.Drawing.Size(52, 20);
            this.txt_MesTPMV.TabIndex = 2;
            // 
            // btn_BuscTP
            // 
            this.btn_BuscTP.Location = new System.Drawing.Point(93, 10);
            this.btn_BuscTP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BuscTP.Name = "btn_BuscTP";
            this.btn_BuscTP.Size = new System.Drawing.Size(63, 20);
            this.btn_BuscTP.TabIndex = 1;
            this.btn_BuscTP.Text = "Buscar";
            this.btn_BuscTP.UseVisualStyleBackColor = true;
            this.btn_BuscTP.Click += new System.EventHandler(this.btn_BuscTP_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RV_ProdMV);
            this.tabPage3.Controls.Add(this.txt_PMV);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_BuscPMV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(774, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Producto mas vendido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RV_ProdMV
            // 
            this.RV_ProdMV.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.RV_ProdMV.Location = new System.Drawing.Point(10, 31);
            this.RV_ProdMV.Name = "RV_ProdMV";
            this.RV_ProdMV.ServerReport.BearerToken = null;
            this.RV_ProdMV.Size = new System.Drawing.Size(756, 376);
            this.RV_ProdMV.TabIndex = 10;
            // 
            // txt_PMV
            // 
            this.txt_PMV.Location = new System.Drawing.Point(37, 6);
            this.txt_PMV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PMV.Name = "txt_PMV";
            this.txt_PMV.Size = new System.Drawing.Size(58, 20);
            this.txt_PMV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_BuscPMV
            // 
            this.btn_BuscPMV.Location = new System.Drawing.Point(99, 6);
            this.btn_BuscPMV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BuscPMV.Name = "btn_BuscPMV";
            this.btn_BuscPMV.Size = new System.Drawing.Size(74, 20);
            this.btn_BuscPMV.TabIndex = 0;
            this.btn_BuscPMV.Text = "Buscar";
            this.btn_BuscPMV.UseVisualStyleBackColor = true;
            this.btn_BuscPMV.Click += new System.EventHandler(this.btn_BuscPMV_Click_1);
            // 
            // Frm_ReportesProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.TextBox txt_PMV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscPMV;
    }
}