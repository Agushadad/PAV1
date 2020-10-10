using Microsoft.Reporting.WinForms;
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

namespace PAV1_TP.Reportes.ReportesVentas
{
    public partial class Frm_ReporteVentas : Form
    {
        Ng_Factura factura = new Ng_Factura();
        DataTable TablaVentas = new DataTable();
        string restriccion = "";
        public Frm_ReporteVentas()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentas_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            this.Rv_VentasXMonto.RefreshReport();
        }
        private void BuscarVentas()
        {
            if (txt_NroDoc.Text == "" && chk_TodasLasVentas.Checked == false)
            {
                MessageBox.Show("No se realizo seleccion para la busqueda");
                return;
            }
            if (chk_TodasLasVentas.Checked == true)
            {
                TablaVentas = factura.Buscar_Todas_Facturas();
                return;
            }
            if (txt_NroDoc.Text != "")
            {
                TablaVentas = factura.Buscar_Factura(txt_NroDoc.Text);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarVentas();
            ArmarReporte();
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
            Rv_Ventas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Ventas.LocalReport.DataSources.Clear();
            Rv_Ventas.LocalReport.DataSources.Add(Datos);
            Rv_Ventas.RefreshReport();
        }
        private void BuscarPlantaXMonto()
        {
            TablaVentas = factura.BuscarFacturaXMonto(txt_Monto.Text);
            return;
        }
        private void ArmarReporteXMonto()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
            Rv_VentasXMonto.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_VentasXMonto.LocalReport.DataSources.Clear();
            Rv_VentasXMonto.LocalReport.DataSources.Add(Datos);
            Rv_VentasXMonto.RefreshReport();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Monto.Text == "")
            {
                MessageBox.Show("Ingrese un monto");
            }
            else
            {
                BuscarPlantaXMonto();
                ArmarReporteXMonto();
            }
        }
    }
}
