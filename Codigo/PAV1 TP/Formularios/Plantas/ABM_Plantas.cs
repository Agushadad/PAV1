using PAV1_TP.Formularios;
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

        private void btn_ConsultarPlanta(object sender, EventArgs e)
        {
            if (chk_TodosPlanta.Checked == true)
            {
                Cargar_Grilla(Planta.Todas_las_Plantas());
                return;
            }
            if (check_Plantas_Activas.Checked == true)
            {
                Cargar_Grilla(Planta.Plantas_Activas());
                return;
            }
            if (check_Plantas_Inactivas.Checked == true)
            {
                Cargar_Grilla(Planta.Plantas_Inactivas());
                return;
            }
            if (txt_CodPlanta.Text == "" && txt_NomComPlanta.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_CodPlanta.Text != "" || txt_NomComPlanta.Text != "")
            {
                Cargar_Grilla(Planta.Buscar_Planta(int.Parse(txt_CodPlanta.Text.ToString()), txt_NomComPlanta.Text));
            }
        }

        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Planta.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Planta.Rows.Add();
                Grid_Planta.Rows[i].Cells[0].Value = tabla.Rows[i]["Codigo"].ToString();
                Grid_Planta.Rows[i].Cells[1].Value = tabla.Rows[i]["NombreCientifico"].ToString();
                Grid_Planta.Rows[i].Cells[2].Value = tabla.Rows[i]["NombreComun"].ToString();
                Grid_Planta.Rows[i].Cells[3].Value = tabla.Rows[i]["Tipo"].ToString();
                Grid_Planta.Rows[i].Cells[4].Value = tabla.Rows[i]["Precio"].ToString();
                Grid_Planta.Rows[i].Cells[5].Value = tabla.Rows[i]["Stock"].ToString();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EliminarPlanta_Click(object sender, EventArgs e)
        {
            if (Grid_Planta.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para eliminar");
            }
            else
            {
                (int Codigo, string NomComPlanta) = Grid_Planta.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la planta seleccionada?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    Planta.Eliminar(Codigo, NomComPlanta);
                    Cargar_Grilla(Planta.Todas_las_Plantas());
                }
            }

        }
    }

 }