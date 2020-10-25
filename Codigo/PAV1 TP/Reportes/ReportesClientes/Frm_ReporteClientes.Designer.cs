namespace PAV1_TP.Formularios.Reportes
{
    partial class Frm_ReporteClientes
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
            this.tbControl1 = new System.Windows.Forms.TabControl();
            this.SinRestricción = new System.Windows.Forms.TabPage();
            this.Rv_Clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.chk_TodosClientes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new PAV1_TP.Clases.TextBox01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rv_ClienMC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv_CanjeCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_BuscarCanje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Mes = new PAV1_TP.Clases.TextBox01();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RV_MayCompCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbControl1.SuspendLayout();
            this.SinRestricción.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl1
            // 
            this.tbControl1.Controls.Add(this.SinRestricción);
            this.tbControl1.Controls.Add(this.tabPage2);
            this.tbControl1.Controls.Add(this.tabPage1);
            this.tbControl1.Controls.Add(this.tabPage3);
            this.tbControl1.Location = new System.Drawing.Point(3, 7);
            this.tbControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbControl1.Name = "tbControl1";
            this.tbControl1.SelectedIndex = 0;
            this.tbControl1.Size = new System.Drawing.Size(909, 491);
            this.tbControl1.TabIndex = 0;
            // 
            // SinRestricción
            // 
            this.SinRestricción.Controls.Add(this.Rv_Clientes);
            this.SinRestricción.Controls.Add(this.btn_Buscar);
            this.SinRestricción.Controls.Add(this.chk_TodosClientes);
            this.SinRestricción.Controls.Add(this.label2);
            this.SinRestricción.Controls.Add(this.txt_NombreCliente);
            this.SinRestricción.Location = new System.Drawing.Point(4, 25);
            this.SinRestricción.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SinRestricción.Name = "SinRestricción";
            this.SinRestricción.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SinRestricción.Size = new System.Drawing.Size(901, 462);
            this.SinRestricción.TabIndex = 0;
            this.SinRestricción.Text = "Sin Restricción";
            this.SinRestricción.UseVisualStyleBackColor = true;
            // 
            // Rv_Clientes
            // 
            this.Rv_Clientes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeCliente.rdlc";
            this.Rv_Clientes.Location = new System.Drawing.Point(13, 76);
            this.Rv_Clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rv_Clientes.Name = "Rv_Clientes";
            this.Rv_Clientes.ServerReport.BearerToken = null;
            this.Rv_Clientes.Size = new System.Drawing.Size(890, 349);
            this.Rv_Clientes.TabIndex = 13;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(232, 43);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(77, 28);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // chk_TodosClientes
            // 
            this.chk_TodosClientes.AutoSize = true;
            this.chk_TodosClientes.Location = new System.Drawing.Point(75, 48);
            this.chk_TodosClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_TodosClientes.Name = "chk_TodosClientes";
            this.chk_TodosClientes.Size = new System.Drawing.Size(146, 21);
            this.chk_TodosClientes.TabIndex = 11;
            this.chk_TodosClientes.Text = "Todos los Clientes";
            this.chk_TodosClientes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(75, 16);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Pp_mensajeError = null;
            this.txt_NombreCliente.Pp_nombre_campo = null;
            this.txt_NombreCliente.Pp_nombre_tabla = null;
            this.txt_NombreCliente.Pp_validable = false;
            this.txt_NombreCliente.Size = new System.Drawing.Size(233, 22);
            this.txt_NombreCliente.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Rv_ClienMC);
            this.tabPage2.Controls.Add(this.btn_BuscarCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(901, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mayor compra x cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Rv_ClienMC
            // 
            this.Rv_ClienMC.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeCliente.rdlc";
            this.Rv_ClienMC.Location = new System.Drawing.Point(3, 66);
            this.Rv_ClienMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rv_ClienMC.Name = "Rv_ClienMC";
            this.Rv_ClienMC.ServerReport.BearerToken = null;
            this.Rv_ClienMC.Size = new System.Drawing.Size(890, 392);
            this.Rv_ClienMC.TabIndex = 14;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(24, 18);
            this.btn_BuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(93, 30);
            this.btn_BuscarCliente.TabIndex = 0;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_CanjeCliente);
            this.tabPage1.Controls.Add(this.btn_BuscarCanje);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_Mes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(901, 462);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Cliente con mas canjes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv_CanjeCliente
            // 
            this.rv_CanjeCliente.Location = new System.Drawing.Point(8, 41);
            this.rv_CanjeCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_CanjeCliente.Name = "rv_CanjeCliente";
            this.rv_CanjeCliente.ServerReport.BearerToken = null;
            this.rv_CanjeCliente.Size = new System.Drawing.Size(882, 409);
            this.rv_CanjeCliente.TabIndex = 7;
            // 
            // btn_BuscarCanje
            // 
            this.btn_BuscarCanje.Location = new System.Drawing.Point(137, 7);
            this.btn_BuscarCanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BuscarCanje.Name = "btn_BuscarCanje";
            this.btn_BuscarCanje.Size = new System.Drawing.Size(100, 28);
            this.btn_BuscarCanje.TabIndex = 6;
            this.btn_BuscarCanje.Text = "Buscar";
            this.btn_BuscarCanje.UseVisualStyleBackColor = true;
            this.btn_BuscarCanje.Click += new System.EventHandler(this.btn_BuscarCanje_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mes";
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(52, 7);
            this.txt_Mes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Pp_mensajeError = null;
            this.txt_Mes.Pp_nombre_campo = null;
            this.txt_Mes.Pp_nombre_tabla = null;
            this.txt_Mes.Pp_validable = false;
            this.txt_Mes.Size = new System.Drawing.Size(76, 22);
            this.txt_Mes.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RV_MayCompCliente);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 462);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Análisis Estadístico Mayor Compra por Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estadística";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // RV_MayCompCliente
            // 
            this.RV_MayCompCliente.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeCliente.rdlc";
            this.RV_MayCompCliente.Location = new System.Drawing.Point(4, 66);
            this.RV_MayCompCliente.Margin = new System.Windows.Forms.Padding(4);
            this.RV_MayCompCliente.Name = "RV_MayCompCliente";
            this.RV_MayCompCliente.ServerReport.BearerToken = null;
            this.RV_MayCompCliente.Size = new System.Drawing.Size(890, 392);
            this.RV_MayCompCliente.TabIndex = 15;
            // 
            // Frm_ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 500);
            this.Controls.Add(this.tbControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ReporteClientes";
            this.Text = "Reporte de Clientes";
            this.Load += new System.EventHandler(this.Frm_ReporteClientes_Load);
            this.tbControl1.ResumeLayout(false);
            this.SinRestricción.ResumeLayout(false);
            this.SinRestricción.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl1;
        private System.Windows.Forms.TabPage SinRestricción;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Clientes;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.CheckBox chk_TodosClientes;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_NombreCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_ClienMC;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_CanjeCliente;
        private System.Windows.Forms.Button btn_BuscarCanje;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_Mes;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer RV_MayCompCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}