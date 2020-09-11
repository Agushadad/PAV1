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
using PAV1_TP.Clases;
using PAV1_TP.Negocios;
using System.Runtime.Remoting.Messaging;

namespace PAV1_TP.Formularios.Catalogos
{
    public partial class Modificacion_Catalogos : Form
    {
        Ng_Catalogo catalogo = new Ng_Catalogo();
        public string ID { get; set; }
        public Modificacion_Catalogos()
        {
            InitializeComponent();
        }

        private void Modificacion_Catalogos_Load(object sender, EventArgs e)
        {
            cmb_EstadoCatalogo.Cargar();
            chk_Id_Plantas_Catalogos.Cargar();
            DataTable tabla = new DataTable();
            tabla = catalogo.Recuperar_Usuario(ID);
            DataTable tabla2 = new DataTable();
            txt_IdCatalogo.Text = ID;
            txt_PuntosNecesarios.Text = tabla.Rows[0]["Puntos_Necesarios"].ToString();
            chk_Id_Plantas_Catalogos.SelectedValue = int.Parse(tabla.Rows[0]["Id_Planta"].ToString());
            cmb_EstadoCatalogo.Text = tabla.Rows[0]["Estado"].ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Catalogo _ec = new Es_Catalogo();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                _ec.ID = txt_IdCatalogo.Text;
                _ec.Id_Planta = chk_Id_Plantas_Catalogos.CheckedItems.ToString();
                _ec.Puntos_Necesarios = txt_PuntosNecesarios.Text;
                _ec.Estado = cmb_EstadoCatalogo.SelectedValue.ToString();

                if (chk_Id_Plantas_Catalogos.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Selecciona solamente una opcion de Id de planta");
                    return;
                }
                if (chk_Id_Plantas_Catalogos.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No se selecciono ninguna opcion de Id de planta");
                    return;
                }
                if (chk_Id_Plantas_Catalogos.CheckedItems.Count == 1)
                {
                    catalogo.Modificar(_ec);
                    MessageBox.Show("Catalogo modificado correctamente");
                    this.Close();

                }
            }
        }
    }
}
