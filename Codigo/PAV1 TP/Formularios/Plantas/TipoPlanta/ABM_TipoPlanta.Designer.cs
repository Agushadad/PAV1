namespace PAV1_TP.Formularios.Plantas.TipoPlanta
{
    partial class ABM_TipoPlanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_TipoPlanta));
            this.txt_NombreTipoPlanta = new System.Windows.Forms.TextBox();
            this.chk_TipoPlantasInactivas = new System.Windows.Forms.CheckBox();
            this.chk_TipoPlantasActivas = new System.Windows.Forms.CheckBox();
            this.btn_ConsultarTipoPlanta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_TipoPlanta = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ModificarTipoPlanta = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_EliminarTipoPlanta = new System.Windows.Forms.PictureBox();
            this.btn_AgregarTipoPlanta = new System.Windows.Forms.PictureBox();
            this.txt_IdTipoPlanta = new PAV1_TP.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TipoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarTipoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarTipoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarTipoPlanta)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NombreTipoPlanta
            // 
            this.txt_NombreTipoPlanta.Location = new System.Drawing.Point(93, 39);
            this.txt_NombreTipoPlanta.Name = "txt_NombreTipoPlanta";
            this.txt_NombreTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreTipoPlanta.TabIndex = 2;
            // 
            // chk_TipoPlantasInactivas
            // 
            this.chk_TipoPlantasInactivas.AutoSize = true;
            this.chk_TipoPlantasInactivas.BackColor = System.Drawing.Color.Transparent;
            this.chk_TipoPlantasInactivas.Location = new System.Drawing.Point(150, 65);
            this.chk_TipoPlantasInactivas.Name = "chk_TipoPlantasInactivas";
            this.chk_TipoPlantasInactivas.Size = new System.Drawing.Size(69, 17);
            this.chk_TipoPlantasInactivas.TabIndex = 4;
            this.chk_TipoPlantasInactivas.Text = "Inactivas";
            this.chk_TipoPlantasInactivas.UseVisualStyleBackColor = false;
            // 
            // chk_TipoPlantasActivas
            // 
            this.chk_TipoPlantasActivas.AutoSize = true;
            this.chk_TipoPlantasActivas.BackColor = System.Drawing.Color.Transparent;
            this.chk_TipoPlantasActivas.Location = new System.Drawing.Point(93, 65);
            this.chk_TipoPlantasActivas.Name = "chk_TipoPlantasActivas";
            this.chk_TipoPlantasActivas.Size = new System.Drawing.Size(61, 17);
            this.chk_TipoPlantasActivas.TabIndex = 3;
            this.chk_TipoPlantasActivas.Text = "Activas";
            this.chk_TipoPlantasActivas.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarTipoPlanta
            // 
            this.btn_ConsultarTipoPlanta.Location = new System.Drawing.Point(199, 39);
            this.btn_ConsultarTipoPlanta.Name = "btn_ConsultarTipoPlanta";
            this.btn_ConsultarTipoPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarTipoPlanta.TabIndex = 5;
            this.btn_ConsultarTipoPlanta.Text = "Consultar";
            this.btn_ConsultarTipoPlanta.UseVisualStyleBackColor = true;
            this.btn_ConsultarTipoPlanta.Click += new System.EventHandler(this.btn_ConsultarTipoPlanta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // Grid_TipoPlanta
            // 
            this.Grid_TipoPlanta.AllowUserToDeleteRows = false;
            this.Grid_TipoPlanta.AllowUserToResizeColumns = false;
            this.Grid_TipoPlanta.AllowUserToResizeRows = false;
            this.Grid_TipoPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TipoPlanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido});
            this.Grid_TipoPlanta.Location = new System.Drawing.Point(12, 88);
            this.Grid_TipoPlanta.Name = "Grid_TipoPlanta";
            this.Grid_TipoPlanta.Size = new System.Drawing.Size(533, 237);
            this.Grid_TipoPlanta.StandardTab = true;
            this.Grid_TipoPlanta.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Descripcion";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.Width = 300;
            // 
            // btn_ModificarTipoPlanta
            // 
            this.btn_ModificarTipoPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarTipoPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarTipoPlanta.BackgroundImage")));
            this.btn_ModificarTipoPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarTipoPlanta.Location = new System.Drawing.Point(75, 348);
            this.btn_ModificarTipoPlanta.Name = "btn_ModificarTipoPlanta";
            this.btn_ModificarTipoPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_ModificarTipoPlanta.TabIndex = 30;
            this.btn_ModificarTipoPlanta.TabStop = false;
            this.btn_ModificarTipoPlanta.Click += new System.EventHandler(this.btn_ModificarTipoPlanta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(486, 348);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(59, 50);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_EliminarTipoPlanta
            // 
            this.btn_EliminarTipoPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarTipoPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarTipoPlanta.BackgroundImage")));
            this.btn_EliminarTipoPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarTipoPlanta.Location = new System.Drawing.Point(140, 348);
            this.btn_EliminarTipoPlanta.Name = "btn_EliminarTipoPlanta";
            this.btn_EliminarTipoPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarTipoPlanta.TabIndex = 28;
            this.btn_EliminarTipoPlanta.TabStop = false;
            this.btn_EliminarTipoPlanta.Click += new System.EventHandler(this.btn_EliminarTipoPlanta_Click);
            // 
            // btn_AgregarTipoPlanta
            // 
            this.btn_AgregarTipoPlanta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarTipoPlanta.Image")));
            this.btn_AgregarTipoPlanta.Location = new System.Drawing.Point(11, 348);
            this.btn_AgregarTipoPlanta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarTipoPlanta.Name = "btn_AgregarTipoPlanta";
            this.btn_AgregarTipoPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarTipoPlanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AgregarTipoPlanta.TabIndex = 27;
            this.btn_AgregarTipoPlanta.TabStop = false;
            this.btn_AgregarTipoPlanta.Click += new System.EventHandler(this.btn_AgregarTipoPlanta_Click);
            // 
            // txt_IdTipoPlanta
            // 
            this.txt_IdTipoPlanta.Location = new System.Drawing.Point(93, 12);
            this.txt_IdTipoPlanta.Name = "txt_IdTipoPlanta";
            this.txt_IdTipoPlanta.Pp_mensajeError = null;
            this.txt_IdTipoPlanta.Pp_nombre_campo = null;
            this.txt_IdTipoPlanta.Pp_nombre_tabla = null;
            this.txt_IdTipoPlanta.Pp_validable = false;
            this.txt_IdTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_IdTipoPlanta.TabIndex = 1;
            // 
            // ABM_TipoPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 408);
            this.Controls.Add(this.btn_ModificarTipoPlanta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_EliminarTipoPlanta);
            this.Controls.Add(this.btn_AgregarTipoPlanta);
            this.Controls.Add(this.Grid_TipoPlanta);
            this.Controls.Add(this.txt_NombreTipoPlanta);
            this.Controls.Add(this.chk_TipoPlantasInactivas);
            this.Controls.Add(this.chk_TipoPlantasActivas);
            this.Controls.Add(this.txt_IdTipoPlanta);
            this.Controls.Add(this.btn_ConsultarTipoPlanta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ABM_TipoPlanta";
            this.Text = "ABM_TipoPlanta";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TipoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarTipoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarTipoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarTipoPlanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NombreTipoPlanta;
        private System.Windows.Forms.CheckBox chk_TipoPlantasInactivas;
        private System.Windows.Forms.CheckBox chk_TipoPlantasActivas;
        private Clases.TextBox01 txt_IdTipoPlanta;
        private System.Windows.Forms.Button btn_ConsultarTipoPlanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid_TipoPlanta;
        private System.Windows.Forms.PictureBox btn_ModificarTipoPlanta;
        private System.Windows.Forms.PictureBox btn_Cancelar;
        private System.Windows.Forms.PictureBox btn_EliminarTipoPlanta;
        private System.Windows.Forms.PictureBox btn_AgregarTipoPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}