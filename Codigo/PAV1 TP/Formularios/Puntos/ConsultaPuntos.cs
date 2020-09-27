using PAV1_TP.Clases;
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

namespace PAV1_TP.Formularios.Puntos
{
    public partial class ConsultaPuntos : Form
    {
        Ng_Puntos puntos = new Ng_Puntos();
        TratamientosEspeciales tratamiento = new TratamientosEspeciales();
        public ConsultaPuntos()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = puntos.PuntosTotales(txt_NroDoc.Text);
                txt_Puntos.Text = tabla.Rows[0]["Puntos"].ToString();
            }
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            Form CargaPuntos = new Frm_CargaPuntos();
            CargaPuntos.Show();
        }
    }
}
