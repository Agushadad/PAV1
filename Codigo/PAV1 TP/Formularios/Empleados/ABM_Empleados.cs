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
using PAV1_TP.Negocios;

namespace PAV1_TP.Formularios.Empleados
{
    public partial class ABM_Empleados : Form
    {
        Ng_Empleados Empleados = new Ng_Empleados();
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

        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Emp.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Emp.Rows.Add();
                Grid_Emp.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                Grid_Emp.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                Grid_Emp.Rows[i].Cells[2].Value = tabla.Rows[i]["Apellido"].ToString();
                Grid_Emp.Rows[i].Cells[3].Value = tabla.Rows[i]["Telefono"].ToString();
                Grid_Emp.Rows[i].Cells[4].Value = tabla.Rows[i]["Calle"].ToString();
                Grid_Emp.Rows[i].Cells[5].Value = tabla.Rows[i]["Nro_Calle"].ToString();



            }
        }
        private void btn_ConsultarEmp_Click(object sender, EventArgs e)
            {
                Be_BaseDeDatos _BD = new Be_BaseDeDatos();
                if (chk_Todos.Checked == true)
                {
                    Cargar_Grilla(Empleados.Todos_Los_Empleados());
                }
            
                if (txt_IdEmpleado != "" && txt_NombreEmpleado == "" && txt_ApellidoEmpleado == "")
                    {
                    }

        private void textBox011_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
