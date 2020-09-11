﻿using PAV1_TP.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Catalogos
{
    public partial class ABM_Catalogos : Form
    {
        Ng_Catalogo catalogo = new Ng_Catalogo();
        public ABM_Catalogos()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form AltaCatalogo = new Alta_Catalogos();
            AltaCatalogo.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form ModifCatalogo = new Modificacion_Catalogos();
            ModifCatalogo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk_CatalogosActivos.Checked == true && chk_CatalogosInactivos.Checked == true)
            {
                Cargar_Grilla(catalogo.Todos_Los_Catalogos());
                return;
            }
            if (chk_CatalogosActivos.Checked == true)
            {
                Cargar_Grilla(catalogo.Catalogos_Activos());
                return;
            }
            if (chk_CatalogosInactivos.Checked == true)
            {
                Cargar_Grilla(catalogo.Catalogos_Inactivos());
                return;
            }
            if (txt_IdCatalogo.Text == "" && txt_IdCatalogoPlanta.Text == "" )
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdCatalogo.Text != "" || txt_IdCatalogoPlanta.Text != "" )
            {
                Cargar_Grilla(catalogo.Buscar_Catalogo(txt_IdCatalogo.Text, txt_IdCatalogoPlanta.Text));
            }
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Catalogos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Catalogos.Rows.Add();
                Grid_Catalogos.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                Grid_Catalogos.Rows[i].Cells[1].Value = tabla.Rows[i]["Id_Planta"].ToString();
                Grid_Catalogos.Rows[i].Cells[2].Value = tabla.Rows[i]["Puntos_Necesarios"].ToString();
            }
        }

        private void btn_SalirCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
