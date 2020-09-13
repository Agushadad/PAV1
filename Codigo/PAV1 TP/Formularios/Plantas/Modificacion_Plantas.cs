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
        public string Codigo { get; set; }
        public Modificacion_Plantas()
        {
            InitializeComponent();
        }

        private void Modificacion_Plantas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = planta.Recuperar_Planta(Codigo);
            cmb_TipoPlanta.SelectedValue = int.Parse(tabla.Rows[0]["TipoPlanta"].ToString());
            txt_NomCienPlanta.Text = tabla.Rows[0]["NombreCientifico"].ToString();
            txt_NomComPlanta.Text = tabla.Rows[0]["NombreComun"].ToString();
            txt_PrecioPlanta.Text = tabla.Rows[0]["Precio"].ToString();
            txt_StockPlanta.Text = tabla.Rows[0]["Stock"].ToString();
        }

        private void btn_RegistrarPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            Es_Planta _ep = new Es_Planta();

            if (tratamientos.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _ep.NombreCientifico = txt_NomCienPlanta.Text;
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
