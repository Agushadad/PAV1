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
using Microsoft.Reporting.WinForms;

namespace PAV1_TP.Reportes.ReportesPlantas
{
    public partial class Frm_ReportesPlantas : Form
    {
        Ng_Factura factura = new Ng_Factura();
        Ng_Planta planta = new Ng_Planta();
        DataTable TablaPlantas = new DataTable();
        string restriccion = "";
        public Frm_ReportesPlantas()
        {
            InitializeComponent();
        }

        private void Frm_ReportesPlantas_Load(object sender, EventArgs e)
        {

            //this.Rv_Plantas.RefreshReport();
        }
        private void BuscarPlantas()
        {
            TablaPlantas = planta.Plantas_Activas();
            return;
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaPlantas);
            Rv_Plantas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesPlantas.InformePlantas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Plantas.LocalReport.DataSources.Clear();
            Rv_Plantas.LocalReport.DataSources.Add(Datos);
            Rv_Plantas.RefreshReport();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarPlantas();
            ArmarReporte();
        }

        //***********************************************************Reportes Facu**************************************************************

        //REPORTE DE PLANTAS POR MES

        DataTable tablaPPM = new DataTable();
        int TotalPlantas = 0;
        private void BuscarPPM()
        {
            if (txt_MesPPM.Text != "")
            {
                if (int.Parse(txt_MesPPM.Text) > 12 | int.Parse(txt_MesPPM.Text) == 0)
                {
                    MessageBox.Show("Ingrese un mes correcto");
                    txt_MesPPM.Focus();

                }
                else
                {
                    tablaPPM = factura.ReportePPM(txt_MesPPM.Text);
                    if (tablaPPM.Rows.Count == 0)
                    {
                        MessageBox.Show("No hubo ventas en el mes ingresado", "ATENCIÓN");
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingresar Mes", "ATENCIÓN");
                txt_MesPPM.Focus();
            }
        }

        private void CalcularPPM()
        {

            for (int i = 0; i < tablaPPM.Rows.Count; i++)
            {
                TotalPlantas += int.Parse(tablaPPM.Rows[i][1].ToString());
            }

        }
        private void ArmarReportePPM()
        {

            ReportDataSource Datos = new ReportDataSource("DataSetPPM", tablaPPM);
            Rv_PPM.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesPlantas.InformePPM.rdlc";
            ReportParameter[] parametros1 = new ReportParameter[1];
            parametros1[0] = new ReportParameter("RP01", "Mes: " + txt_MesPPM.Text);
            ReportParameter[] parametros2 = new ReportParameter[1];
            parametros2[0] = new ReportParameter("RP02", "Total de plantas vendidas: " + TotalPlantas.ToString());
            Rv_PPM.LocalReport.SetParameters(parametros1);
            Rv_PPM.LocalReport.SetParameters(parametros2);
            Rv_PPM.LocalReport.DataSources.Clear();
            Rv_PPM.LocalReport.DataSources.Add(Datos);
            Rv_PPM.RefreshReport();
        }

        private void btn_PPM_Click(object sender, EventArgs e)
        {
            BuscarPPM();
            if (tablaPPM.Rows.Count > 0)
            {
                CalcularPPM();
                ArmarReportePPM();
                TotalPlantas = 0;
            }
        }

        //REPORTE TIPO PLANTA POR MES

        DataTable tablaTPPM = new DataTable();

        private void BuscarTPPM()
        {
            if (txt_MesTPPM.Text != "")
            {
                if (int.Parse(txt_MesTPPM.Text) > 12 | int.Parse(txt_MesTPPM.Text) == 0)
                {
                    MessageBox.Show("Ingrese un mes correcto");
                    txt_MesTPPM.Focus();
                    return;
                }
                else
                {
                    tablaTPPM = factura.ReporteTPPM(txt_MesTPPM.Text);
                    if (tablaTPPM.Rows.Count == 0)
                    {
                        MessageBox.Show("No hubo ventas en el mes ingresado", "ATENCIÓN");
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingresar Mes", "ATENCIÓN");
                txt_MesTPPM.Focus();
            }
        }

        private void ArmarReporteTPPM()
        {
            ReportDataSource DatosTPPM = new ReportDataSource("DataSetTPPM", tablaTPPM);
            Rv_TPPM.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesPlantas.InformeTPPM.rdlc";
            ReportParameter[] parametrostppm = new ReportParameter[1];
            parametrostppm[0] = new ReportParameter("RPM", "Mes: " + txt_MesTPPM.Text);
            Rv_TPPM.LocalReport.SetParameters(parametrostppm);
            Rv_TPPM.LocalReport.DataSources.Clear();
            Rv_TPPM.LocalReport.DataSources.Add(DatosTPPM);
            Rv_TPPM.RefreshReport();
        }

        private void btn_TPPM_Click(object sender, EventArgs e)
        {
            BuscarTPPM();
            if (tablaTPPM.Rows.Count > 0)
            {
                ArmarReporteTPPM();
            }
        }
    }
}
