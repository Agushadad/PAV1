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
    class Ng_Planta
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();

        public DataTable Plantas_Activas()
        {
            string sql = "SELECT * FROM Plantas WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Plantas_Inactivas()
        {
            string sql = "SELECT * FROM Plantas WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todas_las_Plantas()
        {
            string sql = "SELECT * FROM Plantas";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Recuperar_Planta(string Codigo)
        {
            return _BD.Consulta("SELECT * FROM Planta WHERE Codigo = " + Codigo);
        }
        public DataTable Buscar_Planta(int Codigo, string NombreComun)
        {
            string sql = "SELECT * FROM Planta WHERE Codigo LIKE '%" + Codigo + "%' AND Nombre Comun LIKE '%" + NombreComun + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string Insertar(Es_Planta datos)
        {

            string sqlInsert = @"INSERT INTO Plantas(Codigo, NombreCientifico, NombreComun, Tipo, Precio, Stock) VALUES (";
            sqlInsert += "'" + datos.Codigo + "'";
            sqlInsert += ",'" + datos.NombreCientifico + "'";
            sqlInsert += ", '" + datos.NombreComun + "'";
            sqlInsert += ", '" + datos.Tipo + "'";
            sqlInsert += ", '" + datos.Precio + "'";
            sqlInsert += ", '" + datos.Stock + "')";

            return _BD.Insertar(sqlInsert);

        }
        public void Modificar(Es_Planta datos)
        {
            string sqlUpdate = "UPDATE Catalogo SET ";
            sqlUpdate += ", Nombre Cientifico = " + _BD.FormatearDato(datos.NombreCientifico, "String");
            sqlUpdate += ", Nombre Comun = " + _BD.FormatearDato(datos.NombreComun, "String");
            sqlUpdate += ", Tipo = " + _BD.FormatearDato(datos.Tipo, "String");
            sqlUpdate += ", Precio = " + _BD.FormatearDato(datos.Precio.ToString(), "String");
            sqlUpdate += ", Stock = " + _BD.FormatearDato(datos.Stock.ToString(), "String");



            _BD.Modificar(sqlUpdate);
        }
        public void Eliminar(int Codigo, string NombreComun)
        {
            string sqlEliminar = "UPDATE Planta SET Estado = 2 WHERE Codigo = " + Codigo + "AND NombreComun = " + NombreComun;
            _BD.Modificar(sqlEliminar);

        }
    }
}
