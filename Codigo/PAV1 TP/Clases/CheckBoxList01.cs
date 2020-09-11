using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Clases
{
    class CheckBoxList01 : CheckedListBox
    {
        public string Pp_Tabla { get; set; }
        public string Pp_Display { get; set; }
        public string Pp_Value { get; set; }
        public bool Pp_seleccionado { get; set; }

        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }
        public void Cargar()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            string sql = "SELECT * FROM " + Pp_Tabla;
            Items.Add(Pp_Display);
            this.DataSource = _BD.Consulta(sql);
        }
    }
}
