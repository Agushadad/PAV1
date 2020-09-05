using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Producto
{
    public partial class ABM_Productos : Form
    {
        public ABM_Productos()
        {
            InitializeComponent();
        }

        private void ABM_Productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            Form Alta_Producto = new Alta_Producto();
            Alta_Producto.Show();
        }

        private void btn_ModifProveedor_Click(object sender, EventArgs e)
        {
            Form Modificacion_Producto = new Modificacion_Producto();
            Modificacion_Producto.Show();
        }
    }
}
