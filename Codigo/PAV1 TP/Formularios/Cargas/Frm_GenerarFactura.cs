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

namespace PAV1_TP.Formularios.Cargas
{
    public partial class Frm_GenerarFactura : Form
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        Ng_Factura factura = new Ng_Factura();
        TratamientosEspeciales te = new TratamientosEspeciales();
        Ng_Producto producto = new Ng_Producto();
        Ng_Planta planta = new Ng_Planta();
        Ng_Cliente cliente = new Ng_Cliente();
        Es_Cliente clientes = new Es_Cliente();
        public Frm_GenerarFactura()
        {
            InitializeComponent();
        }

        private void Frm_GenerarFactura_Load(object sender, EventArgs e)
        {
            cmb_TipoFactura.Cargar();
            cmb_Plantas.Cargar();
            cmb_Productos.Cargar();
            grid_Plantas.Formatear("id,30;Nombre,130;Cantidad,70;Valor,70");
            grid_Productos.Formatear("id,30;Nombre,130;Cantidad,70;Valor,70");
        }

        private void labelText014_Load(object sender, EventArgs e)
        {

        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
        }

        private void btn_AgregarPlanta_Click(object sender, EventArgs e)
        {
            grid_Plantas.Rows.Add();
            int ind = grid_Plantas.Rows.Count - 1;
            grid_Plantas.Rows[ind].Cells[0].Value = cmb_Plantas.SelectedValue.ToString();
            grid_Plantas.Rows[ind].Cells[1].Value = cmb_Plantas.Text;
            grid_Plantas.Rows[ind].Cells[2].Value = txt_CantidadPlant.Text;
            grid_Plantas.Rows[ind].Cells[3].Value = txt_ValorPlanta.Text;
        }

        private void cmb_Plantas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = planta.Recuperar_Planta(cmb_Plantas.SelectedValue.ToString());
            txt_ValorPlanta.Text = tabla.Rows[0]["Precio"].ToString();
        }

        private void cmb_Productos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = producto.RecuperarProducto(cmb_Productos.SelectedValue.ToString());
            txt_ValorProd.Text = tabla.Rows[0]["Precio"].ToString();
        }

        private void btn_AgregarProd_Click(object sender, EventArgs e)
        {
            grid_Productos.Rows.Add();
            int ind = grid_Productos.Rows.Count - 1;
            grid_Productos.Rows[ind].Cells[0].Value = cmb_Productos.SelectedValue.ToString();
            grid_Productos.Rows[ind].Cells[1].Value = cmb_Productos.Text;
            grid_Productos.Rows[ind].Cells[2].Value = txt_CantidadProd.Text;
            grid_Productos.Rows[ind].Cells[3].Value = txt_ValorProd.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (te.ValidarFecha(ltxt_Fecha.Pp_Text) == TratamientosEspeciales.Validacion.incorrecta)
            {
                ltxt_Fecha.Focus();
                return;
            }
            if (grid_Plantas.Rows.Count == 0 && grid_Productos.Rows.Count == 0)
            {
                MessageBox.Show("No se cargo ninguna plata o producto");
            }
            else
            {
                factura.insertar(cmb_TipoFactura.SelectedValue.ToString(), factura.NuevoId(), 1.ToString(), txt_NroDoc.Text,
                             ltxt_Fecha.Text, txt_IdEmpleado.Text, 3.ToString(), grid_Plantas, grid_Productos);
                this.Close();
            }   

        }

        private void btn_Fehca_Click(object sender, EventArgs e)
        {
            ltxt_Fecha.Pp_Text = _BD.Fecha();
        }
    }
}
