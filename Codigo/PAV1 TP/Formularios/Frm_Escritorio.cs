﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Formularios.Catalogos;
using PAV1_TP.Formularios.Proveedor;
using PAV1_TP.Formularios.Plantas;
using PAV1_TP.Formularios;
using PAV1_TP.Negocios;
using PAV1_TP.Formularios.Empleados;
using PAV1_TP.Formularios.Producto;
using PAV1_TP.Formularios.Clientes;
using PAV1_TP.Formularios.Cargas;
using PAV1_TP.Formularios.Puntos;
using PAV1_TP.Formularios.Canje;
using PAV1_TP.Formularios.Reportes;
using PAV1_TP.Reportes.ReportesVentas;
using PAV1_TP.Reportes.ReportesEmpleados;
using PAV1_TP.Reportes.ReportesPlantas;
using PAV1_TP.Reportes.ReportesProdcutos;

namespace PAV1_TP
{
    public partial class Frm_Escritorio : Form
    {
        public string nombre_usuario { get; set; }
        public string password { get; set; }
        public int id_empleado { get; set; }
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Clientes = new ABM_Clientes();
            Clientes.Show();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            if (login.Usuario == "" || login.Password == "")
            {
                MessageBox.Show("Acceso bloqueado"
                    , "Importante"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else
            {
                Ng_Empleados Usuario = new Ng_Empleados();
                id_empleado = Usuario.Recuperar_id(login.Usuario, login.Password);
                if (id_empleado == 0)
                {
                    MessageBox.Show("Acceso bloqueado, usuario y password incorrecto"
                             , "Importante"
                             , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                else
                {
                    nombre_usuario = login.Usuario;
                    password = login.Password;
                    MessageBox.Show("Bienvenido! " + nombre_usuario);
                }
            }
            login.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Catalogo = new ABM_Catalogos();
            Catalogo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form Proveedor = new ABM_Proveedor();
            Proveedor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Planta = new ABM_Plantas();
            Planta.Show();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            Form Empleado = new ABM_Empleados();
            Empleado.Show();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Form Producto = new ABM_Productos();
            Producto.Show();
        }

        private void btn_GenerarFactura_Click(object sender, EventArgs e)
        {
            Form Factura = new Consulta_Factura();
            Factura.Show();
        }

        private void btn_Puntos_Click(object sender, EventArgs e)
        {
            Form Puntos = new ConsultaPuntos();
            Puntos.Show();
        }

        private void btn_Canjes_Click(object sender, EventArgs e)
        {
            Form canje = new Frm_Canje();
            canje.Show();
        }
        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ReporteVentas = new Frm_ReporteVentas();
            ReporteVentas.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ReporteClientes = new Frm_ReporteClientes();
            ReporteClientes.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ReporteEmpleados = new Frm_ReporteEmpleados();
            ReporteEmpleados.Show();
        }

        private void plantasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ReportesPlantas = new Frm_ReportesPlantas();
            ReportesPlantas.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ReportesProductos = new Frm_ReportesProductos();
            ReportesProductos.Show();
        }
    }
}
