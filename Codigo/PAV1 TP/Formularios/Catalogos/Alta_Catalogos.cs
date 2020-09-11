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
    public partial class Alta_Catalogos : Form
    {
        public Alta_Catalogos()
        {
            InitializeComponent();
        }

        private void Alta_Catalogos_Load(object sender, EventArgs e)
        {
            chk_Id_Plantas_Catalogos.Cargar();
        }

        private void chk_Id_Plantas_Catalogos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
