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
			this.txt_Mes = new PAV1_TP.Clases.TextBox01();
			this.nroMes = new System.Windows.Forms.Label();
			this.Rv_EMPMayorVentas = new Microsoft.Reporting.WinForms.ReportViewer();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox011 = new PAV1_TP.Clases.TextBox01();
			this.label1 = new System.Windows.Forms.Label();
			this.Rv_EMPMenorVentas = new Microsoft.Reporting.WinForms.ReportViewer();
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
			this.tabPage2.Controls.Add(this.btnBuscar);
			this.tabPage2.Controls.Add(this.txt_Mes);
			this.tabPage2.Controls.Add(this.nroMes);
			this.tabPage2.Controls.Add(this.Rv_EMPMayorVentas);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(767, 409);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Empleado con mayor ventas";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(287, 16);
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
			this.txt_Mes.Location = new System.Drawing.Point(93, 17);
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
			this.nroMes.Location = new System.Drawing.Point(6, 20);
			this.nroMes.Name = "nroMes";
			this.nroMes.Size = new System.Drawing.Size(81, 13);
			this.nroMes.TabIndex = 11;
			this.nroMes.Text = "Número de mes";
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
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.Rv_EMPMenorVentas);
			this.tabPage3.Controls.Add(this.button1);
			this.tabPage3.Controls.Add(this.textBox011);
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(767, 409);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Empleado con menor ventas";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(293, 17);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox011
			// 
			this.textBox011.Location = new System.Drawing.Point(99, 18);
			this.textBox011.Name = "textBox011";
			this.textBox011.Pp_mensajeError = null;
			this.textBox011.Pp_nombre_campo = null;
			this.textBox011.Pp_nombre_tabla = null;
			this.textBox011.Pp_validable = false;
			this.textBox011.Size = new System.Drawing.Size(188, 20);
			this.textBox011.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Número de mes";
			// 
			// Rv_EMPMenorVentas
			// 
			this.Rv_EMPMenorVentas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMasVentas.rdlc";
			this.Rv_EMPMenorVentas.Location = new System.Drawing.Point(6, 57);
			this.Rv_EMPMenorVentas.Name = "Rv_EMPMenorVentas";
			this.Rv_EMPMenorVentas.ServerReport.BearerToken = null;
			this.Rv_EMPMenorVentas.Size = new System.Drawing.Size(754, 347);
			this.Rv_EMPMenorVentas.TabIndex = 17;
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
		private Clases.TextBox01 textBox011;
		private System.Windows.Forms.Label label1;
	}
}