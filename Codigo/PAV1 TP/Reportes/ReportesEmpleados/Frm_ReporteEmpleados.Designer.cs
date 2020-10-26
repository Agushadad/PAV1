namespace PAV1_TP.Reportes.ReportesEmpleados
{
    partial class Frm_ReporteEmpleados
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
            this.Rv_Empleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nroMes = new System.Windows.Forms.Label();
            this.Rv_EMPMayorVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_Mes = new PAV1_TP.Clases.TextBox01();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Rv_EMPMenorVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MesMenor = new PAV1_TP.Clases.TextBox01();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_FechaHasta = new PAV1_TP.Clases.LabelText01();
            this.txt_FechaDesde = new PAV1_TP.Clases.LabelText01();
            this.rp_Empleado_Periodo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_BuscarPeriodo4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_EstPeriodo = new PAV1_TP.Clases.ComboBox01();
            this.rv_AnalisisPeriodo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_CalcularESTPeriodo = new System.Windows.Forms.Button();
            this.ltxt_Hasta2 = new PAV1_TP.Clases.LabelText01();
            this.ltxt_Desde2 = new PAV1_TP.Clases.LabelText01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rv_Empleado);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin restriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rv_Empleado
            // 
            this.Rv_Empleado.Location = new System.Drawing.Point(7, 36);
            this.Rv_Empleado.Name = "Rv_Empleado";
            this.Rv_Empleado.ServerReport.BearerToken = null;
            this.Rv_Empleado.Size = new System.Drawing.Size(754, 367);
            this.Rv_Empleado.TabIndex = 1;
            this.Rv_Empleado.Load += new System.EventHandler(this.Rv_Empleado_Load);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(7, 7);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.nroMes);
            this.tabPage2.Controls.Add(this.Rv_EMPMayorVentas);
            this.tabPage2.Controls.Add(this.txt_Mes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleado con mayor ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(112, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nroMes
            // 
            this.nroMes.AutoSize = true;
            this.nroMes.Location = new System.Drawing.Point(16, 20);
            this.nroMes.Name = "nroMes";
            this.nroMes.Size = new System.Drawing.Size(27, 13);
            this.nroMes.TabIndex = 11;
            this.nroMes.Text = "Mes";
            this.nroMes.Click += new System.EventHandler(this.nroMes_Click);
            // 
            // Rv_EMPMayorVentas
            // 
            this.Rv_EMPMayorVentas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMasVentas.rdlc";
            this.Rv_EMPMayorVentas.Location = new System.Drawing.Point(6, 56);
            this.Rv_EMPMayorVentas.Name = "Rv_EMPMayorVentas";
            this.Rv_EMPMayorVentas.ServerReport.BearerToken = null;
            this.Rv_EMPMayorVentas.Size = new System.Drawing.Size(754, 347);
            this.Rv_EMPMayorVentas.TabIndex = 2;
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(49, 19);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Pp_mensajeError = null;
            this.txt_Mes.Pp_nombre_campo = null;
            this.txt_Mes.Pp_nombre_tabla = null;
            this.txt_Mes.Pp_validable = false;
            this.txt_Mes.Size = new System.Drawing.Size(57, 20);
            this.txt_Mes.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Rv_EMPMenorVentas);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txt_MesMenor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Empleado con menor ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Rv_EMPMenorVentas
            // 
            this.Rv_EMPMenorVentas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMasVentas.rdlc";
            this.Rv_EMPMenorVentas.Location = new System.Drawing.Point(3, 49);
            this.Rv_EMPMenorVentas.Name = "Rv_EMPMenorVentas";
            this.Rv_EMPMenorVentas.ServerReport.BearerToken = null;
            this.Rv_EMPMenorVentas.Size = new System.Drawing.Size(754, 347);
            this.Rv_EMPMenorVentas.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 20);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mes";
            // 
            // txt_MesMenor
            // 
            this.txt_MesMenor.Location = new System.Drawing.Point(45, 20);
            this.txt_MesMenor.Name = "txt_MesMenor";
            this.txt_MesMenor.Pp_mensajeError = null;
            this.txt_MesMenor.Pp_nombre_campo = null;
            this.txt_MesMenor.Pp_nombre_tabla = null;
            this.txt_MesMenor.Pp_validable = false;
            this.txt_MesMenor.Size = new System.Drawing.Size(50, 20);
            this.txt_MesMenor.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_FechaHasta);
            this.tabPage4.Controls.Add(this.txt_FechaDesde);
            this.tabPage4.Controls.Add(this.rp_Empleado_Periodo);
            this.tabPage4.Controls.Add(this.btn_BuscarPeriodo4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Empleados con ventas en periodo";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // txt_FechaHasta
            // 
            this.txt_FechaHasta.BackColor = System.Drawing.Color.Transparent;
            this.txt_FechaHasta.Location = new System.Drawing.Point(144, 15);
            this.txt_FechaHasta.Name = "txt_FechaHasta";
            this.txt_FechaHasta.Pp_Etiqueta = "Hasta";
            this.txt_FechaHasta.Pp_Mascara = "00/00/0000";
            this.txt_FechaHasta.Pp_mensajeError = "No se cargo Fecha Hasta";
            this.txt_FechaHasta.Pp_nombre_campo = null;
            this.txt_FechaHasta.Pp_nombre_tabla = null;
            this.txt_FechaHasta.Pp_Text = "  /  /";
            this.txt_FechaHasta.Pp_validable = false;
            this.txt_FechaHasta.Size = new System.Drawing.Size(155, 30);
            this.txt_FechaHasta.TabIndex = 9;
            // 
            // txt_FechaDesde
            // 
            this.txt_FechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.txt_FechaDesde.Location = new System.Drawing.Point(9, 15);
            this.txt_FechaDesde.Name = "txt_FechaDesde";
            this.txt_FechaDesde.Pp_Etiqueta = "Desde";
            this.txt_FechaDesde.Pp_Mascara = "00/00/0000";
            this.txt_FechaDesde.Pp_mensajeError = "No se cargo fecha Desde";
            this.txt_FechaDesde.Pp_nombre_campo = null;
            this.txt_FechaDesde.Pp_nombre_tabla = null;
            this.txt_FechaDesde.Pp_Text = "  /  /";
            this.txt_FechaDesde.Pp_validable = false;
            this.txt_FechaDesde.Size = new System.Drawing.Size(159, 30);
            this.txt_FechaDesde.TabIndex = 8;
            // 
            // rp_Empleado_Periodo
            // 
            this.rp_Empleado_Periodo.Location = new System.Drawing.Point(9, 54);
            this.rp_Empleado_Periodo.Name = "rp_Empleado_Periodo";
            this.rp_Empleado_Periodo.ServerReport.BearerToken = null;
            this.rp_Empleado_Periodo.Size = new System.Drawing.Size(736, 337);
            this.rp_Empleado_Periodo.TabIndex = 7;
            // 
            // btn_BuscarPeriodo4
            // 
            this.btn_BuscarPeriodo4.Location = new System.Drawing.Point(670, 25);
            this.btn_BuscarPeriodo4.Name = "btn_BuscarPeriodo4";
            this.btn_BuscarPeriodo4.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarPeriodo4.TabIndex = 0;
            this.btn_BuscarPeriodo4.Text = "Buscar";
            this.btn_BuscarPeriodo4.UseVisualStyleBackColor = true;
            this.btn_BuscarPeriodo4.Click += new System.EventHandler(this.btn_BuscarPeriodo4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.cmb_EstPeriodo);
            this.tabPage5.Controls.Add(this.rv_AnalisisPeriodo);
            this.tabPage5.Controls.Add(this.btn_CalcularESTPeriodo);
            this.tabPage5.Controls.Add(this.ltxt_Hasta2);
            this.tabPage5.Controls.Add(this.ltxt_Desde2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(767, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Analisis Estadistico ventas x periodo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Estadística";
            // 
            // cmb_EstPeriodo
            // 
            this.cmb_EstPeriodo.FormattingEnabled = true;
            this.cmb_EstPeriodo.Items.AddRange(new object[] {
            "Gráfico de torta",
            "Gráfico de barras (horizontal)",
            "Gráfico de barras (vertical)"});
            this.cmb_EstPeriodo.Location = new System.Drawing.Point(69, 42);
            this.cmb_EstPeriodo.Name = "cmb_EstPeriodo";
            this.cmb_EstPeriodo.Pp_Display = null;
            this.cmb_EstPeriodo.Pp_mensajeError = null;
            this.cmb_EstPeriodo.Pp_nombre_campo = null;
            this.cmb_EstPeriodo.Pp_nombre_tabla = null;
            this.cmb_EstPeriodo.Pp_seleccionado = false;
            this.cmb_EstPeriodo.Pp_Tabla = null;
            this.cmb_EstPeriodo.Pp_validable = false;
            this.cmb_EstPeriodo.Pp_Value = null;
            this.cmb_EstPeriodo.Size = new System.Drawing.Size(158, 21);
            this.cmb_EstPeriodo.TabIndex = 22;
            // 
            // rv_AnalisisPeriodo
            // 
            this.rv_AnalisisPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_AnalisisPeriodo.Location = new System.Drawing.Point(7, 71);
            this.rv_AnalisisPeriodo.Name = "rv_AnalisisPeriodo";
            this.rv_AnalisisPeriodo.ServerReport.BearerToken = null;
            this.rv_AnalisisPeriodo.Size = new System.Drawing.Size(754, 332);
            this.rv_AnalisisPeriodo.TabIndex = 3;
            // 
            // btn_CalcularESTPeriodo
            // 
            this.btn_CalcularESTPeriodo.Location = new System.Drawing.Point(254, 40);
            this.btn_CalcularESTPeriodo.Name = "btn_CalcularESTPeriodo";
            this.btn_CalcularESTPeriodo.Size = new System.Drawing.Size(75, 23);
            this.btn_CalcularESTPeriodo.TabIndex = 2;
            this.btn_CalcularESTPeriodo.Text = "Calcular";
            this.btn_CalcularESTPeriodo.UseVisualStyleBackColor = true;
            this.btn_CalcularESTPeriodo.Click += new System.EventHandler(this.btn_CalcularESTPeriodo_Click);
            // 
            // ltxt_Hasta2
            // 
            this.ltxt_Hasta2.BackColor = System.Drawing.Color.Transparent;
            this.ltxt_Hasta2.Location = new System.Drawing.Point(152, 3);
            this.ltxt_Hasta2.Name = "ltxt_Hasta2";
            this.ltxt_Hasta2.Pp_Etiqueta = "Hasta";
            this.ltxt_Hasta2.Pp_Mascara = "00/00/0000";
            this.ltxt_Hasta2.Pp_mensajeError = null;
            this.ltxt_Hasta2.Pp_nombre_campo = null;
            this.ltxt_Hasta2.Pp_nombre_tabla = null;
            this.ltxt_Hasta2.Pp_Text = "  /  /";
            this.ltxt_Hasta2.Pp_validable = false;
            this.ltxt_Hasta2.Size = new System.Drawing.Size(156, 30);
            this.ltxt_Hasta2.TabIndex = 1;
            // 
            // ltxt_Desde2
            // 
            this.ltxt_Desde2.BackColor = System.Drawing.Color.Transparent;
            this.ltxt_Desde2.Location = new System.Drawing.Point(18, 3);
            this.ltxt_Desde2.Name = "ltxt_Desde2";
            this.ltxt_Desde2.Pp_Etiqueta = "Desde";
            this.ltxt_Desde2.Pp_Mascara = "00/00/0000";
            this.ltxt_Desde2.Pp_mensajeError = null;
            this.ltxt_Desde2.Pp_nombre_campo = null;
            this.ltxt_Desde2.Pp_nombre_tabla = null;
            this.ltxt_Desde2.Pp_Text = "  /  /";
            this.ltxt_Desde2.Pp_validable = false;
            this.ltxt_Desde2.Size = new System.Drawing.Size(157, 30);
            this.ltxt_Desde2.TabIndex = 0;
            // 
            // Frm_ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReporteEmpleados";
            this.Text = "Frm_ReporteEmpleados";
            this.Load += new System.EventHandler(this.Frm_ReporteEmpleados_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Empleado;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage2;
		private Microsoft.Reporting.WinForms.ReportViewer Rv_EMPMayorVentas;
		private System.Windows.Forms.Button btnBuscar;
		private Clases.TextBox01 txt_Mes;
		private System.Windows.Forms.Label nroMes;
		private System.Windows.Forms.TabPage tabPage3;
		private Microsoft.Reporting.WinForms.ReportViewer Rv_EMPMenorVentas;
		private System.Windows.Forms.Button button1;
		private Clases.TextBox01 txt_MesMenor;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer rp_Empleado_Periodo;
        private System.Windows.Forms.Button btn_BuscarPeriodo4;
        private Clases.LabelText01 txt_FechaHasta;
        private Clases.LabelText01 txt_FechaDesde;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer rv_AnalisisPeriodo;
        private System.Windows.Forms.Button btn_CalcularESTPeriodo;
        private Clases.LabelText01 ltxt_Hasta2;
        private Clases.LabelText01 ltxt_Desde2;
        private System.Windows.Forms.Label label7;
        private Clases.ComboBox01 cmb_EstPeriodo;
    }
}