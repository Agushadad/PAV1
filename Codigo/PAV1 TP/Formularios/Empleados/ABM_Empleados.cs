using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Empleados
{
    public partial class ABM_Empleados : Form
    {
        public ABM_Empleados()
        {
            InitializeComponent();
        }

        private void ABM_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_AgregarEmp_Click(object sender, EventArgs e)
        {
            Form Alta_Empleado = new Alta_Empleado();
            Alta_Empleado.Show();
        }

        private void btn_EditarEmp_Click(object sender, EventArgs e)
        {
            Form Modificacion_Empleado = new Modificacion_Empleado();
            Modificacion_Empleado.Show();
        }
    }
}
