using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Cargas
{
    public partial class Frm_GenerarFactura : Form
    {
        Ng_Cliente cliente = new Ng_Cliente();
        Es_Cliente clientes = new Es_Cliente();
        public Frm_GenerarFactura()
        {
            InitializeComponent();
        }

        private void Frm_GenerarFactura_Load(object sender, EventArgs e)
        {
            cmb_TipoFactura.Cargar();
        }

        private void labelText014_Load(object sender, EventArgs e)
        {

        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
        }
    }
}
