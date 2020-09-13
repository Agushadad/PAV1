using PAV1_TP.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Plantas
{
    public partial class Modificacion_Plantas : Form
    {
        Ng_Planta planta = new Ng_Planta();
        public Modificacion_Plantas()
        {
            InitializeComponent();
        }

        private void Modificacion_Plantas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Plantas.Recuperar_Planta(Codigo);
            txt_NomCienPlanta = ;
            txt_NomComPlanta = ;
            txt_PrecioPlanta = ;
            txt_StockPlanta = ;
        }
    }

}
