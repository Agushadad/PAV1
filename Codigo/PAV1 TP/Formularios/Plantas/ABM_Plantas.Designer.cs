namespace WindowsFormsApp2
{
    partial class ABM_Plantas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Plantas));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AgregarPlanta = new System.Windows.Forms.PictureBox();
            this.Grid_Planta = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_TodosPlanta = new System.Windows.Forms.CheckBox();
            this.btn_ConsultarPlanta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarStockPlanta = new System.Windows.Forms.Button();
            this.btn_ModificarPlanta = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_EliminarPlanta = new System.Windows.Forms.PictureBox();
            this.txt_CodPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_NComun = new PAV1_TP.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Planta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarPlanta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre común";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_AgregarPlanta
            // 
            this.btn_AgregarPlanta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarPlanta.Image")));
            this.btn_AgregarPlanta.Location = new System.Drawing.Point(0, 323);
            this.btn_AgregarPlanta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarPlanta.Name = "btn_AgregarPlanta";
            this.btn_AgregarPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarPlanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AgregarPlanta.TabIndex = 4;
            this.btn_AgregarPlanta.TabStop = false;
            this.btn_AgregarPlanta.Click += new System.EventHandler(this.btn_AgregarPlanta_Click);
            // 
            // Grid_Planta
            // 
            this.Grid_Planta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Planta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Columna2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Grid_Planta.Location = new System.Drawing.Point(4, 109);
            this.Grid_Planta.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_Planta.Name = "Grid_Planta";
            this.Grid_Planta.RowHeadersWidth = 51;
            this.Grid_Planta.RowTemplate.Height = 24;
            this.Grid_Planta.Size = new System.Drawing.Size(593, 174);
            this.Grid_Planta.TabIndex = 6;
            this.Grid_Planta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 125;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Nombre Científico";
            this.Columna2.MinimumWidth = 6;
            this.Columna2.Name = "Columna2";
            this.Columna2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Común";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // chk_TodosPlanta
            // 
            this.chk_TodosPlanta.AutoSize = true;
            this.chk_TodosPlanta.BackColor = System.Drawing.Color.Transparent;
            this.chk_TodosPlanta.Location = new System.Drawing.Point(120, 66);
            this.chk_TodosPlanta.Name = "chk_TodosPlanta";
            this.chk_TodosPlanta.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosPlanta.TabIndex = 4;
            this.chk_TodosPlanta.Text = "Todos";
            this.chk_TodosPlanta.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarPlanta
            // 
            this.btn_ConsultarPlanta.Location = new System.Drawing.Point(226, 44);
            this.btn_ConsultarPlanta.Name = "btn_ConsultarPlanta";
            this.btn_ConsultarPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarPlanta.TabIndex = 3;
            this.btn_ConsultarPlanta.Text = "Consultar";
            this.btn_ConsultarPlanta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txt_NComun);
            this.groupBox1.Controls.Add(this.txt_CodPlanta);
            this.groupBox1.Controls.Add(this.btn_ActualizarStockPlanta);
            this.groupBox1.Controls.Add(this.btn_ModificarPlanta);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_EliminarPlanta);
            this.groupBox1.Controls.Add(this.btn_ConsultarPlanta);
            this.groupBox1.Controls.Add(this.chk_TodosPlanta);
            this.groupBox1.Controls.Add(this.Grid_Planta);
            this.groupBox1.Controls.Add(this.btn_AgregarPlanta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(615, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_ActualizarStockPlanta
            // 
            this.btn_ActualizarStockPlanta.Location = new System.Drawing.Point(503, 81);
            this.btn_ActualizarStockPlanta.Name = "btn_ActualizarStockPlanta";
            this.btn_ActualizarStockPlanta.Size = new System.Drawing.Size(94, 23);
            this.btn_ActualizarStockPlanta.TabIndex = 5;
            this.btn_ActualizarStockPlanta.Text = "Actualizar stock";
            this.btn_ActualizarStockPlanta.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarPlanta
            // 
            this.btn_ModificarPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarPlanta.BackgroundImage")));
            this.btn_ModificarPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarPlanta.Location = new System.Drawing.Point(64, 323);
            this.btn_ModificarPlanta.Name = "btn_ModificarPlanta";
            this.btn_ModificarPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_ModificarPlanta.TabIndex = 12;
            this.btn_ModificarPlanta.TabStop = false;
            this.btn_ModificarPlanta.Click += new System.EventHandler(this.btn_ModificarPlanta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(538, 323);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(59, 50);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // btn_EliminarPlanta
            // 
            this.btn_EliminarPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarPlanta.BackgroundImage")));
            this.btn_EliminarPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarPlanta.Location = new System.Drawing.Point(129, 323);
            this.btn_EliminarPlanta.Name = "btn_EliminarPlanta";
            this.btn_EliminarPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarPlanta.TabIndex = 10;
            this.btn_EliminarPlanta.TabStop = false;
            // 
            // txt_CodPlanta
            // 
            this.txt_CodPlanta.Location = new System.Drawing.Point(120, 18);
            this.txt_CodPlanta.Name = "txt_CodPlanta";
            this.txt_CodPlanta.Pp_mensajeError = null;
            this.txt_CodPlanta.Pp_nombre_campo = null;
            this.txt_CodPlanta.Pp_nombre_tabla = null;
            this.txt_CodPlanta.Pp_validable = false;
            this.txt_CodPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_CodPlanta.TabIndex = 13;
            // 
            // txt_NComun
            // 
            this.txt_NComun.Location = new System.Drawing.Point(120, 44);
            this.txt_NComun.Name = "txt_NComun";
            this.txt_NComun.Pp_mensajeError = null;
            this.txt_NComun.Pp_nombre_campo = null;
            this.txt_NComun.Pp_nombre_tabla = null;
            this.txt_NComun.Pp_validable = false;
            this.txt_NComun.Size = new System.Drawing.Size(100, 20);
            this.txt_NComun.TabIndex = 14;
            // 
            // ABM_Plantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(601, 378);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ABM_Plantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plantas";
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Planta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarPlanta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_AgregarPlanta;
        private System.Windows.Forms.DataGridView Grid_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox chk_TodosPlanta;
        private System.Windows.Forms.Button btn_ConsultarPlanta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btn_ModificarPlanta;
        private System.Windows.Forms.PictureBox btn_Cancelar;
        private System.Windows.Forms.PictureBox btn_EliminarPlanta;
        private System.Windows.Forms.Button btn_ActualizarStockPlanta;
        private PAV1_TP.Clases.TextBox01 txt_NComun;
        private PAV1_TP.Clases.TextBox01 txt_CodPlanta;
    }
}

