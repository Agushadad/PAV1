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
namespace PAV1_TP.Formularios.Producto
{
    
    public partial class Modificacion_Producto : Form
    {
        public string ID { get; set; }
        Ng_Producto producto = new Ng_Producto();
        public Modificacion_Producto()
        {
            InitializeComponent();
        }

        private void Modificacion_Producto_Load(object sender, EventArgs e)
        {
            //Recupero la tabla producto
            DataTable tablaProducto = new DataTable();
            tablaProducto = producto.RecuperarProducto(ID);

            //Recupero la tabla TipoProducto
            DataTable tablaTipoProducto = new DataTable();
            tablaTipoProducto = producto.RecuperarTipoProducto(cmb_TipoProducto.Text = tablaProducto.Rows[0]["Tipo"].ToString());



            //Lleno atributos de producto
            txt_IdProducto.Text = ID;
            txt_NombreProducto.Text = tablaProducto.Rows[0]["Nombre"].ToString();
            cmb_TipoProducto.Text = tablaTipoProducto.Rows[0]["Nombre"].ToString();
            txt_StockProducto.Text = tablaProducto.Rows[0]["Stock"].ToString();
            txt_CostoProd.Text = tablaProducto.Rows[0]["Costo"].ToString();
            txt_PrecioProducto.Text = tablaProducto.Rows[0]["Precio"].ToString();

            int items = int.Parse(chk_CompuestoProducto.SelectedItems.Count.ToString());

            if (tablaProducto.Rows[0]["Composicion"].ToString() != null)
            {


            }
        }

        private void btn_RegistrarProducto_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Producto _Ep = new Es_Producto();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ep.Codigo = ID;
                _Ep.Nombre = txt_NombreProducto.Text;
                _Ep.Tipo = cmb_TipoProducto.Text;
                _Ep.Stock = txt_StockProducto.Text;
                _Ep.Costo = txt_CostoProd.Text;
                _Ep.Precio = txt_PrecioProducto.Text;

            }
    }
    
}
