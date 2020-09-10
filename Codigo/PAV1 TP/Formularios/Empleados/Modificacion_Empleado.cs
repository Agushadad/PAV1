using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Negocios;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Empleados
{
    public partial class Modificacion_Empleado : Form
    {
        Ng_Empleados Empleado = new Ng_Empleados();
        

        public string ID { get; set; }

        public Modificacion_Empleado()
        {
            InitializeComponent();
        }

        private void Modificacion_Empleado_Load(object sender, EventArgs e)
        {
            cmb_BarrioEmpleado.Cargar();
            cmb_LocalidadEmpleado.Cargar();
            DataTable tabla = new DataTable();
            tabla = Empleado.Recuperar_Usuario(ID);
            txt_IdEmpleado.Text = ID;
            txt_NombreEmpleado.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_Contraseña.Text = tabla.Rows[0]["Contraseña"].ToString();
            txt_Contraseña2.Text = txt_Contraseña.Text;
            txt_ApellidoEmpleado.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_TelefonoEmpleado.Text = tabla.Rows[0]["Telefono"].ToString();
            txt_CalleEmpleado.Text = tabla.Rows[0]["Calle"].ToString();
            txt_NCalleEmpleado.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            cmb_BarrioEmpleado.SelectedValue = int.Parse(tabla.Rows[0]["Barrio"].ToString());
            cmb_LocalidadEmpleado.SelectedValue = int.Parse(tabla.Rows[0]["Localidad"].ToString());

        }

        private void btn_RegistrarEmpleado_Click(object sender, EventArgs e)
        {
        }


        
    }
}

