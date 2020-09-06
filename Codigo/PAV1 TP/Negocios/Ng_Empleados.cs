using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_TP.Clases;
using System.Data;

namespace PAV1_TP.Negocios
{
    class Ng_Empleados
    {
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public Respuesta Validar_usuario(string usr, string pssw)
        {
            string sql = "";
            sql = "SELECT * FROM Empleado WHERE Nombre = '" + usr + "' AND Contraseña = '" + pssw + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return Respuesta.validacion_incorrecta;
            }
            else
            {
                return Respuesta.validacion_correcta;
            }

        }
        public int Recuperar_id(string usr, string pssw)
        {
            string sql = "";
            sql = "SELECT * FROM Empleado WHERE Nombre = '" + usr + "' AND Contraseña= '" + pssw + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(tabla.Rows[0]["ID"].ToString());
            }
        }

        public DataTable Todos_Los_Empleados()
        {
            string sql = "SELECT * FROM Empleado";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
    }
}
