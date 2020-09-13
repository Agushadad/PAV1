using PAV1_TP.Clases;
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

namespace PAV1_TP.Formularios
{
    public partial class Alta_Plantas : Form
    {
        Ng_Planta planta = new Ng_Planta();
        public Alta_Plantas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            Es_Planta _ep = new Es_Planta();

            if (tratamientos.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                _ep.Codigo = int.Parse(txt_CodPlanta.Text.ToString());
                _ep.NombreCientifico = txt_NCientPlanta.Text;
                _ep.NombreComun = txt_NomComPlanta.Text;
                _ep.Tipo = cmb_TipoPlanta.SelectedValue.ToString();
                _ep.Precio = int.Parse(txt_PrecioPlanta.Text.ToString());
                _ep.Stock = int.Parse(txt_StockPlanta.Text.ToString());

                planta.Insertar(_ep);
                MessageBox.Show("Planta registrada correctamente");
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) 
        {
            this.Close(); 
        }
    }
       
}
