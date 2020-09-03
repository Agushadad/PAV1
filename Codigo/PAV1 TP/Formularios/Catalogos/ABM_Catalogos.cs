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
    }
}
