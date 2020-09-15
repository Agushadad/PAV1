﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Formularios;
using PAV1_TP.Formularios.Empleados;
using PAV1_TP.Formularios.Proveedor;
using PAV1_TP.Formularios.Catalogos;
using PAV1_TP.Formularios.Producto;
using PAV1_TP.Formularios.Plantas;
using PAV1_TP.Formularios.Plantas.TipoPlanta;
using PAV1_TP.Formularios.Clientes;
using PAV1_TP.Formularios.Producto.TipoProducto;

namespace PAV1_TP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Escritorio());
            Application.Run(new Frm_Escritorio());








        }
    }
}
