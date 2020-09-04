namespace PAV1_TP.Formularios.Proveedor
{
    partial class ABM_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Proveedor));
            this.btn_AgregarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_ModifProveedor = new System.Windows.Forms.PictureBox();
            this.btn_CancelarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_EliminarProveedor = new System.Windows.Forms.PictureBox();
            this.Grid_Proveedor = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ConsultarProveedor = new System.Windows.Forms.Button();
            this.chk_TodosProveedor = new System.Windows.Forms.CheckBox();
            this.rxt_RSProveedor = new System.Windows.Forms.TextBox();
            this.txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.txt_IdProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.BackgroundImage")));
            this.btn_AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(3, 347);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarProveedor.TabIndex = 23;
            this.btn_AgregarProveedor.TabStop = false;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_ModifProveedor
            // 
            this.btn_ModifProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModifProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModifProveedor.BackgroundImage")));
            this.btn_ModifProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModifProveedor.Location = new System.Drawing.Point(70, 347);
            this.btn_ModifProveedor.Name = "btn_ModifProveedor";
            this.btn_ModifProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_ModifProveedor.TabIndex = 22;
            this.btn_ModifProveedor.TabStop = false;
            this.btn_ModifProveedor.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_CancelarProveedor
            // 
            this.btn_CancelarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelarProveedor.BackgroundImage")));
            this.btn_CancelarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CancelarProveedor.Location = new System.Drawing.Point(610, 348);
            this.btn_CancelarProveedor.Name = "btn_CancelarProveedor";
            this.btn_CancelarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_CancelarProveedor.TabIndex = 21;
            this.btn_CancelarProveedor.TabStop = false;
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.BackgroundImage")));
            this.btn_EliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(144, 347);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarProveedor.TabIndex = 20;
            this.btn_EliminarProveedor.TabStop = false;
            // 
            // Grid_Proveedor
            // 
            this.Grid_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Nombre,
            this.Tipo,
            this.Apellido});
            this.Grid_Proveedor.Location = new System.Drawing.Point(3, 116);
            this.Grid_Proveedor.Name = "Grid_Proveedor";
            this.Grid_Proveedor.Size = new System.Drawing.Size(659, 212);
            this.Grid_Proveedor.TabIndex = 6;
            // 
            // Doc
            // 
            this.Doc.HeaderText = "ID";
            this.Doc.Name = "Doc";
            this.Doc.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Telefono";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Razon social";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 300;
            // 
            // btn_ConsultarProveedor
            // 
            this.btn_ConsultarProveedor.Location = new System.Drawing.Point(300, 67);
            this.btn_ConsultarProveedor.Name = "btn_ConsultarProveedor";
            this.btn_ConsultarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarProveedor.TabIndex = 5;
            this.btn_ConsultarProveedor.Text = "Consultar";
            this.btn_ConsultarProveedor.UseVisualStyleBackColor = true;
            // 
            // chk_TodosProveedor
            // 
            this.chk_TodosProveedor.AutoSize = true;
            this.chk_TodosProveedor.BackColor = System.Drawing.Color.Transparent;
            this.chk_TodosProveedor.Location = new System.Drawing.Point(132, 93);
            this.chk_TodosProveedor.Name = "chk_TodosProveedor";
            this.chk_TodosProveedor.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosProveedor.TabIndex = 4;
            this.chk_TodosProveedor.Text = "Todos";
            this.chk_TodosProveedor.UseVisualStyleBackColor = false;
            // 
            // rxt_RSProveedor
            // 
            this.rxt_RSProveedor.Location = new System.Drawing.Point(132, 67);
            this.rxt_RSProveedor.Name = "rxt_RSProveedor";
            this.rxt_RSProveedor.Size = new System.Drawing.Size(162, 20);
            this.rxt_RSProveedor.TabIndex = 3;
            // 
            // txt_NombreProveedor
            // 
            this.txt_NombreProveedor.Location = new System.Drawing.Point(132, 41);
            this.txt_NombreProveedor.Name = "txt_NombreProveedor";
            this.txt_NombreProveedor.Size = new System.Drawing.Size(162, 20);
            this.txt_NombreProveedor.TabIndex = 2;
            // 
            // txt_IdProveedor
            // 
            this.txt_IdProveedor.Location = new System.Drawing.Point(132, 11);
            this.txt_IdProveedor.Name = "txt_IdProveedor";
            this.txt_IdProveedor.Size = new System.Drawing.Size(56, 20);
            this.txt_IdProveedor.TabIndex = 1;
            this.txt_IdProveedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razon social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ABM_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 404);
            this.Controls.Add(this.btn_AgregarProveedor);
            this.Controls.Add(this.btn_ModifProveedor);
            this.Controls.Add(this.btn_CancelarProveedor);
            this.Controls.Add(this.btn_EliminarProveedor);
            this.Controls.Add(this.Grid_Proveedor);
            this.Controls.Add(this.btn_ConsultarProveedor);
            this.Controls.Add(this.chk_TodosProveedor);
            this.Controls.Add(this.rxt_RSProveedor);
            this.Controls.Add(this.txt_NombreProveedor);
            this.Controls.Add(this.txt_IdProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarProveedor;
        private System.Windows.Forms.PictureBox btn_ModifProveedor;
        private System.Windows.Forms.PictureBox btn_CancelarProveedor;
        private System.Windows.Forms.PictureBox btn_EliminarProveedor;
        private System.Windows.Forms.DataGridView Grid_Proveedor;
        private System.Windows.Forms.Button btn_ConsultarProveedor;
        private System.Windows.Forms.CheckBox chk_TodosProveedor;
        private System.Windows.Forms.TextBox rxt_RSProveedor;
        private System.Windows.Forms.TextBox txt_NombreProveedor;
        private System.Windows.Forms.TextBox txt_IdProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}