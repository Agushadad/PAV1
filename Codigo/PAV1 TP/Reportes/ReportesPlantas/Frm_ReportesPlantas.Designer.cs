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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Rv_Plantas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_PPM = new System.Windows.Forms.Button();
            this.Rv_PPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MesPPM = new PAV1_TP.Clases.TextBox01();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Rv_TPPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_TPPM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MesTPPM = new PAV1_TP.Clases.TextBox01();
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
            this.tabControl1.Size = new System.Drawing.Size(775, 436);
            this.tabControl1.TabIndex = 0;
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
            // Frm_ReportesPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesPlantas";
            this.Text = "Frm_ReportesPlantas";
            this.Load += new System.EventHandler(this.Frm_ReportesPlantas_Load);
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
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Plantas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_PPM;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_MesPPM;
        private System.Windows.Forms.Button btn_PPM;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_TPPM;
        private System.Windows.Forms.Button btn_TPPM;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_MesTPPM;
    }
}