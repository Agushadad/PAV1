using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Negocios
{
    class Ng_Catalogo
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable Catalogos_Activos()
        {
            string sql = "SELECT * FROM Catalogo WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Catalogos_Inactivos()
        {
            string sql = "SELECT * FROM Catalogo WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Los_Catalogos()
        {
            string sql = "SELECT * FROM Catalogo WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Catalogo(string ID_cat, string Idplanta_cat)
        {
            string sql = "SELECT * FROM Catalogo WHERE ID LIKE '%" + ID_cat + "%' AND Id_Planta LIKE '%" + Idplanta_cat + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Empleado";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public string Insertar(Es_Catalogo datos)
        {

            string sqlInsert = @"INSERT INTO Catalogo(ID,Id_Planta, Puntos_Necesarios, Estado) VALUES (";
            sqlInsert += "'" + datos.ID + "'";
            sqlInsert += ",'" + datos.Id_Planta + "'";
            sqlInsert += ", '" + datos.Puntos_Necesarios + "'";
            sqlInsert += ", '" + datos.Estado + "'";

            return _BD.Insertar(sqlInsert);

        }
    }
}
