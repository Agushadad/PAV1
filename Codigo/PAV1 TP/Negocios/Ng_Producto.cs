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
    class Ng_Producto
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable Productos_Activos()
        {
            string sql = "SELECT * FROM Producto WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Productos_Inactivos()
        {
            string sql = "SELECT * FROM Producto WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Los_Productos()
        {
            string sql = "SELECT * FROM Producto WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Producto(string Cod_prod, string nom_prod, string tipo_prod)
        {
            string sql = "SELECT * FROM Producto WHERE Codigo LIKE '%" + Cod_prod + "%' AND Nombre LIKE '%" + nom_prod + "%' AND Tipo LIKE '%" + tipo_prod + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public int Recuperar_id(string Prod)
        {

            string sql = "SELECT * FROM Producto WHERE Nombre = '" + Prod + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(tabla.Rows[0]["Codigo"].ToString());
            }
        }

        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Producto";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public string Insertar(Es_Producto datos)
        {

            string sqlInsert = @"INSERT INTO Producto(Codigo, Nombre, Tipo, Stock, Costo, Precio
                                 , Composicion, Estado) VALUES (";
            sqlInsert += "'" + datos.Codigo + "'";
            sqlInsert += ",'" + datos.Nombre + "'";
            sqlInsert += ", '" + datos.Tipo + "'";
            sqlInsert += ", '" + datos.Stock + "'";
            sqlInsert += ", '" + datos.Costo + "'";
            sqlInsert += ", '" + datos.Precio + "'";
            sqlInsert += ", '" + datos.Composicion + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public string InsertarCompuesto(Es_ProcutoCompuesto datos)
        {

            string sqlInsert = @"INSERT INTO Composicion(Cod_Prod_Compuesto, Cod_Prod_Componente, Cant_Compuesto, Cant_Componente) VALUES (";
            sqlInsert += "'" + datos.Cod_Prod_Compuesto + "'";
            sqlInsert += ",'" + datos.Cod_Prod_Componente + "'";
            sqlInsert += ", '" + datos.Cant_Compuesto + "'";
            sqlInsert += ", '" + datos.Cant_Componente + "')";

            return _BD.Insertar(sqlInsert);

        }

        public DataTable RecuperarProducto(string ID)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Producto WHERE Codigo = " + ID);

        }

        public DataTable RecuperarTipoProducto(string ID)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM TipoProducto WHERE ID = " + ID);

        }

    }
}
