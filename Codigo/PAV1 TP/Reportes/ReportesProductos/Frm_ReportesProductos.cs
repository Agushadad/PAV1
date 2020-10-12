using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PAV1_TP.Negocios;

namespace PAV1_TP.Reportes.ReportesProdcutos
{
    public partial class Frm_ReportesProductos : Form
    {
        Ng_Producto producto = new Ng_Producto();
        DataTable TablaProductos = new DataTable();
        string restriccion = "";
        public Frm_ReportesProductos()
        {
            InitializeComponent();
        }

        private void Frm_ReportesProductos_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
        private void BuscarProductos()
        {
            TablaProductos = producto.Productos_Activos();
            return;
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaProductos);
            Rv_Productos.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesProductos.InformeProductos.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Productos.LocalReport.DataSources.Clear();
            Rv_Productos.LocalReport.DataSources.Add(Datos);
            Rv_Productos.RefreshReport();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarProductos();
            ArmarReporte();
        }

        DataTable tablaTPMV = new DataTable();

        private void BuscarTPMV()
        {
            if (txt_MesTPMV.Text != "")
            {
                if (int.Parse(txt_MesTPMV.Text) > 12 | int.Parse(txt_MesTPMV.Text) == 0)
                {
                    MessageBox.Show("Ingrese un mes correcto");
                    txt_MesTPMV.Focus();
                    return;
                }
                else
                {
                    TablaProductos = producto.ReporteTPMV(txt_MesTPMV.Text);
                    if (TablaProductos.Rows.Count == 0)
                    {
                        MessageBox.Show("No hubo ventas en el mes ingresado", "ATENCIÓN");
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingresar Mes", "ATENCIÓN");
                txt_MesTPMV.Focus();
            }
        }

        private void ArmarReporteTPMV()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaProductos);
            Rv_TipoProdMasVendido.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesProductos.Informe_TPMV.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_TipoProdMasVendido.LocalReport.DataSources.Clear();
            Rv_TipoProdMasVendido.LocalReport.DataSources.Add(Datos);
            Rv_TipoProdMasVendido.RefreshReport();
        }

        private void BuscarPMV()
        {
            if (txt_PMV.Text != "")
            {
                if (int.Parse(txt_PMV.Text) > 12 | int.Parse(txt_PMV.Text) == 0)
                {
                    MessageBox.Show("Ingrese un mes correcto");
                    txt_MesTPMV.Focus();
                    return;
                }
                else
                {
                    TablaProductos = producto.ReportePMV(txt_PMV.Text);
                    if (TablaProductos.Rows.Count == 0)
                    {
                        MessageBox.Show("No hubo ventas en el mes ingresado", "ATENCIÓN");
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingresar Mes", "ATENCIÓN");
                txt_PMV.Focus();
            }
        }

        private void ArmarReportePMV()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaProductos);
            RV_ProdMV.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesProductos.Informe_PMV.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            RV_ProdMV.LocalReport.DataSources.Clear();
            RV_ProdMV.LocalReport.DataSources.Add(Datos);
            RV_ProdMV.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscTP_Click_1(object sender, EventArgs e)
        {
            BuscarTPMV();
            ArmarReporteTPMV();
        }

        private void btn_BuscPMV_Click_1(object sender, EventArgs e)
        {
            BuscarPMV();
            ArmarReportePMV();
        }
    }
}
