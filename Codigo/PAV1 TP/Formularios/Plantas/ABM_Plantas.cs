﻿using PAV1_TP.Formularios;
using PAV1_TP.Formularios.Plantas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Negocios;

namespace WindowsFormsApp2

{
    public partial class ABM_Plantas : Form
    {
        Ng_Planta Planta = new Ng_Planta();
        public ABM_Plantas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarPlanta_Click(object sender, EventArgs e)
        {
            Form Alta_Planta = new Alta_Plantas();
            Alta_Planta.Show();
        }

        private void btn_ModificarPlanta_Click(object sender, EventArgs e)
        {
            Modificacion_Plantas Modif = new Modificacion_Plantas();
            if (Grid_Planta.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para modificar");
            }
            else
            {
                Modif.Codigo = Grid_Planta.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }
    }
}
