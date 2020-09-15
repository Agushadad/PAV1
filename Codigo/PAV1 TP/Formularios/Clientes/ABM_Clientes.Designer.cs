namespace PAV1_TP.Formularios.Clientes
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
			this.chk_Inactivo = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_AgregarCli = new System.Windows.Forms.PictureBox();
			this.btn_EditarCli = new System.Windows.Forms.PictureBox();
			this.btn_SalirCli = new System.Windows.Forms.PictureBox();
			this.btn_EliminarCli = new System.Windows.Forms.PictureBox();
			this.Grid_Emp = new System.Windows.Forms.DataGridView();
			this.btn_ConsultarCli = new System.Windows.Forms.Button();
			this.chk_Todos = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_ApellidoCliente = new PAV1_TP.Clases.TextBox01();
			this.txt_NDocCliente = new PAV1_TP.Clases.TextBox01();
			this.txt_NombreCliente = new PAV1_TP.Clases.TextBox01();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCli)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_EditarCli)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_SalirCli)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCli)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Grid_Emp)).BeginInit();
			this.SuspendLayout();
			// 
			// chk_Inactivo
			// 
			this.chk_Inactivo.AutoSize = true;
			this.chk_Inactivo.BackColor = System.Drawing.Color.Transparent;
			this.chk_Inactivo.Location = new System.Drawing.Point(138, 93);
			this.chk_Inactivo.Name = "chk_Inactivo";
			this.chk_Inactivo.Size = new System.Drawing.Size(69, 17);
			this.chk_Inactivo.TabIndex = 39;
			this.chk_Inactivo.Text = "Inactivos";
			this.chk_Inactivo.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(18, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Nro Doc";
			// 
			// btn_AgregarCli
			// 
			this.btn_AgregarCli.BackColor = System.Drawing.Color.Transparent;
			this.btn_AgregarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCli.BackgroundImage")));
			this.btn_AgregarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_AgregarCli.Location = new System.Drawing.Point(6, 364);
			this.btn_AgregarCli.Name = "btn_AgregarCli";
			this.btn_AgregarCli.Size = new System.Drawing.Size(59, 50);
			this.btn_AgregarCli.TabIndex = 35;
			this.btn_AgregarCli.TabStop = false;
			this.btn_AgregarCli.Click += new System.EventHandler(this.btn_AgregarCli_Click);
			// 
			// btn_EditarCli
			// 
			this.btn_EditarCli.BackColor = System.Drawing.Color.Transparent;
			this.btn_EditarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarCli.BackgroundImage")));
			this.btn_EditarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_EditarCli.Location = new System.Drawing.Point(73, 364);
			this.btn_EditarCli.Name = "btn_EditarCli";
			this.btn_EditarCli.Size = new System.Drawing.Size(59, 50);
			this.btn_EditarCli.TabIndex = 34;
			this.btn_EditarCli.TabStop = false;
			this.btn_EditarCli.Click += new System.EventHandler(this.btn_EditarCli_Click);
			// 
			// btn_SalirCli
			// 
			this.btn_SalirCli.BackColor = System.Drawing.Color.Transparent;
			this.btn_SalirCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirCli.BackgroundImage")));
			this.btn_SalirCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_SalirCli.Location = new System.Drawing.Point(648, 364);
			this.btn_SalirCli.Name = "btn_SalirCli";
			this.btn_SalirCli.Size = new System.Drawing.Size(59, 50);
			this.btn_SalirCli.TabIndex = 33;
			this.btn_SalirCli.TabStop = false;
			this.btn_SalirCli.Click += new System.EventHandler(this.btn_SalirCli_Click);
			// 
			// btn_EliminarCli
			// 
			this.btn_EliminarCli.BackColor = System.Drawing.Color.Transparent;
			this.btn_EliminarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCli.BackgroundImage")));
			this.btn_EliminarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_EliminarCli.Location = new System.Drawing.Point(147, 364);
			this.btn_EliminarCli.Name = "btn_EliminarCli";
			this.btn_EliminarCli.Size = new System.Drawing.Size(59, 50);
			this.btn_EliminarCli.TabIndex = 32;
			this.btn_EliminarCli.TabStop = false;
			this.btn_EliminarCli.Click += new System.EventHandler(this.btn_EliminarCli_Click);
			// 
			// Grid_Emp
			// 
			this.Grid_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Domicilio,
            this.Altura,
            this.Email});
			this.Grid_Emp.Location = new System.Drawing.Point(6, 121);
			this.Grid_Emp.Name = "Grid_Emp";
			this.Grid_Emp.Size = new System.Drawing.Size(701, 237);
			this.Grid_Emp.TabIndex = 27;
			// 
			// btn_ConsultarCli
			// 
			this.btn_ConsultarCli.Location = new System.Drawing.Point(236, 65);
			this.btn_ConsultarCli.Name = "btn_ConsultarCli";
			this.btn_ConsultarCli.Size = new System.Drawing.Size(75, 23);
			this.btn_ConsultarCli.TabIndex = 30;
			this.btn_ConsultarCli.Text = "Consultar";
			this.btn_ConsultarCli.UseVisualStyleBackColor = true;
			this.btn_ConsultarCli.Click += new System.EventHandler(this.btn_ConsultarCli_Click);
			// 
			// chk_Todos
			// 
			this.chk_Todos.AutoSize = true;
			this.chk_Todos.BackColor = System.Drawing.Color.Transparent;
			this.chk_Todos.Location = new System.Drawing.Point(76, 94);
			this.chk_Todos.Name = "chk_Todos";
			this.chk_Todos.Size = new System.Drawing.Size(56, 17);
			this.chk_Todos.TabIndex = 31;
			this.chk_Todos.Text = "Todos";
			this.chk_Todos.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(26, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Apellido";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(26, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Nombre";
			// 
			// txt_ApellidoCliente
			// 
			this.txt_ApellidoCliente.Location = new System.Drawing.Point(73, 65);
			this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
			this.txt_ApellidoCliente.Pp_mensajeError = null;
			this.txt_ApellidoCliente.Pp_nombre_campo = null;
			this.txt_ApellidoCliente.Pp_nombre_tabla = null;
			this.txt_ApellidoCliente.Pp_validable = false;
			this.txt_ApellidoCliente.Size = new System.Drawing.Size(157, 20);
			this.txt_ApellidoCliente.TabIndex = 40;
			// 
			// txt_NDocCliente
			// 
			this.txt_NDocCliente.Location = new System.Drawing.Point(71, 12);
			this.txt_NDocCliente.Name = "txt_NDocCliente";
			this.txt_NDocCliente.Pp_mensajeError = null;
			this.txt_NDocCliente.Pp_nombre_campo = null;
			this.txt_NDocCliente.Pp_nombre_tabla = null;
			this.txt_NDocCliente.Pp_validable = false;
			this.txt_NDocCliente.Size = new System.Drawing.Size(157, 20);
			this.txt_NDocCliente.TabIndex = 41;
			// 
			// txt_NombreCliente
			// 
			this.txt_NombreCliente.Location = new System.Drawing.Point(73, 38);
			this.txt_NombreCliente.Name = "txt_NombreCliente";
			this.txt_NombreCliente.Pp_mensajeError = null;
			this.txt_NombreCliente.Pp_nombre_campo = null;
			this.txt_NombreCliente.Pp_nombre_tabla = null;
			this.txt_NombreCliente.Pp_validable = false;
			this.txt_NombreCliente.Size = new System.Drawing.Size(157, 20);
			this.txt_NombreCliente.TabIndex = 42;
			// 
			// Id
			// 
			this.Id.HeaderText = "Nro Doc";
			this.Id.Name = "Id";
			this.Id.Width = 150;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 150;
			// 
			// Apellido
			// 
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.Width = 150;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Telefono";
			this.Tipo.Name = "Tipo";
			this.Tipo.Width = 120;
			// 
			// Domicilio
			// 
			this.Domicilio.HeaderText = "Calle";
			this.Domicilio.Name = "Domicilio";
			this.Domicilio.Width = 130;
			// 
			// Altura
			// 
			this.Altura.HeaderText = "Altura";
			this.Altura.Name = "Altura";
			// 
			// Email
			// 
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.Width = 150;
			// 
			// ABM_Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(719, 423);
			this.Controls.Add(this.txt_NombreCliente);
			this.Controls.Add(this.txt_NDocCliente);
			this.Controls.Add(this.txt_ApellidoCliente);
			this.Controls.Add(this.chk_Inactivo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_AgregarCli);
			this.Controls.Add(this.btn_EditarCli);
			this.Controls.Add(this.btn_SalirCli);
			this.Controls.Add(this.btn_EliminarCli);
			this.Controls.Add(this.Grid_Emp);
			this.Controls.Add(this.btn_ConsultarCli);
			this.Controls.Add(this.chk_Todos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "ABM_Clientes";
			this.Text = "ABM_Clientes";
			((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCli)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_EditarCli)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_SalirCli)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCli)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Grid_Emp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Inactivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_AgregarCli;
        private System.Windows.Forms.PictureBox btn_EditarCli;
        private System.Windows.Forms.PictureBox btn_SalirCli;
        private System.Windows.Forms.PictureBox btn_EliminarCli;
        private System.Windows.Forms.DataGridView Grid_Emp;
        private System.Windows.Forms.Button btn_ConsultarCli;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_ApellidoCliente;
        private Clases.TextBox01 txt_NDocCliente;
        private Clases.TextBox01 txt_NombreCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
	}
}