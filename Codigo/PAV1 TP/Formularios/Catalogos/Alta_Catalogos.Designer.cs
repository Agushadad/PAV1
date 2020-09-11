﻿namespace PAV1_TP.Formularios.Catalogos
{
    partial class Alta_Catalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Catalogos));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdCatalogo = new System.Windows.Forms.TextBox();
            this.txt_PuntosNecesarios = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_RegistrarCatalogo = new System.Windows.Forms.Button();
            this.chk_Id_Plantas_Catalogos = new PAV1_TP.Clases.CheckBoxList01();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registro catalogos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Plantas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Puntos necesarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Catalogo";
            // 
            // txt_IdCatalogo
            // 
            this.txt_IdCatalogo.Location = new System.Drawing.Point(110, 71);
            this.txt_IdCatalogo.Name = "txt_IdCatalogo";
            this.txt_IdCatalogo.Size = new System.Drawing.Size(83, 20);
            this.txt_IdCatalogo.TabIndex = 1;
            // 
            // txt_PuntosNecesarios
            // 
            this.txt_PuntosNecesarios.Location = new System.Drawing.Point(154, 204);
            this.txt_PuntosNecesarios.Name = "txt_PuntosNecesarios";
            this.txt_PuntosNecesarios.Size = new System.Drawing.Size(78, 20);
            this.txt_PuntosNecesarios.TabIndex = 3;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(119, 258);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(82, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_RegistrarCatalogo
            // 
            this.btn_RegistrarCatalogo.Location = new System.Drawing.Point(38, 258);
            this.btn_RegistrarCatalogo.Name = "btn_RegistrarCatalogo";
            this.btn_RegistrarCatalogo.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarCatalogo.TabIndex = 4;
            this.btn_RegistrarCatalogo.Text = "Registrar";
            this.btn_RegistrarCatalogo.UseVisualStyleBackColor = true;
            // 
            // chk_Id_Plantas_Catalogos
            // 
            this.chk_Id_Plantas_Catalogos.FormattingEnabled = true;
            this.chk_Id_Plantas_Catalogos.Location = new System.Drawing.Point(110, 109);
            this.chk_Id_Plantas_Catalogos.Name = "chk_Id_Plantas_Catalogos";
            this.chk_Id_Plantas_Catalogos.Pp_Display = "NombreComun";
            this.chk_Id_Plantas_Catalogos.Pp_mensajeError = "Falta seleccionar alguna planta";
            this.chk_Id_Plantas_Catalogos.Pp_nombre_campo = "Id_Planta";
            this.chk_Id_Plantas_Catalogos.Pp_nombre_tabla = "Catalogo";
            this.chk_Id_Plantas_Catalogos.Pp_seleccionado = false;
            this.chk_Id_Plantas_Catalogos.Pp_Tabla = "Plantas";
            this.chk_Id_Plantas_Catalogos.Pp_validable = false;
            this.chk_Id_Plantas_Catalogos.Pp_Value = "Codigo";
            this.chk_Id_Plantas_Catalogos.Size = new System.Drawing.Size(107, 79);
            this.chk_Id_Plantas_Catalogos.TabIndex = 6;
            this.chk_Id_Plantas_Catalogos.SelectedIndexChanged += new System.EventHandler(this.chk_Id_Plantas_Catalogos_SelectedIndexChanged);
            // 
            // Alta_Catalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 293);
            this.Controls.Add(this.chk_Id_Plantas_Catalogos);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarCatalogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IdCatalogo);
            this.Controls.Add(this.txt_PuntosNecesarios);
            this.MaximizeBox = false;
            this.Name = "Alta_Catalogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta_Catalogos";
            this.Load += new System.EventHandler(this.Alta_Catalogos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdCatalogo;
        private System.Windows.Forms.TextBox txt_PuntosNecesarios;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_RegistrarCatalogo;
        private Clases.CheckBoxList01 chk_Id_Plantas_Catalogos;
    }
}