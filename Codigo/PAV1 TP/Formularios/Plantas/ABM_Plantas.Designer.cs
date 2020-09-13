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
            this.txt_NComun = new PAV1_TP.Clases.TextBox01();
            this.txt_CodPlanta = new PAV1_TP.Clases.TextBox01();
            this.btn_ModificarPlanta = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_EliminarPlanta = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre común";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_AgregarPlanta
            // 
            this.btn_AgregarPlanta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarPlanta.Image")));
            this.btn_AgregarPlanta.Location = new System.Drawing.Point(0, 398);
            this.btn_AgregarPlanta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AgregarPlanta.Name = "btn_AgregarPlanta";
            this.btn_AgregarPlanta.Size = new System.Drawing.Size(79, 62);
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
            this.Grid_Planta.Location = new System.Drawing.Point(5, 134);
            this.Grid_Planta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid_Planta.Name = "Grid_Planta";
            this.Grid_Planta.RowHeadersWidth = 51;
            this.Grid_Planta.RowTemplate.Height = 24;
            this.Grid_Planta.Size = new System.Drawing.Size(791, 214);
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
            this.chk_TodosPlanta.Location = new System.Drawing.Point(160, 96);
            this.chk_TodosPlanta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_TodosPlanta.Name = "chk_TodosPlanta";
            this.chk_TodosPlanta.Size = new System.Drawing.Size(70, 21);
            this.chk_TodosPlanta.TabIndex = 4;
            this.chk_TodosPlanta.Text = "Todos";
            this.chk_TodosPlanta.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarPlanta
            // 
            this.btn_ConsultarPlanta.Location = new System.Drawing.Point(301, 54);
            this.btn_ConsultarPlanta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ConsultarPlanta.Name = "btn_ConsultarPlanta";
            this.btn_ConsultarPlanta.Size = new System.Drawing.Size(100, 28);
            this.btn_ConsultarPlanta.TabIndex = 3;
            this.btn_ConsultarPlanta.Text = "Consultar";
            this.btn_ConsultarPlanta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txt_NComun);
            this.groupBox1.Controls.Add(this.txt_CodPlanta);
            this.groupBox1.Controls.Add(this.btn_ModificarPlanta);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_EliminarPlanta);
            this.groupBox1.Controls.Add(this.btn_ConsultarPlanta);
            this.groupBox1.Controls.Add(this.chk_TodosPlanta);
            this.groupBox1.Controls.Add(this.Grid_Planta);
            this.groupBox1.Controls.Add(this.btn_AgregarPlanta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(820, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_NComun
            // 
            this.txt_NComun.Location = new System.Drawing.Point(160, 54);
            this.txt_NComun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NComun.Name = "txt_NComun";
            this.txt_NComun.Pp_mensajeError = null;
            this.txt_NComun.Pp_nombre_campo = null;
            this.txt_NComun.Pp_nombre_tabla = null;
            this.txt_NComun.Pp_validable = false;
            this.txt_NComun.Size = new System.Drawing.Size(132, 22);
            this.txt_NComun.TabIndex = 14;
            // 
            // txt_CodPlanta
            // 
            this.txt_CodPlanta.Location = new System.Drawing.Point(160, 22);
            this.txt_CodPlanta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodPlanta.Name = "txt_CodPlanta";
            this.txt_CodPlanta.Pp_mensajeError = null;
            this.txt_CodPlanta.Pp_nombre_campo = null;
            this.txt_CodPlanta.Pp_nombre_tabla = null;
            this.txt_CodPlanta.Pp_validable = false;
            this.txt_CodPlanta.Size = new System.Drawing.Size(132, 22);
            this.txt_CodPlanta.TabIndex = 13;
            // 
            // btn_ModificarPlanta
            // 
            this.btn_ModificarPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarPlanta.BackgroundImage")));
            this.btn_ModificarPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarPlanta.Location = new System.Drawing.Point(85, 398);
            this.btn_ModificarPlanta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ModificarPlanta.Name = "btn_ModificarPlanta";
            this.btn_ModificarPlanta.Size = new System.Drawing.Size(79, 62);
            this.btn_ModificarPlanta.TabIndex = 12;
            this.btn_ModificarPlanta.TabStop = false;
            this.btn_ModificarPlanta.Click += new System.EventHandler(this.btn_ModificarPlanta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(717, 398);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(79, 62);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // btn_EliminarPlanta
            // 
            this.btn_EliminarPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarPlanta.BackgroundImage")));
            this.btn_EliminarPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarPlanta.Location = new System.Drawing.Point(172, 398);
            this.btn_EliminarPlanta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EliminarPlanta.Name = "btn_EliminarPlanta";
            this.btn_EliminarPlanta.Size = new System.Drawing.Size(79, 62);
            this.btn_EliminarPlanta.TabIndex = 10;
            this.btn_EliminarPlanta.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(243, 96);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Activas";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(319, 96);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 21);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Inactivas";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // ABM_Plantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 465);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private PAV1_TP.Clases.TextBox01 txt_NComun;
        private PAV1_TP.Clases.TextBox01 txt_CodPlanta;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

