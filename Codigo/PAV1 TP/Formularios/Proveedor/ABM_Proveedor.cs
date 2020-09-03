using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Proveedor
{
    public partial class ABM_Proveedor : Form
    {
        public ABM_Proveedor()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form AltaProveedor = new Alta_Proveedor();
            AltaProveedor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form ModifProveedor = new Modificacion_Proveedor();
            ModifProveedor.Show();
        }
    }
}
