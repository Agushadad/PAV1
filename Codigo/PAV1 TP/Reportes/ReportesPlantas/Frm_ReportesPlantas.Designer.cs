namespace PAV1_TP.Reportes.ReportesPlantas
{
    partial class Frm_ReportesPlantas
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CalcularTipoPlanta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_stdTipoPlanta = new PAV1_TP.Clases.ComboBox01();
            this.rv_stdTipoPlanta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_std_MesTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox011 = new PAV1_TP.Clases.TextBox01();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Rv_TPPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_TPPM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MesTPPM = new PAV1_TP.Clases.TextBox01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_PPM = new System.Windows.Forms.Button();
            this.Rv_PPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MesPPM = new PAV1_TP.Clases.TextBox01();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Rv_Plantas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.btn_CalcularTipoPlanta);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.cmb_stdTipoPlanta);
            this.tabPage5.Controls.Add(this.rv_stdTipoPlanta);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.txt_std_MesTipoPlanta);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(767, 410);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Análisis estadistico de tipo planta";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estadística";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mes";
            // 
            // btn_CalcularTipoPlanta
            // 
            this.btn_CalcularTipoPlanta.Location = new System.Drawing.Point(230, 38);
            this.btn_CalcularTipoPlanta.Name = "btn_CalcularTipoPlanta";
            this.btn_CalcularTipoPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_CalcularTipoPlanta.TabIndex = 19;
            this.btn_CalcularTipoPlanta.Text = "Calcular";
            this.btn_CalcularTipoPlanta.UseVisualStyleBackColor = true;
            this.btn_CalcularTipoPlanta.Click += new System.EventHandler(this.btn_CalcularTipoPlanta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // cmb_stdTipoPlanta
            // 
            this.cmb_stdTipoPlanta.FormattingEnabled = true;
            this.cmb_stdTipoPlanta.Items.AddRange(new object[] {
            "Gráfico de torta",
            "Gráfico de barras (horizontal)",
            "Gráfico de barras (vertical)"});
            this.cmb_stdTipoPlanta.Location = new System.Drawing.Point(66, 38);
            this.cmb_stdTipoPlanta.Name = "cmb_stdTipoPlanta";
            this.cmb_stdTipoPlanta.Pp_Display = null;
            this.cmb_stdTipoPlanta.Pp_mensajeError = null;
            this.cmb_stdTipoPlanta.Pp_nombre_campo = null;
            this.cmb_stdTipoPlanta.Pp_nombre_tabla = null;
            this.cmb_stdTipoPlanta.Pp_seleccionado = false;
            this.cmb_stdTipoPlanta.Pp_Tabla = null;
            this.cmb_stdTipoPlanta.Pp_validable = false;
            this.cmb_stdTipoPlanta.Pp_Value = null;
            this.cmb_stdTipoPlanta.Size = new System.Drawing.Size(158, 21);
            this.cmb_stdTipoPlanta.TabIndex = 17;
            // 
            // rv_stdTipoPlanta
            // 
            this.rv_stdTipoPlanta.Location = new System.Drawing.Point(0, 78);
            this.rv_stdTipoPlanta.Name = "rv_stdTipoPlanta";
            this.rv_stdTipoPlanta.ServerReport.BearerToken = null;
            this.rv_stdTipoPlanta.Size = new System.Drawing.Size(767, 304);
            this.rv_stdTipoPlanta.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // txt_std_MesTipoPlanta
            // 
            this.txt_std_MesTipoPlanta.Location = new System.Drawing.Point(66, 15);
            this.txt_std_MesTipoPlanta.Name = "txt_std_MesTipoPlanta";
            this.txt_std_MesTipoPlanta.Pp_mensajeError = null;
            this.txt_std_MesTipoPlanta.Pp_nombre_campo = null;
            this.txt_std_MesTipoPlanta.Pp_nombre_tabla = null;
            this.txt_std_MesTipoPlanta.Pp_validable = false;
            this.txt_std_MesTipoPlanta.Size = new System.Drawing.Size(62, 20);
            this.txt_std_MesTipoPlanta.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textBox011);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Análisis estadistico de plantas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(767, 239);
            this.reportViewer1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 15);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mes";
            // 
            // textBox011
            // 
            this.textBox011.Location = new System.Drawing.Point(44, 15);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_mensajeError = null;
            this.textBox011.Pp_nombre_campo = null;
            this.textBox011.Pp_nombre_tabla = null;
            this.textBox011.Pp_validable = false;
            this.textBox011.Size = new System.Drawing.Size(57, 20);
            this.textBox011.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Rv_TPPM);
            this.tabPage3.Controls.Add(this.btn_TPPM);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txt_MesTPPM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tipo de planta vendida por mes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Rv_TPPM
            // 
            this.Rv_TPPM.Location = new System.Drawing.Point(11, 44);
            this.Rv_TPPM.Name = "Rv_TPPM";
            this.Rv_TPPM.ServerReport.BearerToken = null;
            this.Rv_TPPM.Size = new System.Drawing.Size(755, 353);
            this.Rv_TPPM.TabIndex = 15;
            // 
            // btn_TPPM
            // 
            this.btn_TPPM.Location = new System.Drawing.Point(110, 14);
            this.btn_TPPM.Name = "btn_TPPM";
            this.btn_TPPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_TPPM.Size = new System.Drawing.Size(75, 23);
            this.btn_TPPM.TabIndex = 14;
            this.btn_TPPM.Text = "Buscar";
            this.btn_TPPM.UseVisualStyleBackColor = true;
            this.btn_TPPM.Click += new System.EventHandler(this.btn_TPPM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mes";
            // 
            // txt_MesTPPM
            // 
            this.txt_MesTPPM.Location = new System.Drawing.Point(41, 14);
            this.txt_MesTPPM.Name = "txt_MesTPPM";
            this.txt_MesTPPM.Pp_mensajeError = null;
            this.txt_MesTPPM.Pp_nombre_campo = null;
            this.txt_MesTPPM.Pp_nombre_tabla = null;
            this.txt_MesTPPM.Pp_validable = false;
            this.txt_MesTPPM.Size = new System.Drawing.Size(63, 20);
            this.txt_MesTPPM.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_PPM);
            this.tabPage2.Controls.Add(this.Rv_PPM);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_MesPPM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plantas vendidas por mes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_PPM
            // 
            this.btn_PPM.Location = new System.Drawing.Point(111, 14);
            this.btn_PPM.Name = "btn_PPM";
            this.btn_PPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_PPM.Size = new System.Drawing.Size(75, 23);
            this.btn_PPM.TabIndex = 11;
            this.btn_PPM.Text = "Buscar";
            this.btn_PPM.UseVisualStyleBackColor = true;
            this.btn_PPM.Click += new System.EventHandler(this.btn_PPM_Click);
            // 
            // Rv_PPM
            // 
            this.Rv_PPM.Location = new System.Drawing.Point(15, 40);
            this.Rv_PPM.Name = "Rv_PPM";
            this.Rv_PPM.ServerReport.BearerToken = null;
            this.Rv_PPM.Size = new System.Drawing.Size(755, 353);
            this.Rv_PPM.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mes";
            // 
            // txt_MesPPM
            // 
            this.txt_MesPPM.Location = new System.Drawing.Point(48, 14);
            this.txt_MesPPM.Name = "txt_MesPPM";
            this.txt_MesPPM.Pp_mensajeError = null;
            this.txt_MesPPM.Pp_nombre_campo = null;
            this.txt_MesPPM.Pp_nombre_tabla = null;
            this.txt_MesPPM.Pp_validable = false;
            this.txt_MesPPM.Size = new System.Drawing.Size(57, 20);
            this.txt_MesPPM.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rv_Plantas);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin restriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rv_Plantas
            // 
            this.Rv_Plantas.Location = new System.Drawing.Point(4, 37);
            this.Rv_Plantas.Name = "Rv_Plantas";
            this.Rv_Plantas.ServerReport.BearerToken = null;
            this.Rv_Plantas.Size = new System.Drawing.Size(757, 366);
            this.Rv_Plantas.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(7, 7);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // Frm_ReportesPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesPlantas";
            this.Text = "Frm_ReportesPlantas";
            this.Load += new System.EventHandler(this.Frm_ReportesPlantas_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CalcularTipoPlanta;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmb_stdTipoPlanta;
        private Microsoft.Reporting.WinForms.ReportViewer rv_stdTipoPlanta;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_std_MesTipoPlanta;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_TPPM;
        private System.Windows.Forms.Button btn_TPPM;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_MesTPPM;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_PPM;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_PPM;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_MesPPM;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Plantas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabControl tabControl1;
    }
}