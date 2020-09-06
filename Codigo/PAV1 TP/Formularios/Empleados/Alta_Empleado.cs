using PAV1_TP.Clases;
using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;
using System;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Empleados
{
    public partial class Alta_Empleado : Form
    {
        Ng_Empleados empleados = new Ng_Empleados();
        public Alta_Empleado()
        {
            InitializeComponent();
        }
        private void Alta_Empleado_Load(object sender, EventArgs e)
        {
            cmb_LocalidadEmpleado.Cargar();
            cmb_BarrioEmpleado.Cargar();
            cmb_EstadoEmp.Cargar();
        }

        private void btn_RegistrarEmpleado_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                if (txt_Contraseña.Text == txt_Contraseña2.Text)
                {
                    empleados.Insertar(this.Controls);
                    MessageBox.Show("Empleado registrado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los Password no coinciden");
                }
            }
        }

        private void btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
