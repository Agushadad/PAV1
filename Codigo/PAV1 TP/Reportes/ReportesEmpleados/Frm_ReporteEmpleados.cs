﻿using PAV1_TP.Negocios;
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
using Microsoft.Reporting.WinForms;

namespace PAV1_TP.Reportes.ReportesEmpleados
{
    public partial class Frm_ReporteEmpleados : Form
    {
        Ng_Empleados empleado = new Ng_Empleados();
        DataTable TablaEmpleados = new DataTable();
		DataTable tablaEMP = new DataTable();
		TratamientosEspeciales te = new TratamientosEspeciales();
		string restriccion = "";
        public Frm_ReporteEmpleados()
        {
            InitializeComponent();
        }
        private void BuscarEmpleado()
        {
            TablaEmpleados = empleado.Empleados_Activos();
            return;
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaEmpleados);
            Rv_Empleado.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleados.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Empleado.LocalReport.DataSources.Clear();
            Rv_Empleado.LocalReport.DataSources.Add(Datos);
            Rv_Empleado.RefreshReport();
        }

        private void Frm_ReporteEmpleados_Load_1(object sender, EventArgs e)
        {

            //this.Rv_Empleado.RefreshReport();
            //this.rp_Empleado_Periodo.RefreshReport();
            this.rv_AnalisisPeriodo.RefreshReport();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarEmpleado();
            ArmarReporte();
        }

		//********************************************************************************************************************************************************************

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
					tablaEMP = empleado.Buscar_Empleado_Mayor_Ventas(txt_Mes.Text);
					return;
				}
			}
		}

		private void ArmarReporteMAYORVentaPorEmp()
		{
			ReportDataSource Datos = new ReportDataSource("DataSet1", tablaEMP);
			Rv_EMPMayorVentas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMasVentas.rdlc";
			ReportParameter[] parametros = new ReportParameter[1];
			parametros[0] = new ReportParameter("RP08", "Restringido por " + restriccion);
			Rv_EMPMayorVentas.LocalReport.DataSources.Clear();
			Rv_EMPMayorVentas.LocalReport.DataSources.Add(Datos);
			Rv_EMPMayorVentas.RefreshReport();
		}


		private void btnBuscar_Click(object sender, EventArgs e)
		{
			BuscarMAYORVentasPorMes();
			ArmarReporteMAYORVentaPorEmp();
		}


		//*******************************************************************************************
		private void BuscarMENORVentasPorMes()
		{
			if (txt_MesMenor.Text == "")
			{
				MessageBox.Show("Ingresar mes");
				return;
			}

			if (txt_MesMenor.Text != "")
			{
				if (int.Parse(txt_MesMenor.Text) < 1 || int.Parse(txt_MesMenor.Text) > 12)
				{
					MessageBox.Show("No se ingresó un mes válido");
					return;

				}
				else
				{
					tablaEMP = empleado.Buscar_Empleado_Menor_Ventas(txt_MesMenor.Text);
					return;
				}
			}
		}

		private void ArmarReporteMENORVentaPorEmp()
		{
			ReportDataSource Datos = new ReportDataSource("DataSet1", tablaEMP);
			Rv_EMPMenorVentas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMenorVentas.rdlc";
			ReportParameter[] parametros = new ReportParameter[1];
			parametros[0] = new ReportParameter("RP03", "Restringido por " + restriccion);
			Rv_EMPMenorVentas.LocalReport.DataSources.Clear();
			Rv_EMPMenorVentas.LocalReport.DataSources.Add(Datos);
			Rv_EMPMenorVentas.RefreshReport();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			BuscarMENORVentasPorMes();
			ArmarReporteMENORVentaPorEmp();
		}
		private void Buscar_x_Periodo()
        {
			if (te.ValidarFecha(txt_FechaDesde.Pp_Text) == TratamientosEspeciales.Validacion.incorrecta)
			{
				txt_FechaDesde.Focus();
				return;
			}
			if (te.ValidarFecha(txt_FechaHasta.Pp_Text) == TratamientosEspeciales.Validacion.incorrecta)
			{
				txt_FechaHasta.Focus();
				return;
			}
			else
			{
				tablaEMP = empleado.Buscar_Periodo(txt_FechaDesde.Pp_Text, txt_FechaHasta.Pp_Text);
				return;
			}
        }
		private void ArmarReporteEmpleadoPeriodo()
		{
			ReportDataSource Datos = new ReportDataSource("DataSet1", tablaEMP);
			rp_Empleado_Periodo.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformePeriodo.rdlc";
			ReportParameter[] parametros = new ReportParameter[1];
			parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
			rp_Empleado_Periodo.LocalReport.DataSources.Clear();
			rp_Empleado_Periodo.LocalReport.DataSources.Add(Datos);
			rp_Empleado_Periodo.RefreshReport();
		}


		private void nroMes_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPeriodo4_Click(object sender, EventArgs e)
        {
			Buscar_x_Periodo();
            ArmarReporteEmpleadoPeriodo();
		}

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Rv_Empleado_Load(object sender, EventArgs e)
        {

        }
		private void GenerarGraficoTorta()
        {
			Be_BaseDeDatos _BD = new Be_BaseDeDatos();
			ReportDataSource datos = new ReportDataSource("DataSet1", tablaEMP);
			rv_AnalisisPeriodo.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.Est_VentasPeriodo.rdlc";
			ReportParameter[] parametro = new ReportParameter[2];
			parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
			parametro[1] = new ReportParameter("RP02", "Análisis Estadístico de ventas de empleados entre: "
												+ ltxt_Desde2.Pp_Text + " y " + ltxt_Hasta2.Pp_Text);
			rv_AnalisisPeriodo.LocalReport.SetParameters(parametro);
			rv_AnalisisPeriodo.LocalReport.DataSources.Clear();
			rv_AnalisisPeriodo.LocalReport.DataSources.Add(datos);
			rv_AnalisisPeriodo.RefreshReport();
		}
		private void GenerarGraficoBarrasVert()
		{
			Be_BaseDeDatos _BD = new Be_BaseDeDatos();
			ReportDataSource datos = new ReportDataSource("DataSet1", tablaEMP);
			rv_AnalisisPeriodo.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.Est_VentasPeriodo2.rdlc";
			ReportParameter[] parametro = new ReportParameter[2];
			parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
			parametro[1] = new ReportParameter("RP02", "Análisis Estadístico de ventas de empleados entre: "
												+ ltxt_Desde2.Pp_Text + " y " + ltxt_Hasta2.Pp_Text);
			rv_AnalisisPeriodo.LocalReport.SetParameters(parametro);
			rv_AnalisisPeriodo.LocalReport.DataSources.Clear();
			rv_AnalisisPeriodo.LocalReport.DataSources.Add(datos);
			rv_AnalisisPeriodo.RefreshReport();
		}
		private void GenerarGraficoBarrasHor()
		{
			Be_BaseDeDatos _BD = new Be_BaseDeDatos();
			ReportDataSource datos = new ReportDataSource("DataSet1", tablaEMP);
			rv_AnalisisPeriodo.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.Est_VentasPeriodo3.rdlc";
			ReportParameter[] parametro = new ReportParameter[2];
			parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
			parametro[1] = new ReportParameter("RP02", "Análisis Estadístico de ventas de empleados entre: "
												+ ltxt_Desde2.Pp_Text + " y " + ltxt_Hasta2.Pp_Text);
			rv_AnalisisPeriodo.LocalReport.SetParameters(parametro);
			rv_AnalisisPeriodo.LocalReport.DataSources.Clear();
			rv_AnalisisPeriodo.LocalReport.DataSources.Add(datos);
			rv_AnalisisPeriodo.RefreshReport();
		}

		private void btn_CalcularESTPeriodo_Click(object sender, EventArgs e)
        {
			if (te.ValidarFecha(ltxt_Desde2.Pp_Text) == TratamientosEspeciales.Validacion.incorrecta)
			{
				MessageBox.Show("Falta cargar fecha desde");
				txt_FechaDesde.Focus();
				return;
			}
			if (te.ValidarFecha(ltxt_Hasta2.Pp_Text) == TratamientosEspeciales.Validacion.incorrecta)
			{
				MessageBox.Show("Falta cargar fecha Hasta");
				txt_FechaHasta.Focus();
				return;
			}
			else
            {
				if (cmb_EstPeriodo.SelectedItem == null)
				{
					MessageBox.Show("Seleccione un tipo de gráfico");
					cmb_EstPeriodo.Focus();
					return;
				}

				if (cmb_EstPeriodo.SelectedItem.ToString() == "Gráfico de torta")
				{
					tablaEMP = empleado.Buscar_Periodo(ltxt_Desde2.Pp_Text, ltxt_Hasta2.Pp_Text);
					GenerarGraficoTorta();
				}
				if (cmb_EstPeriodo.SelectedItem.ToString() == "Gráfico de barras (vertical)")
				{
					tablaEMP = empleado.Buscar_Periodo(ltxt_Desde2.Pp_Text, ltxt_Hasta2.Pp_Text);
					GenerarGraficoBarrasVert();
				}

				if (cmb_EstPeriodo.SelectedItem.ToString() == "Gráfico de barras (horizontal)")
				{
					tablaEMP = empleado.Buscar_Periodo(ltxt_Desde2.Pp_Text, ltxt_Hasta2.Pp_Text);
					GenerarGraficoBarrasHor();
				}
			}
		}
    }
	
}
