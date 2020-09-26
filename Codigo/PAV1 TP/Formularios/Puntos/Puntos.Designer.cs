namespace PAV1_TP.Formularios.Puntos
{
    partial class Puntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puntos));
            this.cmb_TpoDNI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TpoFact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nro_Fact = new PAV1_TP.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.Cant_Ptos = new PAV1_TP.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.Nro_DNI = new PAV1_TP.Clases.TextBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.Fecha = new PAV1_TP.Clases.LabelText01();
            this.btn_RegistrarPuntos = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_TpoDNI
            // 
            this.cmb_TpoDNI.FormattingEnabled = true;
            this.cmb_TpoDNI.Location = new System.Drawing.Point(156, 98);
            this.cmb_TpoDNI.Name = "cmb_TpoDNI";
            this.cmb_TpoDNI.Size = new System.Drawing.Size(209, 24);
            this.cmb_TpoDNI.TabIndex = 1;
            this.cmb_TpoDNI.SelectedIndexChanged += new System.EventHandler(this.Tpo_DNI_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo DNI";
            // 
            // cmb_TpoFact
            // 
            this.cmb_TpoFact.FormattingEnabled = true;
            this.cmb_TpoFact.Location = new System.Drawing.Point(568, 101);
            this.cmb_TpoFact.Name = "cmb_TpoFact";
            this.cmb_TpoFact.Size = new System.Drawing.Size(209, 24);
            this.cmb_TpoFact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo Factura";
            // 
            // Nro_Fact
            // 
            this.Nro_Fact.Location = new System.Drawing.Point(568, 200);
            this.Nro_Fact.Name = "Nro_Fact";
            this.Nro_Fact.Pp_mensajeError = null;
            this.Nro_Fact.Pp_nombre_campo = null;
            this.Nro_Fact.Pp_nombre_tabla = null;
            this.Nro_Fact.Pp_validable = false;
            this.Nro_Fact.Size = new System.Drawing.Size(209, 22);
            this.Nro_Fact.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(429, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero Factura";
            // 
            // Cant_Ptos
            // 
            this.Cant_Ptos.Location = new System.Drawing.Point(568, 313);
            this.Cant_Ptos.Name = "Cant_Ptos";
            this.Cant_Ptos.Pp_mensajeError = null;
            this.Cant_Ptos.Pp_nombre_campo = null;
            this.Cant_Ptos.Pp_nombre_tabla = null;
            this.Cant_Ptos.Pp_validable = false;
            this.Cant_Ptos.Size = new System.Drawing.Size(209, 22);
            this.Cant_Ptos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(418, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de Puntos";
            // 
            // Nro_DNI
            // 
            this.Nro_DNI.Location = new System.Drawing.Point(156, 210);
            this.Nro_DNI.Name = "Nro_DNI";
            this.Nro_DNI.Pp_mensajeError = null;
            this.Nro_DNI.Pp_nombre_campo = null;
            this.Nro_DNI.Pp_nombre_tabla = null;
            this.Nro_DNI.Pp_validable = false;
            this.Nro_DNI.Size = new System.Drawing.Size(209, 22);
            this.Nro_DNI.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero DNI";
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Location = new System.Drawing.Point(61, 313);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fecha.Name = "Fecha";
            this.Fecha.Pp_Etiqueta = "Fecha";
            this.Fecha.Pp_Mascara = "";
            this.Fecha.Pp_mensajeError = null;
            this.Fecha.Pp_nombre_campo = null;
            this.Fecha.Pp_nombre_tabla = null;
            this.Fecha.Pp_Text = "";
            this.Fecha.Pp_validable = false;
            this.Fecha.Size = new System.Drawing.Size(316, 37);
            this.Fecha.TabIndex = 14;
            // 
            // btn_RegistrarPuntos
            // 
            this.btn_RegistrarPuntos.Location = new System.Drawing.Point(649, 374);
            this.btn_RegistrarPuntos.Name = "btn_RegistrarPuntos";
            this.btn_RegistrarPuntos.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarPuntos.TabIndex = 15;
            this.btn_RegistrarPuntos.Text = "Registrar";
            this.btn_RegistrarPuntos.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(748, 374);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(853, 409);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarPuntos);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nro_DNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cant_Ptos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nro_Fact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TpoFact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_TpoDNI);
            this.Name = "Puntos";
            this.Text = "Puntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_TpoDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_TpoFact;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 Nro_Fact;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 Cant_Ptos;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 Nro_DNI;
        private System.Windows.Forms.Label label6;
        private Clases.LabelText01 Fecha;
        private System.Windows.Forms.Button btn_RegistrarPuntos;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}