using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using PAV1_TP.Formularios;
using PAV1_TP.Formularios.Empleados;
using PAV1_TP.Formularios.Proveedor;
using PAV1_TP.Formularios.Catalogos;

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
            Application.Run(new Alta_Catalogos());
            







        }
    }
}
