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
			this.check_MenorV = new System.Windows.Forms.CheckBox();
			this.check_MayorV = new System.Windows.Forms.CheckBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txt_Mes = new PAV1_TP.Clases.TextBox01();
			this.nroMes = new System.Windows.Forms.Label();
			this.Rv_VentasPorEmp = new Microsoft.Reporting.WinForms.ReportViewer();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
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
			this.tabPage2.Controls.Add(this.check_MenorV);
			this.tabPage2.Controls.Add(this.check_MayorV);
			this.tabPage2.Controls.Add(this.btnBuscar);
			this.tabPage2.Controls.Add(this.txt_Mes);
			this.tabPage2.Controls.Add(this.nroMes);
			this.tabPage2.Controls.Add(this.Rv_VentasPorEmp);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(767, 409);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Ventas por Empleado";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// check_MenorV
			// 
			this.check_MenorV.AutoSize = true;
			this.check_MenorV.Location = new System.Drawing.Point(193, 33);
			this.check_MenorV.Name = "check_MenorV";
			this.check_MenorV.Size = new System.Drawing.Size(87, 17);
			this.check_MenorV.TabIndex = 15;
			this.check_MenorV.Text = "Menor Venta";
			this.check_MenorV.UseVisualStyleBackColor = true;
			// 
			// check_MayorV
			// 
			this.check_MayorV.AutoSize = true;
			this.check_MayorV.Location = new System.Drawing.Point(92, 33);
			this.check_MayorV.Name = "check_MayorV";
			this.check_MayorV.Size = new System.Drawing.Size(85, 17);
			this.check_MayorV.TabIndex = 14;
			this.check_MayorV.Text = "Mayor venta";
			this.check_MayorV.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(286, 8);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 13;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txt_Mes
			// 
			this.txt_Mes.Location = new System.Drawing.Point(92, 9);
			this.txt_Mes.Name = "txt_Mes";
			this.txt_Mes.Pp_mensajeError = null;
			this.txt_Mes.Pp_nombre_campo = null;
			this.txt_Mes.Pp_nombre_tabla = null;
			this.txt_Mes.Pp_validable = false;
			this.txt_Mes.Size = new System.Drawing.Size(188, 20);
			this.txt_Mes.TabIndex = 12;
			// 
			// nroMes
			// 
			this.nroMes.AutoSize = true;
			this.nroMes.Location = new System.Drawing.Point(5, 12);
			this.nroMes.Name = "nroMes";
			this.nroMes.Size = new System.Drawing.Size(81, 13);
			this.nroMes.TabIndex = 11;
			this.nroMes.Text = "Número de mes";
			// 
			// Rv_VentasPorEmp
			// 
			this.Rv_VentasPorEmp.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMasVentas.rdlc";
			this.Rv_VentasPorEmp.Location = new System.Drawing.Point(6, 56);
			this.Rv_VentasPorEmp.Name = "Rv_VentasPorEmp";
			this.Rv_VentasPorEmp.ServerReport.BearerToken = null;
			this.Rv_VentasPorEmp.Size = new System.Drawing.Size(754, 347);
			this.Rv_VentasPorEmp.TabIndex = 2;
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
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Empleado;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage2;
		private Microsoft.Reporting.WinForms.ReportViewer Rv_VentasPorEmp;
		private System.Windows.Forms.CheckBox check_MenorV;
		private System.Windows.Forms.CheckBox check_MayorV;
		private System.Windows.Forms.Button btnBuscar;
		private Clases.TextBox01 txt_Mes;
		private System.Windows.Forms.Label nroMes;
	}
}