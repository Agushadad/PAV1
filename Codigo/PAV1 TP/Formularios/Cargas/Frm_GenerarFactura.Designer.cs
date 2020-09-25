namespace PAV1_TP.Formularios.Cargas
{
    partial class Frm_GenerarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GenerarFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.btn_Fehca = new System.Windows.Forms.Button();
            this.labelText013 = new PAV1_TP.Clases.LabelText01();
            this.labelText012 = new PAV1_TP.Clases.LabelText01();
            this.txt_TipoDoc = new PAV1_TP.Clases.TextBox01();
            this.txt_IdFactura = new PAV1_TP.Clases.TextBox01();
            this.cmb_TipoFactura = new PAV1_TP.Clases.ComboBox01();
            this.ltxt_DocCliente = new PAV1_TP.Clases.LabelText01();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Monto = new PAV1_TP.Clases.TextBox01();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Plantas = new PAV1_TP.Clases.ComboBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CantidadPlant = new PAV1_TP.Clases.TextBox01();
            this.btn_AgregarPlanta = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Productos = new PAV1_TP.Clases.ComboBox01();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CantidadProd = new PAV1_TP.Clases.TextBox01();
            this.btn_AgregarProd = new System.Windows.Forms.Button();
            this.btn_Generar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Generar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nro Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo Doc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Generar Factura";
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(221, 48);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(61, 23);
            this.btn_BuscarCliente.TabIndex = 8;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // btn_Fehca
            // 
            this.btn_Fehca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fehca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fehca.Location = new System.Drawing.Point(179, 188);
            this.btn_Fehca.Name = "btn_Fehca";
            this.btn_Fehca.Size = new System.Drawing.Size(36, 23);
            this.btn_Fehca.TabIndex = 10;
            this.btn_Fehca.Text = "...";
            this.btn_Fehca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fehca.UseVisualStyleBackColor = true;
            // 
            // labelText013
            // 
            this.labelText013.BackColor = System.Drawing.Color.Transparent;
            this.labelText013.Location = new System.Drawing.Point(24, 159);
            this.labelText013.Name = "labelText013";
            this.labelText013.Pp_Etiqueta = "IdEmpleado";
            this.labelText013.Pp_Mascara = "";
            this.labelText013.Size = new System.Drawing.Size(158, 30);
            this.labelText013.TabIndex = 11;
            // 
            // labelText012
            // 
            this.labelText012.BackColor = System.Drawing.Color.Transparent;
            this.labelText012.Location = new System.Drawing.Point(25, 188);
            this.labelText012.Name = "labelText012";
            this.labelText012.Pp_Etiqueta = "Fecha";
            this.labelText012.Pp_Mascara = "00/00/0000";
            this.labelText012.Size = new System.Drawing.Size(157, 30);
            this.labelText012.TabIndex = 9;
            // 
            // txt_TipoDoc
            // 
            this.txt_TipoDoc.Enabled = false;
            this.txt_TipoDoc.Location = new System.Drawing.Point(106, 77);
            this.txt_TipoDoc.Name = "txt_TipoDoc";
            this.txt_TipoDoc.Pp_mensajeError = null;
            this.txt_TipoDoc.Pp_nombre_campo = null;
            this.txt_TipoDoc.Pp_nombre_tabla = null;
            this.txt_TipoDoc.Pp_validable = false;
            this.txt_TipoDoc.Size = new System.Drawing.Size(121, 20);
            this.txt_TipoDoc.TabIndex = 6;
            // 
            // txt_IdFactura
            // 
            this.txt_IdFactura.Enabled = false;
            this.txt_IdFactura.Location = new System.Drawing.Point(106, 106);
            this.txt_IdFactura.Name = "txt_IdFactura";
            this.txt_IdFactura.Pp_mensajeError = null;
            this.txt_IdFactura.Pp_nombre_campo = null;
            this.txt_IdFactura.Pp_nombre_tabla = null;
            this.txt_IdFactura.Pp_validable = false;
            this.txt_IdFactura.Size = new System.Drawing.Size(121, 20);
            this.txt_IdFactura.TabIndex = 2;
            // 
            // cmb_TipoFactura
            // 
            this.cmb_TipoFactura.FormattingEnabled = true;
            this.cmb_TipoFactura.Location = new System.Drawing.Point(106, 132);
            this.cmb_TipoFactura.Name = "cmb_TipoFactura";
            this.cmb_TipoFactura.Pp_Display = "Nombre";
            this.cmb_TipoFactura.Pp_mensajeError = null;
            this.cmb_TipoFactura.Pp_nombre_campo = null;
            this.cmb_TipoFactura.Pp_nombre_tabla = "TipoFactura";
            this.cmb_TipoFactura.Pp_seleccionado = false;
            this.cmb_TipoFactura.Pp_Tabla = "TipoFactura";
            this.cmb_TipoFactura.Pp_validable = false;
            this.cmb_TipoFactura.Pp_Value = "ID";
            this.cmb_TipoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoFactura.TabIndex = 1;
            // 
            // ltxt_DocCliente
            // 
            this.ltxt_DocCliente.BackColor = System.Drawing.Color.Transparent;
            this.ltxt_DocCliente.Location = new System.Drawing.Point(25, 48);
            this.ltxt_DocCliente.Name = "ltxt_DocCliente";
            this.ltxt_DocCliente.Pp_Etiqueta = "NroDoc";
            this.ltxt_DocCliente.Pp_Mascara = "99.999.999";
            this.ltxt_DocCliente.Size = new System.Drawing.Size(190, 30);
            this.ltxt_DocCliente.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(37, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nro Factura";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Enabled = false;
            this.txt_Monto.Location = new System.Drawing.Point(106, 224);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_mensajeError = null;
            this.txt_Monto.Pp_nombre_campo = null;
            this.txt_Monto.Pp_nombre_tabla = null;
            this.txt_Monto.Pp_validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(121, 20);
            this.txt_Monto.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 121);
            this.dataGridView1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Plantas";
            // 
            // cmb_Plantas
            // 
            this.cmb_Plantas.FormattingEnabled = true;
            this.cmb_Plantas.Location = new System.Drawing.Point(388, 45);
            this.cmb_Plantas.Name = "cmb_Plantas";
            this.cmb_Plantas.Pp_Display = null;
            this.cmb_Plantas.Pp_mensajeError = null;
            this.cmb_Plantas.Pp_nombre_campo = null;
            this.cmb_Plantas.Pp_nombre_tabla = null;
            this.cmb_Plantas.Pp_seleccionado = false;
            this.cmb_Plantas.Pp_Tabla = null;
            this.cmb_Plantas.Pp_validable = false;
            this.cmb_Plantas.Pp_Value = null;
            this.cmb_Plantas.Size = new System.Drawing.Size(188, 21);
            this.cmb_Plantas.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Tag = "Cantidad";
            this.label7.Text = "Cantidad";
            // 
            // txt_CantidadPlant
            // 
            this.txt_CantidadPlant.Location = new System.Drawing.Point(389, 77);
            this.txt_CantidadPlant.Name = "txt_CantidadPlant";
            this.txt_CantidadPlant.Pp_mensajeError = null;
            this.txt_CantidadPlant.Pp_nombre_campo = null;
            this.txt_CantidadPlant.Pp_nombre_tabla = null;
            this.txt_CantidadPlant.Pp_validable = false;
            this.txt_CantidadPlant.Size = new System.Drawing.Size(69, 20);
            this.txt_CantidadPlant.TabIndex = 21;
            // 
            // btn_AgregarPlanta
            // 
            this.btn_AgregarPlanta.Location = new System.Drawing.Point(464, 77);
            this.btn_AgregarPlanta.Name = "btn_AgregarPlanta";
            this.btn_AgregarPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarPlanta.TabIndex = 22;
            this.btn_AgregarPlanta.Text = "Agregar";
            this.btn_AgregarPlanta.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(343, 310);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(314, 121);
            this.dataGridView2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Productos";
            // 
            // cmb_Productos
            // 
            this.cmb_Productos.FormattingEnabled = true;
            this.cmb_Productos.Location = new System.Drawing.Point(388, 246);
            this.cmb_Productos.Name = "cmb_Productos";
            this.cmb_Productos.Pp_Display = null;
            this.cmb_Productos.Pp_mensajeError = null;
            this.cmb_Productos.Pp_nombre_campo = null;
            this.cmb_Productos.Pp_nombre_tabla = null;
            this.cmb_Productos.Pp_seleccionado = false;
            this.cmb_Productos.Pp_Tabla = null;
            this.cmb_Productos.Pp_validable = false;
            this.cmb_Productos.Pp_Value = null;
            this.cmb_Productos.Size = new System.Drawing.Size(188, 21);
            this.cmb_Productos.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Tag = "Cantidad";
            this.label9.Text = "Cantidad";
            // 
            // txt_CantidadProd
            // 
            this.txt_CantidadProd.Location = new System.Drawing.Point(389, 273);
            this.txt_CantidadProd.Name = "txt_CantidadProd";
            this.txt_CantidadProd.Pp_mensajeError = null;
            this.txt_CantidadProd.Pp_nombre_campo = null;
            this.txt_CantidadProd.Pp_nombre_tabla = null;
            this.txt_CantidadProd.Pp_validable = false;
            this.txt_CantidadProd.Size = new System.Drawing.Size(69, 20);
            this.txt_CantidadProd.TabIndex = 21;
            // 
            // btn_AgregarProd
            // 
            this.btn_AgregarProd.Location = new System.Drawing.Point(464, 273);
            this.btn_AgregarProd.Name = "btn_AgregarProd";
            this.btn_AgregarProd.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarProd.TabIndex = 22;
            this.btn_AgregarProd.Text = "Agregar";
            this.btn_AgregarProd.UseVisualStyleBackColor = true;
            // 
            // btn_Generar
            // 
            this.btn_Generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Generar.Image")));
            this.btn_Generar.Location = new System.Drawing.Point(184, 257);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(43, 39);
            this.btn_Generar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Generar.TabIndex = 23;
            this.btn_Generar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.Location = new System.Drawing.Point(127, 257);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(42, 39);
            this.btn_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Cancelar.TabIndex = 25;
            this.btn_Cancelar.TabStop = false;
            // 
            // Frm_GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 443);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.btn_AgregarProd);
            this.Controls.Add(this.btn_AgregarPlanta);
            this.Controls.Add(this.txt_CantidadProd);
            this.Controls.Add(this.txt_CantidadPlant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Productos);
            this.Controls.Add(this.cmb_Plantas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.labelText013);
            this.Controls.Add(this.btn_Fehca);
            this.Controls.Add(this.labelText012);
            this.Controls.Add(this.btn_BuscarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TipoDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IdFactura);
            this.Controls.Add(this.cmb_TipoFactura);
            this.Controls.Add(this.ltxt_DocCliente);
            this.Name = "Frm_GenerarFactura";
            this.Text = "Frm_GenerarFactura";
            this.Load += new System.EventHandler(this.Frm_GenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Generar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.LabelText01 ltxt_DocCliente;
        private Clases.ComboBox01 cmb_TipoFactura;
        private Clases.TextBox01 txt_IdFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_TipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private Clases.LabelText01 labelText012;
        private System.Windows.Forms.Button btn_Fehca;
        private Clases.LabelText01 labelText013;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_Monto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_Plantas;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_CantidadPlant;
        private System.Windows.Forms.Button btn_AgregarPlanta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 cmb_Productos;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox01 txt_CantidadProd;
        private System.Windows.Forms.Button btn_AgregarProd;
        private System.Windows.Forms.PictureBox btn_Generar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_Cancelar;
    }
}