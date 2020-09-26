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
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Puntos
{
    public partial class Puntos : Form
    {
        Ng_Puntos puntos = new Ng_Puntos();
        public Puntos()
        {
            InitializeComponent();
        }

        private void labelText011_Load(object sender, EventArgs e)
        {

        }

        private void Tpo_DNI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Plantas_Load(object sender, EventArgs e)
        {
            cmb_TpoFact.Cargar();
            cmb_TpoDNI.Cargar();
        }

        private void btn_RegistrarPuntos_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Puntos _epu = new Es_Puntos();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                _epu.Nro_DNI = puntos.Recuperar_DNI(Nro_DNI);
                _epu.Tpo_DNI = cmb_TpoDNI.SelectedValue.ToString();
                _epu.Nro_Fact = puntos.Recuperar_Factura(Nro_Fact);
                _epu.Tpo_Fact = cmb_TpoFact.SelectedValue.ToString();
                _epu.Cant_Ptos = Cant_Ptos.Text;
                _epu.Fecha = Fecha.Text;

                puntos.Insertar(_epu);
                MessageBox.Show("Los Puntos han sido registrados correctamente");
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
