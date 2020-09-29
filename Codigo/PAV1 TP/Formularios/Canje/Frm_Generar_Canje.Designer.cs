namespace PAV1_TP.Formularios.Canje
{
	partial class Frm_Generar_Canje
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Generar_Canje));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_nro_dni = new PAV1_TP.Clases.TextBox01();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_id_catalogo = new PAV1_TP.Clases.ComboBox01();
			this.label4 = new System.Windows.Forms.Label();
			this.cmb_cod_planta = new PAV1_TP.Clases.ComboBox01();
			this.canjear = new System.Windows.Forms.Button();
			this.cancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Canjear puntos";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(72, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "Nro Doc";
			// 
			// txt_nro_dni
			// 
			this.txt_nro_dni.Location = new System.Drawing.Point(126, 86);
			this.txt_nro_dni.Name = "txt_nro_dni";
			this.txt_nro_dni.Pp_mensajeError = null;
			this.txt_nro_dni.Pp_nombre_campo = null;
			this.txt_nro_dni.Pp_nombre_tabla = null;
			this.txt_nro_dni.Pp_validable = false;
			this.txt_nro_dni.Size = new System.Drawing.Size(121, 20);
			this.txt_nro_dni.TabIndex = 37;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(56, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "ID Catálogo";
			// 
			// cmb_id_catalogo
			// 
			this.cmb_id_catalogo.FormattingEnabled = true;
			this.cmb_id_catalogo.Location = new System.Drawing.Point(126, 132);
			this.cmb_id_catalogo.Name = "cmb_id_catalogo";
			this.cmb_id_catalogo.Pp_Display = "ID";
			this.cmb_id_catalogo.Pp_mensajeError = null;
			this.cmb_id_catalogo.Pp_nombre_campo = null;
			this.cmb_id_catalogo.Pp_nombre_tabla = "Catalogo";
			this.cmb_id_catalogo.Pp_seleccionado = false;
			this.cmb_id_catalogo.Pp_Tabla = "Catalogo";
			this.cmb_id_catalogo.Pp_validable = false;
			this.cmb_id_catalogo.Pp_Value = "ID";
			this.cmb_id_catalogo.Size = new System.Drawing.Size(121, 21);
			this.cmb_id_catalogo.TabIndex = 38;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(42, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 36;
			this.label4.Text = "Nombre Planta";
			// 
			// cmb_cod_planta
			// 
			this.cmb_cod_planta.FormattingEnabled = true;
			this.cmb_cod_planta.Location = new System.Drawing.Point(126, 178);
			this.cmb_cod_planta.Name = "cmb_cod_planta";
			this.cmb_cod_planta.Pp_Display = "NombreComun";
			this.cmb_cod_planta.Pp_mensajeError = null;
			this.cmb_cod_planta.Pp_nombre_campo = null;
			this.cmb_cod_planta.Pp_nombre_tabla = "Plantas";
			this.cmb_cod_planta.Pp_seleccionado = false;
			this.cmb_cod_planta.Pp_Tabla = "Plantas";
			this.cmb_cod_planta.Pp_validable = false;
			this.cmb_cod_planta.Pp_Value = "Codigo";
			this.cmb_cod_planta.Size = new System.Drawing.Size(121, 21);
			this.cmb_cod_planta.TabIndex = 38;
			// 
			// canjear
			// 
			this.canjear.Location = new System.Drawing.Point(190, 243);
			this.canjear.Name = "canjear";
			this.canjear.Size = new System.Drawing.Size(75, 23);
			this.canjear.TabIndex = 39;
			this.canjear.Text = "Canjear";
			this.canjear.UseVisualStyleBackColor = true;
			this.canjear.Click += new System.EventHandler(this.canjear_Click);
			// 
			// cancelar
			// 
			this.cancelar.Location = new System.Drawing.Point(98, 243);
			this.cancelar.Name = "cancelar";
			this.cancelar.Size = new System.Drawing.Size(75, 23);
			this.cancelar.TabIndex = 39;
			this.cancelar.Text = "Cancelar";
			this.cancelar.UseVisualStyleBackColor = true;
			this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
			// 
			// Frm_Generar_Canje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(342, 306);
			this.Controls.Add(this.cancelar);
			this.Controls.Add(this.canjear);
			this.Controls.Add(this.cmb_cod_planta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmb_id_catalogo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_nro_dni);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Name = "Frm_Generar_Canje";
			this.Text = "Canjes";
			this.Load += new System.EventHandler(this.Frm_Generar_Canje_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Clases.TextBox01 txt_nro_dni;
		private System.Windows.Forms.Label label3;
		private Clases.ComboBox01 cmb_id_catalogo;
		private System.Windows.Forms.Label label4;
		private Clases.ComboBox01 cmb_cod_planta;
		private System.Windows.Forms.Button canjear;
		private System.Windows.Forms.Button cancelar;
	}
}