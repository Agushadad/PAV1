namespace PAV1_TP.Formularios.Empleados
{
    partial class ABM_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Empleados));
            this.btn_AgregarEmp = new System.Windows.Forms.PictureBox();
            this.btn_EditarEmp = new System.Windows.Forms.PictureBox();
            this.btn_SalirEmp = new System.Windows.Forms.PictureBox();
            this.btn_EliminarEmp = new System.Windows.Forms.PictureBox();
            this.Grid_Emp = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ConsultarEmp = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_ApeEmp = new System.Windows.Forms.TextBox();
            this.txt_NombreEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarEmp
            // 
            this.btn_AgregarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarEmp.BackgroundImage")));
            this.btn_AgregarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarEmp.Location = new System.Drawing.Point(12, 359);
            this.btn_AgregarEmp.Name = "btn_AgregarEmp";
            this.btn_AgregarEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarEmp.TabIndex = 23;
            this.btn_AgregarEmp.TabStop = false;
            // 
            // btn_EditarEmp
            // 
            this.btn_EditarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarEmp.BackgroundImage")));
            this.btn_EditarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarEmp.Location = new System.Drawing.Point(79, 359);
            this.btn_EditarEmp.Name = "btn_EditarEmp";
            this.btn_EditarEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_EditarEmp.TabIndex = 22;
            this.btn_EditarEmp.TabStop = false;
            // 
            // btn_SalirEmp
            // 
            this.btn_SalirEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalirEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirEmp.BackgroundImage")));
            this.btn_SalirEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SalirEmp.Location = new System.Drawing.Point(654, 359);
            this.btn_SalirEmp.Name = "btn_SalirEmp";
            this.btn_SalirEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_SalirEmp.TabIndex = 21;
            this.btn_SalirEmp.TabStop = false;
            // 
            // btn_EliminarEmp
            // 
            this.btn_EliminarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarEmp.BackgroundImage")));
            this.btn_EliminarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarEmp.Location = new System.Drawing.Point(153, 359);
            this.btn_EliminarEmp.Name = "btn_EliminarEmp";
            this.btn_EliminarEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarEmp.TabIndex = 20;
            this.btn_EliminarEmp.TabStop = false;
            // 
            // Grid_Emp
            // 
            this.Grid_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Puesto,
            this.Domicilio,
            this.Tipo});
            this.Grid_Emp.Location = new System.Drawing.Point(12, 116);
            this.Grid_Emp.Name = "Grid_Emp";
            this.Grid_Emp.Size = new System.Drawing.Size(701, 237);
            this.Grid_Emp.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
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
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 170;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Telefono";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 130;
            // 
            // btn_ConsultarEmp
            // 
            this.btn_ConsultarEmp.Location = new System.Drawing.Point(250, 63);
            this.btn_ConsultarEmp.Name = "btn_ConsultarEmp";
            this.btn_ConsultarEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarEmp.TabIndex = 4;
            this.btn_ConsultarEmp.Text = "Consultar";
            this.btn_ConsultarEmp.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(82, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // txt_ApeEmp
            // 
            this.txt_ApeEmp.Location = new System.Drawing.Point(82, 63);
            this.txt_ApeEmp.Name = "txt_ApeEmp";
            this.txt_ApeEmp.Size = new System.Drawing.Size(162, 20);
            this.txt_ApeEmp.TabIndex = 3;
            // 
            // txt_NombreEmp
            // 
            this.txt_NombreEmp.Location = new System.Drawing.Point(82, 33);
            this.txt_NombreEmp.Name = "txt_NombreEmp";
            this.txt_NombreEmp.Size = new System.Drawing.Size(162, 20);
            this.txt_NombreEmp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_IdEmp
            // 
            this.txt_IdEmp.Location = new System.Drawing.Point(79, 7);
            this.txt_IdEmp.Name = "txt_IdEmp";
            this.txt_IdEmp.Size = new System.Drawing.Size(59, 20);
            this.txt_IdEmp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // ABM_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 416);
            this.Controls.Add(this.txt_IdEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AgregarEmp);
            this.Controls.Add(this.btn_EditarEmp);
            this.Controls.Add(this.btn_SalirEmp);
            this.Controls.Add(this.btn_EliminarEmp);
            this.Controls.Add(this.Grid_Emp);
            this.Controls.Add(this.btn_ConsultarEmp);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_ApeEmp);
            this.Controls.Add(this.txt_NombreEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABM_Empleados";
            this.Text = "ABM_Empleados";
            this.Load += new System.EventHandler(this.ABM_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarEmp;
        private System.Windows.Forms.PictureBox btn_EditarEmp;
        private System.Windows.Forms.PictureBox btn_SalirEmp;
        private System.Windows.Forms.PictureBox btn_EliminarEmp;
        private System.Windows.Forms.DataGridView Grid_Emp;
        private System.Windows.Forms.Button btn_ConsultarEmp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_ApeEmp;
        private System.Windows.Forms.TextBox txt_NombreEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.TextBox txt_IdEmp;
        private System.Windows.Forms.Label label3;
    }
}