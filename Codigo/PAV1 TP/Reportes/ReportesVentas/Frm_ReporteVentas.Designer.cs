﻿namespace PAV1_TP.Reportes.ReportesVentas
{
    partial class Frm_ReporteVentas
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
            this.MasVentasMes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_TodasLasVentas = new System.Windows.Forms.CheckBox();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.Rv_Ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rv_VentasXMonto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Buscar = new System.Windows.Forms.Button();
            this.label02 = new System.Windows.Forms.Label();
            this.txt_Monto = new PAV1_TP.Clases.TextBox01();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Rv_VentasXMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_Mes = new PAV1_TP.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Rv_MenorVentasMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMes = new PAV1_TP.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Rv_MVM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_BuscMVM = new System.Windows.Forms.Button();
            this.AE_VentasPorMonto = new System.Windows.Forms.TabPage();
            this.RV_AEVentxMonto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_EstPeriodo = new System.Windows.Forms.ComboBox();
            this.txt_Est_Monto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AEVentxMonto = new System.Windows.Forms.Button();
            this.MasVentasMes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.AE_VentasPorMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasVentasMes
            // 
            this.MasVentasMes.Controls.Add(this.tabPage1);
            this.MasVentasMes.Controls.Add(this.tabPage2);
            this.MasVentasMes.Controls.Add(this.tabPage3);
            this.MasVentasMes.Controls.Add(this.tabPage4);
            this.MasVentasMes.Controls.Add(this.tabPage6);
            this.MasVentasMes.Controls.Add(this.AE_VentasPorMonto);
            this.MasVentasMes.Location = new System.Drawing.Point(12, 14);
            this.MasVentasMes.Name = "MasVentasMes";
            this.MasVentasMes.SelectedIndex = 0;
            this.MasVentasMes.Size = new System.Drawing.Size(776, 426);
            this.MasVentasMes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chk_TodasLasVentas);
            this.tabPage1.Controls.Add(this.txt_NroDoc);
            this.tabPage1.Controls.Add(this.Rv_Ventas);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin reestriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro Doc ";
            // 
            // chk_TodasLasVentas
            // 
            this.chk_TodasLasVentas.AutoSize = true;
            this.chk_TodasLasVentas.Location = new System.Drawing.Point(62, 42);
            this.chk_TodasLasVentas.Name = "chk_TodasLasVentas";
            this.chk_TodasLasVentas.Size = new System.Drawing.Size(107, 17);
            this.chk_TodasLasVentas.TabIndex = 4;
            this.chk_TodasLasVentas.Text = "Todas las ventas";
            this.chk_TodasLasVentas.UseVisualStyleBackColor = true;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Location = new System.Drawing.Point(62, 16);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = null;
            this.txt_NroDoc.Pp_nombre_campo = null;
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(130, 20);
            this.txt_NroDoc.TabIndex = 2;
            // 
            // Rv_Ventas
            // 
            this.Rv_Ventas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.Rv_Ventas.Location = new System.Drawing.Point(6, 65);
            this.Rv_Ventas.Name = "Rv_Ventas";
            this.Rv_Ventas.ServerReport.BearerToken = null;
            this.Rv_Ventas.Size = new System.Drawing.Size(756, 316);
            this.Rv_Ventas.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(198, 36);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Rv_VentasXMonto);
            this.tabPage2.Controls.Add(this.Buscar);
            this.tabPage2.Controls.Add(this.label02);
            this.tabPage2.Controls.Add(this.txt_Monto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas por monto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Rv_VentasXMonto
            // 
            this.Rv_VentasXMonto.Location = new System.Drawing.Point(7, 41);
            this.Rv_VentasXMonto.Name = "Rv_VentasXMonto";
            this.Rv_VentasXMonto.ServerReport.BearerToken = null;
            this.Rv_VentasXMonto.Size = new System.Drawing.Size(755, 353);
            this.Rv_VentasXMonto.TabIndex = 3;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(156, 11);
            this.Buscar.Name = "Buscar";
            this.Buscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(7, 16);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(37, 13);
            this.label02.TabIndex = 0;
            this.label02.Text = "Monto";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(50, 11);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_mensajeError = null;
            this.txt_Monto.Pp_nombre_campo = null;
            this.txt_Monto.Pp_nombre_tabla = null;
            this.txt_Monto.Pp_validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(100, 20);
            this.txt_Monto.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Rv_VentasXMes);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.txt_Mes);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dias de mayor ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Rv_VentasXMes
            // 
            this.Rv_VentasXMes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeDMayorVM.rdlc";
            this.Rv_VentasXMes.Location = new System.Drawing.Point(9, 42);
            this.Rv_VentasXMes.Name = "Rv_VentasXMes";
            this.Rv_VentasXMes.ServerReport.BearerToken = null;
            this.Rv_VentasXMes.Size = new System.Drawing.Size(756, 337);
            this.Rv_VentasXMes.TabIndex = 8;
            this.Rv_VentasXMes.Load += new System.EventHandler(this.Rv_VentasXMes_Load);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(108, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(43, 15);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Pp_mensajeError = null;
            this.txt_Mes.Pp_nombre_campo = null;
            this.txt_Mes.Pp_nombre_tabla = null;
            this.txt_Mes.Pp_validable = false;
            this.txt_Mes.Size = new System.Drawing.Size(59, 20);
            this.txt_Mes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Rv_MenorVentasMes);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.txtMes);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Día de menor ventas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Rv_MenorVentasMes
            // 
            this.Rv_MenorVentasMes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeDMenorVM.rdlc";
            this.Rv_MenorVentasMes.Location = new System.Drawing.Point(6, 45);
            this.Rv_MenorVentasMes.Name = "Rv_MenorVentasMes";
            this.Rv_MenorVentasMes.ServerReport.BearerToken = null;
            this.Rv_MenorVentasMes.Size = new System.Drawing.Size(756, 337);
            this.Rv_MenorVentasMes.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 16);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(48, 16);
            this.txtMes.Name = "txtMes";
            this.txtMes.Pp_mensajeError = null;
            this.txtMes.Pp_nombre_campo = null;
            this.txtMes.Pp_nombre_tabla = null;
            this.txtMes.Pp_validable = false;
            this.txtMes.Size = new System.Drawing.Size(69, 20);
            this.txtMes.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mes";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Rv_MVM);
            this.tabPage6.Controls.Add(this.btn_BuscMVM);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(768, 400);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Mes con mayores ventas";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Rv_MVM
            // 
            this.Rv_MVM.Location = new System.Drawing.Point(5, 29);
            this.Rv_MVM.Name = "Rv_MVM";
            this.Rv_MVM.ServerReport.BearerToken = null;
            this.Rv_MVM.Size = new System.Drawing.Size(755, 370);
            this.Rv_MVM.TabIndex = 8;
            // 
            // btn_BuscMVM
            // 
            this.btn_BuscMVM.Location = new System.Drawing.Point(5, 4);
            this.btn_BuscMVM.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BuscMVM.Name = "btn_BuscMVM";
            this.btn_BuscMVM.Size = new System.Drawing.Size(66, 20);
            this.btn_BuscMVM.TabIndex = 0;
            this.btn_BuscMVM.Text = "Buscar";
            this.btn_BuscMVM.UseVisualStyleBackColor = true;
            this.btn_BuscMVM.Click += new System.EventHandler(this.btn_BuscMVM_Click);
            // 
            // AE_VentasPorMonto
            // 
            this.AE_VentasPorMonto.Controls.Add(this.RV_AEVentxMonto);
            this.AE_VentasPorMonto.Controls.Add(this.label5);
            this.AE_VentasPorMonto.Controls.Add(this.cmb_EstPeriodo);
            this.AE_VentasPorMonto.Controls.Add(this.txt_Est_Monto);
            this.AE_VentasPorMonto.Controls.Add(this.label4);
            this.AE_VentasPorMonto.Controls.Add(this.btn_AEVentxMonto);
            this.AE_VentasPorMonto.Location = new System.Drawing.Point(4, 22);
            this.AE_VentasPorMonto.Margin = new System.Windows.Forms.Padding(2);
            this.AE_VentasPorMonto.Name = "AE_VentasPorMonto";
            this.AE_VentasPorMonto.Padding = new System.Windows.Forms.Padding(2);
            this.AE_VentasPorMonto.Size = new System.Drawing.Size(768, 400);
            this.AE_VentasPorMonto.TabIndex = 7;
            this.AE_VentasPorMonto.Text = "Análisis Estadístico Ventas por Monto";
            this.AE_VentasPorMonto.UseVisualStyleBackColor = true;
            // 
            // RV_AEVentxMonto
            // 
            this.RV_AEVentxMonto.Location = new System.Drawing.Point(7, 51);
            this.RV_AEVentxMonto.Name = "RV_AEVentxMonto";
            this.RV_AEVentxMonto.ServerReport.BearerToken = null;
            this.RV_AEVentxMonto.Size = new System.Drawing.Size(755, 348);
            this.RV_AEVentxMonto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estadística";
            // 
            // cmb_EstPeriodo
            // 
            this.cmb_EstPeriodo.FormattingEnabled = true;
            this.cmb_EstPeriodo.Items.AddRange(new object[] {
            "Gráfico de torta",
            "Gráfico de barras (horizontal)",
            "Gráfico de barras (vertical)"});
            this.cmb_EstPeriodo.Location = new System.Drawing.Point(224, 12);
            this.cmb_EstPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_EstPeriodo.Name = "cmb_EstPeriodo";
            this.cmb_EstPeriodo.Size = new System.Drawing.Size(149, 21);
            this.cmb_EstPeriodo.TabIndex = 3;
            // 
            // txt_Est_Monto
            // 
            this.txt_Est_Monto.Location = new System.Drawing.Point(44, 14);
            this.txt_Est_Monto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Est_Monto.Name = "txt_Est_Monto";
            this.txt_Est_Monto.Size = new System.Drawing.Size(97, 20);
            this.txt_Est_Monto.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monto";
            // 
            // btn_AEVentxMonto
            // 
            this.btn_AEVentxMonto.Location = new System.Drawing.Point(402, 9);
            this.btn_AEVentxMonto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AEVentxMonto.Name = "btn_AEVentxMonto";
            this.btn_AEVentxMonto.Size = new System.Drawing.Size(69, 25);
            this.btn_AEVentxMonto.TabIndex = 0;
            this.btn_AEVentxMonto.Text = "Mostrar";
            this.btn_AEVentxMonto.UseVisualStyleBackColor = true;
            this.btn_AEVentxMonto.Click += new System.EventHandler(this.btn_AEVentxMonto_Click);
            // 
            // Frm_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MasVentasMes);
            this.Name = "Frm_ReporteVentas";
            this.Text = "Frm_ReporteVentas";
            this.Load += new System.EventHandler(this.Frm_ReporteVentas_Load);
            this.MasVentasMes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.AE_VentasPorMonto.ResumeLayout(false);
            this.AE_VentasPorMonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MasVentasMes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Ventas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_TodasLasVentas;
        private Clases.TextBox01 txt_NroDoc;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_VentasXMonto;
        private System.Windows.Forms.Button Buscar;
        private Clases.TextBox01 txt_Monto;
        private System.Windows.Forms.Label label02;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label2;
		private Microsoft.Reporting.WinForms.ReportViewer Rv_VentasXMes;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_MVM;
        private System.Windows.Forms.Button btn_BuscMVM;
		private Clases.TextBox01 txt_Mes;
		private System.Windows.Forms.TabPage tabPage4;
		private Microsoft.Reporting.WinForms.ReportViewer Rv_MenorVentasMes;
		private System.Windows.Forms.Button button1;
		private Clases.TextBox01 txtMes;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage AE_VentasPorMonto;
        private System.Windows.Forms.TextBox txt_Est_Monto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AEVentxMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_EstPeriodo;
        private Microsoft.Reporting.WinForms.ReportViewer RV_AEVentxMonto;
    }
}