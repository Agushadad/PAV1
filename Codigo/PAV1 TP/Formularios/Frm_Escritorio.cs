using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Formularios.Catalogos;
using PAV1_TP.Formularios.Proveedor;



namespace PAV1_TP
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Catalogo = new ABM_Catalogos();
            Catalogo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form Proveedor = new ABM_Proveedor();
            Proveedor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
