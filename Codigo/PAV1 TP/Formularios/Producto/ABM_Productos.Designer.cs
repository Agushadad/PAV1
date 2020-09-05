namespace PAV1_TP.Formularios.Producto
{
    partial class ABM_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Productos));
            this.btn_AgregarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_ModifProveedor = new System.Windows.Forms.PictureBox();
            this.btn_CancelarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_EliminarProveedor = new System.Windows.Forms.PictureBox();
            this.Grid_Producto = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ConsultarProducto = new System.Windows.Forms.Button();
            this.chk_TodosProducto = new System.Windows.Forms.CheckBox();
            this.txt_TipoProducto = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.BackgroundImage")));
            this.btn_AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(8, 342);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarProveedor.TabIndex = 36;
            this.btn_AgregarProveedor.TabStop = false;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // btn_ModifProveedor
            // 
            this.btn_ModifProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModifProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModifProveedor.BackgroundImage")));
            this.btn_ModifProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModifProveedor.Location = new System.Drawing.Point(75, 342);
            this.btn_ModifProveedor.Name = "btn_ModifProveedor";
            this.btn_ModifProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_ModifProveedor.TabIndex = 35;
            this.btn_ModifProveedor.TabStop = false;
            this.btn_ModifProveedor.Click += new System.EventHandler(this.btn_ModifProveedor_Click);
            // 
            // btn_CancelarProveedor
            // 
            this.btn_CancelarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelarProveedor.BackgroundImage")));
            this.btn_CancelarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CancelarProveedor.Location = new System.Drawing.Point(615, 343);
            this.btn_CancelarProveedor.Name = "btn_CancelarProveedor";
            this.btn_CancelarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_CancelarProveedor.TabIndex = 34;
            this.btn_CancelarProveedor.TabStop = false;
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.BackgroundImage")));
            this.btn_EliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(149, 342);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarProveedor.TabIndex = 33;
            this.btn_EliminarProveedor.TabStop = false;
            // 
            // Grid_Producto
            // 
            this.Grid_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Precio,
            this.Costo});
            this.Grid_Producto.Location = new System.Drawing.Point(8, 111);
            this.Grid_Producto.Name = "Grid_Producto";
            this.Grid_Producto.Size = new System.Drawing.Size(659, 212);
            this.Grid_Producto.TabIndex = 32;
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
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Tipo";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Stock";
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // btn_ConsultarProducto
            // 
            this.btn_ConsultarProducto.Location = new System.Drawing.Point(305, 62);
            this.btn_ConsultarProducto.Name = "btn_ConsultarProducto";
            this.btn_ConsultarProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarProducto.TabIndex = 31;
            this.btn_ConsultarProducto.Text = "Consultar";
            this.btn_ConsultarProducto.UseVisualStyleBackColor = true;
            // 
            // chk_TodosProducto
            // 
            this.chk_TodosProducto.AutoSize = true;
            this.chk_TodosProducto.BackColor = System.Drawing.Color.Transparent;
            this.chk_TodosProducto.Location = new System.Drawing.Point(137, 88);
            this.chk_TodosProducto.Name = "chk_TodosProducto";
            this.chk_TodosProducto.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosProducto.TabIndex = 30;
            this.chk_TodosProducto.Text = "Todos";
            this.chk_TodosProducto.UseVisualStyleBackColor = false;
            // 
            // txt_TipoProducto
            // 
            this.txt_TipoProducto.Location = new System.Drawing.Point(137, 62);
            this.txt_TipoProducto.Name = "txt_TipoProducto";
            this.txt_TipoProducto.Size = new System.Drawing.Size(162, 20);
            this.txt_TipoProducto.TabIndex = 29;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(137, 36);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(162, 20);
            this.txt_NombreProducto.TabIndex = 28;
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Location = new System.Drawing.Point(137, 6);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(56, 20);
            this.txt_IdProducto.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(56, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // ABM_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 404);
            this.Controls.Add(this.btn_AgregarProveedor);
            this.Controls.Add(this.btn_ModifProveedor);
            this.Controls.Add(this.btn_CancelarProveedor);
            this.Controls.Add(this.btn_EliminarProveedor);
            this.Controls.Add(this.Grid_Producto);
            this.Controls.Add(this.btn_ConsultarProducto);
            this.Controls.Add(this.chk_TodosProducto);
            this.Controls.Add(this.txt_TipoProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ABM_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Productos";
            this.Load += new System.EventHandler(this.ABM_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarProveedor;
        private System.Windows.Forms.PictureBox btn_ModifProveedor;
        private System.Windows.Forms.PictureBox btn_CancelarProveedor;
        private System.Windows.Forms.PictureBox btn_EliminarProveedor;
        private System.Windows.Forms.DataGridView Grid_Producto;
        private System.Windows.Forms.Button btn_ConsultarProducto;
        private System.Windows.Forms.CheckBox chk_TodosProducto;
        private System.Windows.Forms.TextBox txt_TipoProducto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}