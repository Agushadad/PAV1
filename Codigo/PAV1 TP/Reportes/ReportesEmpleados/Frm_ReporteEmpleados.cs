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
using Microsoft.Reporting.WinForms;

namespace PAV1_TP.Reportes.ReportesEmpleados
{
    public partial class Frm_ReporteEmpleados : Form
    {
        Ng_Empleados empleado = new Ng_Empleados();
        DataTable TablaEmpleados = new DataTable();
		DataTable tablaEMP = new DataTable();
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

        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarEmpleado();
            ArmarReporte();
        }

		//********************************************************************************************************************************************************************

		private void BuscarVentasPorEmpleado()
		{
			

			if (txt_Mes.Text == "" && check_MayorV.Checked == false && check_MenorV.Checked == false)
			{
				MessageBox.Show("No se realizó selección para la búsqueda");
				return;
			}
			if (txt_Mes.Text == "" && (check_MayorV.Checked == true || check_MenorV.Checked == true))
			{
				MessageBox.Show("Ingrese un mes");
				return;
			}
			if (txt_Mes.Text != "" && (check_MayorV.Checked == false && check_MenorV.Checked == false))
			{
				MessageBox.Show("Seleccione si desea conocer el empleado con menor y/o mayor venta");
				return;
			}
			if (txt_Mes.Text != "" && check_MayorV.Checked == true && check_MenorV.Checked == true)
			{
				//	TablaEmpleados = empleado.Buscar_Empleado_Mayor_Ventas(txt_Mes.Text);
				//	return;
				//}
				if (txt_Mes.Text != "" && check_MayorV.Checked == true && check_MenorV.Checked == false)
				{
					tablaEMP = empleado.Buscar_Empleado_Mayor_Ventas(txt_Mes.Text);
					return;
				}
				if (txt_Mes.Text != "" && check_MayorV.Checked == false && check_MenorV.Checked == true)
				{
					tablaEMP = empleado.Buscar_Empleado_Menor_Ventas(txt_Mes.Text);
					return;
				}
			}
		}

		private void ArmarReporteVentaPorEmp()
		{
			ReportDataSource Datos = new ReportDataSource("DataSet1", tablaEMP);
			Rv_VentasPorEmp.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleadoMasVentas.rdlc";
			ReportParameter[] parametros = new ReportParameter[1];
			parametros[0] = new ReportParameter("RP08", "Restringido por " + restriccion);
			Rv_VentasPorEmp.LocalReport.DataSources.Clear();
			Rv_VentasPorEmp.LocalReport.DataSources.Add(Datos);
			Rv_VentasPorEmp.RefreshReport();
		}


		private void btnBuscar_Click(object sender, EventArgs e)
		{
			BuscarVentasPorEmpleado();
			ArmarReporteVentaPorEmp();
		}

	}
	
}
