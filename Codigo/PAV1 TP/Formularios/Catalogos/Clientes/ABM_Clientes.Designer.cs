namespace WindowsFormsApp2
{
    partial class ABM_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Clientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.chk_TodosClientes = new System.Windows.Forms.CheckBox();
            this.btn_ConsultarCliente = new System.Windows.Forms.Button();
            this.Grid_Clientes = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ApellidoCliente = new System.Windows.Forms.TextBox();
            this.txt_DocCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EliminarCliente = new System.Windows.Forms.PictureBox();
            this.btn_SalirClientes = new System.Windows.Forms.PictureBox();
            this.btn_EditarCliente = new System.Windows.Forms.PictureBox();
            this.btn_AgregarClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(141, 26);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(162, 20);
            this.txt_NombreCliente.TabIndex = 1;
            // 
            // chk_TodosClientes
            // 
            this.chk_TodosClientes.AutoSize = true;
            this.chk_TodosClientes.BackColor = System.Drawing.Color.Transparent;
            this.chk_TodosClientes.Location = new System.Drawing.Point(141, 108);
            this.chk_TodosClientes.Name = "chk_TodosClientes";
            this.chk_TodosClientes.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosClientes.TabIndex = 5;
            this.chk_TodosClientes.Text = "Todos";
            this.chk_TodosClientes.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarCliente
            // 
            this.btn_ConsultarCliente.Location = new System.Drawing.Point(309, 82);
            this.btn_ConsultarCliente.Name = "btn_ConsultarCliente";
            this.btn_ConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarCliente.TabIndex = 4;
            this.btn_ConsultarCliente.Text = "Consultar";
            this.btn_ConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // Grid_Clientes
            // 
            this.Grid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.Tipo});
            this.Grid_Clientes.Location = new System.Drawing.Point(12, 131);
            this.Grid_Clientes.Name = "Grid_Clientes";
            this.Grid_Clientes.Size = new System.Drawing.Size(664, 212);
            this.Grid_Clientes.TabIndex = 6;
            this.Grid_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Doc
            // 
            this.Doc.HeaderText = "Documento";
            this.Doc.Name = "Doc";
            this.Doc.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 120;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 120;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Teléfono";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 130;
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(141, 56);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(162, 20);
            this.txt_ApellidoCliente.TabIndex = 2;
            // 
            // txt_DocCliente
            // 
            this.txt_DocCliente.Location = new System.Drawing.Point(141, 82);
            this.txt_DocCliente.Name = "txt_DocCliente";
            this.txt_DocCliente.Size = new System.Drawing.Size(162, 20);
            this.txt_DocCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(60, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Documento";
            // 
            // btn_EliminarCliente
            // 
            this.btn_EliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCliente.BackgroundImage")));
            this.btn_EliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCliente.Location = new System.Drawing.Point(153, 374);
            this.btn_EliminarCliente.Name = "btn_EliminarCliente";
            this.btn_EliminarCliente.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarCliente.TabIndex = 7;
            this.btn_EliminarCliente.TabStop = false;
            // 
            // btn_SalirClientes
            // 
            this.btn_SalirClientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalirClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirClientes.BackgroundImage")));
            this.btn_SalirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SalirClientes.Location = new System.Drawing.Point(625, 374);
            this.btn_SalirClientes.Name = "btn_SalirClientes";
            this.btn_SalirClientes.Size = new System.Drawing.Size(59, 50);
            this.btn_SalirClientes.TabIndex = 8;
            this.btn_SalirClientes.TabStop = false;
            this.btn_SalirClientes.Click += new System.EventHandler(this.btn_SalirClientes_Click);
            // 
            // btn_EditarCliente
            // 
            this.btn_EditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarCliente.BackgroundImage")));
            this.btn_EditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarCliente.Location = new System.Drawing.Point(79, 374);
            this.btn_EditarCliente.Name = "btn_EditarCliente";
            this.btn_EditarCliente.Size = new System.Drawing.Size(59, 50);
            this.btn_EditarCliente.TabIndex = 9;
            this.btn_EditarCliente.TabStop = false;
            // 
            // btn_AgregarClientes
            // 
            this.btn_AgregarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarClientes.BackgroundImage")));
            this.btn_AgregarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarClientes.Location = new System.Drawing.Point(12, 374);
            this.btn_AgregarClientes.Name = "btn_AgregarClientes";
            this.btn_AgregarClientes.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarClientes.TabIndex = 10;
            this.btn_AgregarClientes.TabStop = false;
            // 
            // ABM_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 426);
            this.Controls.Add(this.btn_AgregarClientes);
            this.Controls.Add(this.btn_EditarCliente);
            this.Controls.Add(this.btn_SalirClientes);
            this.Controls.Add(this.btn_EliminarCliente);
            this.Controls.Add(this.Grid_Clientes);
            this.Controls.Add(this.btn_ConsultarCliente);
            this.Controls.Add(this.chk_TodosClientes);
            this.Controls.Add(this.txt_DocCliente);
            this.Controls.Add(this.txt_ApellidoCliente);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ABM_Clientes";
            this.Text = "ABM_Clientes";
            this.Load += new System.EventHandler(this.ABM_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.CheckBox chk_TodosClientes;
        private System.Windows.Forms.Button btn_ConsultarCliente;
        private System.Windows.Forms.DataGridView Grid_Clientes;
        private System.Windows.Forms.TextBox txt_ApellidoCliente;
        private System.Windows.Forms.TextBox txt_DocCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_EliminarCliente;
        private System.Windows.Forms.PictureBox btn_SalirClientes;
        private System.Windows.Forms.PictureBox btn_EditarCliente;
        private System.Windows.Forms.PictureBox btn_AgregarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}