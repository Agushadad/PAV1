using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ABM_Clientes : Form
    {
        public ABM_Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ABM_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_SalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
