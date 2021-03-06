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

namespace PAV1_TP.Formularios.Reportes
{
    public partial class Frm_ReporteClientes : Form
    {
        Ng_Cliente cliente = new Ng_Cliente();
        DataTable TablaCliente = new DataTable();
        string restriccion = "";
        public Frm_ReporteClientes()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ReporteClientes_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void BuscarClientes()
        {
            
            if (chk_TodosClientes.Checked == false  & txt_NombreCliente.Text == "")
            {
                MessageBox.Show("No se seleccionó ningún criterio de búsqueda");
                return;
            }
            if (chk_TodosClientes.Checked == true)
            {
                TablaCliente = cliente.BuscarCliente(true,"","","");
                restriccion += "sin restricción";
                return;
            }
            else
            {
                if (txt_NombreCliente.Text != "")
                {
                    TablaCliente = cliente.BuscarCliente(false,txt_NombreCliente.Text,"","");
                    restriccion += "Nombre";
                    return;
                }

                
            }
        }
        private void ArmarReporteCliente()
        {
            
            
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaCliente);
            Rv_Clientes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeCliente.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            if (chk_TodosClientes.Checked == true)
            {
                parametros[0] = new ReportParameter("RP01", "Sin restriccion");
            }
            else
            {
                parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            }
            
            Rv_Clientes.LocalReport.SetParameters(parametros);
            Rv_Clientes.LocalReport.DataSources.Clear();
            Rv_Clientes.LocalReport.DataSources.Add(Datos);
            Rv_Clientes.RefreshReport();
            

        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
            BuscarClientes();
            ArmarReporteCliente();
            restriccion = "";

            
        }
        private void BuscarCliente()
        {
            TablaCliente = cliente.ClientesActivos();
            return;
        }
        private void BuscarMayorCompraClientes()
        {
            TablaCliente = cliente.ReporteCMV();
            return;
        }
        private void ArmarReporteCMV()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaCliente);
            Rv_ClienMC.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeMayorCompraCliente.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_ClienMC.LocalReport.DataSources.Clear();
            Rv_ClienMC.LocalReport.DataSources.Add(Datos);
            Rv_ClienMC.RefreshReport();
        }


        private void btn_BuscarCliente_Click_1(object sender, EventArgs e)
        {
            BuscarMayorCompraClientes();
            ArmarReporteCMV();
        }
        private void ArmarReportesCanjeCliente()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaCliente);
            rv_CanjeCliente.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.Informe_CanjeCliente.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            rv_CanjeCliente.LocalReport.DataSources.Clear();
            rv_CanjeCliente.LocalReport.DataSources.Add(Datos);
            rv_CanjeCliente.RefreshReport();
        }
        private void BuscarMayorCanje()
        {
            TablaCliente = cliente.BuscarMayorCanje(txt_Mes.Text);
            return;
        }

        private void btn_BuscarCanje_Click_1(object sender, EventArgs e)
        {
            if (txt_Mes.Text == "")
            {
                MessageBox.Show("No se especifico el mes");
            }
            else
            {
                BuscarMayorCanje();
                ArmarReportesCanjeCliente();

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void GenerarGraficoBarrasVert()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            ReportDataSource datos = new ReportDataSource("MayorCompraCliente", TablaCliente);
            RV_MayCompCliente.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.Est_MayorCompraPorCliente2.rdlc";
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
            parametro[1] = new ReportParameter("RP02", "Análisis Estadístico de mayor compra por cliente");
            RV_MayCompCliente.LocalReport.SetParameters(parametro);
            RV_MayCompCliente.LocalReport.DataSources.Clear();
            RV_MayCompCliente.LocalReport.DataSources.Add(datos);
            RV_MayCompCliente.RefreshReport();
        }

        private void GenerarGraficoBarrasHor()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            ReportDataSource datos = new ReportDataSource("MayorCompraCliente", TablaCliente);
            RV_MayCompCliente.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.Est_MayorCompraPorCliente3.rdlc";
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
            parametro[1] = new ReportParameter("RP02", "Análisis Estadístico de mayor compra por cliente");
            RV_MayCompCliente.LocalReport.SetParameters(parametro);
            RV_MayCompCliente.LocalReport.DataSources.Clear();
            RV_MayCompCliente.LocalReport.DataSources.Add(datos);
            RV_MayCompCliente.RefreshReport();
        }

        private void GenerarGraficoTorta()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            ReportDataSource datos = new ReportDataSource("MayorCompraCliente", TablaCliente);
            RV_MayCompCliente.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.Est_MayorCompraPorCliente.rdlc";
            ReportParameter[] parametro = new ReportParameter[2];
            parametro[0] = new ReportParameter("RP01", _BD.FechaHora());
            parametro[1] = new ReportParameter("RP02", "Análisis Estadístico de mayor compra por cliente");
            RV_MayCompCliente.LocalReport.SetParameters(parametro);
            RV_MayCompCliente.LocalReport.DataSources.Clear();
            RV_MayCompCliente.LocalReport.DataSources.Add(datos);
            RV_MayCompCliente.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_EstaMcompra.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de gráfico");
                cmb_EstaMcompra.Focus();
                return;
            }

            if (cmb_EstaMcompra.SelectedItem.ToString() == "Gráfico de torta")
            {
                TablaCliente = cliente.ReporteCMV();
                GenerarGraficoTorta();
            }
            if (cmb_EstaMcompra.SelectedItem.ToString() == "Gráfico de barras (vertical)")
            {
                TablaCliente = cliente.ReporteCMV();
                GenerarGraficoBarrasVert();
            }

            if (cmb_EstaMcompra.SelectedItem.ToString() == "Gráfico de barras (horizontal)")
            {
                TablaCliente = cliente.ReporteCMV();
                GenerarGraficoBarrasHor();
            }
        }
    }
}
