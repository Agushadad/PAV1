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

namespace PAV1_TP.Formularios.Canje
{
    public partial class Frm_Canje : Form
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        Ng_Canje canje = new Ng_Canje();
        string IdPlanta { get; set; }
        string Puntos { get; set; }
        string TipoDoc { get; set; }
        public Frm_Canje()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Canje_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (txt_IdCatalogo.Text != "")
            {
                Cargar_Grilla(canje.BuscarCatalogo(txt_IdCatalogo.Text));
            }
            else
            {
                MessageBox.Show("No se ingreso el id de catalogo");
            }
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Canje.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Canje.Rows.Add();
                Grid_Canje.Rows[i].Cells[0].Value = tabla.Rows[i]["Id_Planta"].ToString();
                Grid_Canje.Rows[i].Cells[1].Value = tabla.Rows[i]["Puntos_Necesarios"].ToString();

            }
        }

        private void btn_Fehca_Click(object sender, EventArgs e)
        {
            txt_Fecha.Text = _BD.FechaHora();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            IdPlanta = Grid_Canje.CurrentRow.Cells[0].Value.ToString();
            Puntos = Grid_Canje.CurrentRow.Cells[1].Value.ToString();
            DataTable tabla = new DataTable();
            tabla = canje.RecuperarTipoDoc(txt_NroDoc.Text);
            TipoDoc = tabla.Rows[0]["TipoDoc"].ToString();
            canje.insertarCanje(canje.NuevoId(), TipoDoc, txt_NroDoc.Text, txt_IdCatalogo.Text,
                                IdPlanta, txt_Fecha.Text, Puntos);
            canje.insertarPuntos(TipoDoc, txt_NroDoc.Text, 0.ToString(), 0.ToString(), Puntos, txt_Fecha.Text);
        }
    }
}
