namespace PAV1_TP.Formularios.Catalogos
{
    partial class ABM_Catalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Catalogos));
            this.btn_AgregarCatalogo = new System.Windows.Forms.PictureBox();
            this.btn_EditarCatalogo = new System.Windows.Forms.PictureBox();
            this.btn_SalirCatalogo = new System.Windows.Forms.PictureBox();
            this.btn_EliminarCatalogo = new System.Windows.Forms.PictureBox();
            this.Grid_Catalogos = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_TodosCatalogos = new System.Windows.Forms.CheckBox();
            this.txt_IdCatalogoPlanta = new System.Windows.Forms.TextBox();
            this.txt_IdCatalogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Catalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarCatalogo
            // 
            this.btn_AgregarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCatalogo.BackgroundImage")));
            this.btn_AgregarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarCatalogo.Location = new System.Drawing.Point(8, 311);
            this.btn_AgregarCatalogo.Name = "btn_AgregarCatalogo";
            this.btn_AgregarCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_AgregarCatalogo.TabIndex = 23;
            this.btn_AgregarCatalogo.TabStop = false;
            this.btn_AgregarCatalogo.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_EditarCatalogo
            // 
            this.btn_EditarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarCatalogo.BackgroundImage")));
            this.btn_EditarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarCatalogo.Location = new System.Drawing.Point(75, 311);
            this.btn_EditarCatalogo.Name = "btn_EditarCatalogo";
            this.btn_EditarCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_EditarCatalogo.TabIndex = 22;
            this.btn_EditarCatalogo.TabStop = false;
            this.btn_EditarCatalogo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_SalirCatalogo
            // 
            this.btn_SalirCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalirCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirCatalogo.BackgroundImage")));
            this.btn_SalirCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SalirCatalogo.Location = new System.Drawing.Point(303, 311);
            this.btn_SalirCatalogo.Name = "btn_SalirCatalogo";
            this.btn_SalirCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_SalirCatalogo.TabIndex = 21;
            this.btn_SalirCatalogo.TabStop = false;
            // 
            // btn_EliminarCatalogo
            // 
            this.btn_EliminarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCatalogo.BackgroundImage")));
            this.btn_EliminarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCatalogo.Location = new System.Drawing.Point(149, 311);
            this.btn_EliminarCatalogo.Name = "btn_EliminarCatalogo";
            this.btn_EliminarCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_EliminarCatalogo.TabIndex = 20;
            this.btn_EliminarCatalogo.TabStop = false;
            // 
            // Grid_Catalogos
            // 
            this.Grid_Catalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Catalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Nombre,
            this.Apellido});
            this.Grid_Catalogos.Location = new System.Drawing.Point(11, 88);
            this.Grid_Catalogos.Name = "Grid_Catalogos";
            this.Grid_Catalogos.Size = new System.Drawing.Size(340, 212);
            this.Grid_Catalogos.TabIndex = 4;
            // 
            // Doc
            // 
            this.Doc.HeaderText = "ID Catalogo";
            this.Doc.Name = "Doc";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "ID Planta";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Puntos necesarios";
            this.Apellido.Name = "Apellido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chk_TodosCatalogos
            // 
            this.chk_TodosCatalogos.AutoSize = true;
            this.chk_TodosCatalogos.BackColor = System.Drawing.Color.Transparent;
            this.chk_TodosCatalogos.Location = new System.Drawing.Point(93, 65);
            this.chk_TodosCatalogos.Name = "chk_TodosCatalogos";
            this.chk_TodosCatalogos.Size = new System.Drawing.Size(56, 17);
            this.chk_TodosCatalogos.TabIndex = 3;
            this.chk_TodosCatalogos.Text = "Todos";
            this.chk_TodosCatalogos.UseVisualStyleBackColor = false;
            // 
            // txt_IdCatalogoPlanta
            // 
            this.txt_IdCatalogoPlanta.Location = new System.Drawing.Point(93, 39);
            this.txt_IdCatalogoPlanta.Name = "txt_IdCatalogoPlanta";
            this.txt_IdCatalogoPlanta.Size = new System.Drawing.Size(71, 20);
            this.txt_IdCatalogoPlanta.TabIndex = 2;
            // 
            // txt_IdCatalogo
            // 
            this.txt_IdCatalogo.Location = new System.Drawing.Point(93, 9);
            this.txt_IdCatalogo.Name = "txt_IdCatalogo";
            this.txt_IdCatalogo.Size = new System.Drawing.Size(71, 20);
            this.txt_IdCatalogo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Planta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Catalogo";
            // 
            // ABM_Catalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 359);
            this.Controls.Add(this.btn_AgregarCatalogo);
            this.Controls.Add(this.btn_EditarCatalogo);
            this.Controls.Add(this.btn_SalirCatalogo);
            this.Controls.Add(this.btn_EliminarCatalogo);
            this.Controls.Add(this.Grid_Catalogos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_TodosCatalogos);
            this.Controls.Add(this.txt_IdCatalogoPlanta);
            this.Controls.Add(this.txt_IdCatalogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABM_Catalogos";
            this.Text = "ABM_Catalogos";
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Catalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarCatalogo;
        private System.Windows.Forms.PictureBox btn_EditarCatalogo;
        private System.Windows.Forms.PictureBox btn_SalirCatalogo;
        private System.Windows.Forms.PictureBox btn_EliminarCatalogo;
        private System.Windows.Forms.DataGridView Grid_Catalogos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_TodosCatalogos;
        private System.Windows.Forms.TextBox txt_IdCatalogoPlanta;
        private System.Windows.Forms.TextBox txt_IdCatalogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}