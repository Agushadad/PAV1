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
using PAV1_TP.Clases;

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
            //this.Rv_VentasXMonto.RefreshReport();
            //this.Rv_VentasXMes.RefreshReport();
        }
        private void BuscarVentas()
        {
            if (txt_NroDoc.Text == "" && chk_TodasLasVentas.Checked == false)
            {
                MessageBox.Show("No se realizó selección para la búsqueda");
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

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarVentas();
            ArmarReporte();
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
	
		//***************************************************ReportesGyM*************************************************************

        private void BuscarMAYORVentasPorMes()
        {
            if (txt_Mes.Text == "")
            {
                MessageBox.Show("Ingresar mes");
                return;
            }

			if (txt_Mes.Text != "")
			{
				if (int.Parse(txt_Mes.Text) < 1 || int.Parse(txt_Mes.Text) > 12)
				{
					MessageBox.Show("No se ingresó un mes válido");
					return;

				}
				else
				{
					TablaVentas = factura.Buscar_Mayor_Venta_Mes(txt_Mes.Text);
					return;
				}
			}

		

        }

        private void ArmarReportesMAYORVENTAPorMes()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
            Rv_VentasXMes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeDMayorVM.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP09", "Restringido por " + restriccion);
            Rv_VentasXMes.LocalReport.DataSources.Clear();
            Rv_VentasXMes.LocalReport.DataSources.Add(Datos);
            Rv_VentasXMes.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarMAYORVentasPorMes();
            ArmarReportesMAYORVENTAPorMes();
        }

        

        private void btn_PPM_Click(object sender, EventArgs e)
        {
           
        }

     

        private void btn_TPPM_Click(object sender, EventArgs e)
        {
            
        }
        private void ArmarReporteMVM()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
            Rv_MVM.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.Informe MVM.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_MVM.LocalReport.DataSources.Clear();
            Rv_MVM.LocalReport.DataSources.Add(Datos);
            Rv_MVM.RefreshReport();
        }
        private void BuscarMVM()
        {
            TablaVentas = factura.ReporteMVM();
            return;
        }


        private void btn_BuscMVM_Click(object sender, EventArgs e)
        {
            BuscarMVM();
            ArmarReporteMVM();
        }

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Rv_VentasXMes_Load(object sender, EventArgs e)
		{

		}

		//**************************************************************GYM VENTAS MENOR************************

		private void BuscarMENORVentasPorMes()
		{
			if (txtMes.Text == "")
			{
				MessageBox.Show("Ingresar mes");
				return;
			}

			if (txtMes.Text != "")
			{
				if (int.Parse(txtMes.Text) < 1 || int.Parse(txtMes.Text) > 12)
				{
					MessageBox.Show("No se ingresó un mes válido");
					return;
				}
				else
				{
					TablaVentas = factura.Buscar_Menor_Venta_Mes(txtMes.Text);
					return;
				}
			}
			


		}

		private void ArmarReportesMENORVENTAPorMes()
		{
			ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
			Rv_MenorVentasMes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeDMenorVM.rdlc";
			ReportParameter[] parametros = new ReportParameter[1];
			parametros[0] = new ReportParameter("RP05", "Restringido por " + restriccion);
			Rv_MenorVentasMes.LocalReport.DataSources.Clear();
			Rv_MenorVentasMes.LocalReport.DataSources.Add(Datos);
			Rv_MenorVentasMes.RefreshReport();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			BuscarMENORVentasPorMes();
			ArmarReportesMENORVENTAPorMes();
		}
        //**************************************************************Est ventas x monto************************

        private void GenerarGraficoTorta()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
			ReportDataSource datos = new ReportDataSource("DataSet1", TablaVentas);
            RV_AEVentxMonto.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.Est_VentaxMonto.rdlc";
			ReportParameter[] parametro = new ReportParameter[2];
			parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
            parametro[1] = new ReportParameter("RP02", "Análisis Estadístico empleados con ventas que superan el monto: " + txt_Est_Monto.Text);
            RV_AEVentxMonto.LocalReport.SetParameters(parametro);
            RV_AEVentxMonto.LocalReport.DataSources.Clear();
            RV_AEVentxMonto.LocalReport.DataSources.Add(datos);
            RV_AEVentxMonto.RefreshReport();
        }
        private void GenerarGraficoBarrasVert()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            ReportDataSource datos = new ReportDataSource("DataSet1", TablaVentas);
            RV_AEVentxMonto.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.Est_VentaxMonto2.rdlc";
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
            parametro[1] = new ReportParameter("RP02", "Análisis Estadístico empleados con ventas que superan el monto: " + txt_Est_Monto.Text);
            RV_AEVentxMonto.LocalReport.SetParameters(parametro);
            RV_AEVentxMonto.LocalReport.DataSources.Clear();
            RV_AEVentxMonto.LocalReport.DataSources.Add(datos);
            RV_AEVentxMonto.RefreshReport();
        }

        private void GenerarGraficoBarrasHor()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            ReportDataSource datos = new ReportDataSource("DataSet1", TablaVentas);
            RV_AEVentxMonto.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.Est_VentaxMonto3.rdlc";
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
            parametro[1] = new ReportParameter("RP02", "Análisis Estadístico empleados con ventas que superan el monto: " + txt_Est_Monto.Text);
            RV_AEVentxMonto.LocalReport.SetParameters(parametro);
            RV_AEVentxMonto.LocalReport.DataSources.Clear();
            RV_AEVentxMonto.LocalReport.DataSources.Add(datos);
            RV_AEVentxMonto.RefreshReport();
        }
        private void btn_AEVentxMonto_Click(object sender, EventArgs e)
        {
            if (txt_Est_Monto.Text == "")
            {
                MessageBox.Show("Ingrese un monto");
                txt_Est_Monto.Focus();
                return;
            }
            if (cmb_EstPeriodo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de gráfico");
                cmb_EstPeriodo.Focus();
                return;
            }

            if (cmb_EstPeriodo.SelectedItem.ToString() == "Gráfico de torta")
            {
                TablaVentas = factura.BuscarFacturaXMonto(txt_Est_Monto.Text);
                GenerarGraficoTorta();
            }
            if (cmb_EstPeriodo.SelectedItem.ToString() == "Gráfico de barras (vertical)")
            {
                TablaVentas = factura.BuscarFacturaXMonto(txt_Est_Monto.Text);
                GenerarGraficoBarrasVert();
            }

            if (cmb_EstPeriodo.SelectedItem.ToString() == "Gráfico de barras (horizontal)")
            {
                TablaVentas = factura.BuscarFacturaXMonto(txt_Est_Monto.Text);
                GenerarGraficoBarrasHor();
            }
        }
    }
}
