namespace PAV1_TP.Reportes.ReportesVentas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_TodasLasVentas = new System.Windows.Forms.CheckBox();
            this.Rv_Ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label02 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Rv_VentasXMonto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.txt_Monto = new PAV1_TP.Clases.TextBox01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage2.Controls.Add(this.txt_Monto);
            this.tabPage2.Controls.Add(this.label02);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas por monto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dias de mayor y menor ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(6, 12);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(37, 13);
            this.label02.TabIndex = 0;
            this.label02.Text = "Monto";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(155, 7);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Rv_VentasXMonto
            // 
            this.Rv_VentasXMonto.Location = new System.Drawing.Point(7, 41);
            this.Rv_VentasXMonto.Name = "Rv_VentasXMonto";
            this.Rv_VentasXMonto.ServerReport.BearerToken = null;
            this.Rv_VentasXMonto.Size = new System.Drawing.Size(755, 353);
            this.Rv_VentasXMonto.TabIndex = 3;
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
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(49, 7);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_mensajeError = null;
            this.txt_Monto.Pp_nombre_campo = null;
            this.txt_Monto.Pp_nombre_tabla = null;
            this.txt_Monto.Pp_validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(100, 20);
            this.txt_Monto.TabIndex = 1;
            // 
            // Frm_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReporteVentas";
            this.Text = "Frm_ReporteVentas";
            this.Load += new System.EventHandler(this.Frm_ReporteVentas_Load);
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
    }
}