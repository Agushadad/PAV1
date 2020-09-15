﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV1_TP.Negocios;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Negocios
{
	class Ng_Cliente
	{

		Be_BaseDeDatos _BD = new Be_BaseDeDatos();

		//public DataTable ClientesActivos()
		//{
		//	string sql = "SELECT * FROM Cliente WHERE Estado = 1";
		//	DataTable tabla = new DataTable();
		//	tabla = _BD.Consulta(sql);
		//	return tabla;
		//}

		public DataTable ClientesInactivos()
		{
			string sql = "SELECT * FROM Cliente WHERE Estado = 2";
			DataTable tabla = new DataTable();
			tabla = _BD.Consulta(sql);
			return tabla;
		}

		public DataTable TodosLosClientes()
		{
			string sql = "SELECT * FROM Cliente WHERE Estado = 1 or Estado = 2";
			DataTable tabla = new DataTable();
			tabla = _BD.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarDNI(string DNI)
		{
			string sql = "SELECT * FROM Cliente WHERE NroDoc = '" + DNI + "'";
			DataTable tabla = new DataTable();
			tabla = _BD.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarNombre(string Nombre)
		{
			string sql = "SELECT * FROM Cliente WHERE Nombre = '" + Nombre + "'";
			DataTable tabla = new DataTable();
			tabla = _BD.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarApellido(string Apellido)
		{
			string sql = "SELECT * FROM Cliente WHERE Apellido = '" + Apellido + "'";
			DataTable tabla = new DataTable();
			tabla = _BD.Consulta(sql);
			return tabla;
		}

		public DataTable BuscarClienteConTodosLosDatos(string DNI, string Nombre, string Apellido)
		{
			string sql = "SELECT * FROM Cliente WHERE NroDoc LIKE '%" + DNI + "%' AND Nombre LIKE '%" + Nombre + "%' AND Apellido LIKE '%" + Apellido + "%'";

			DataTable tabla = new DataTable();
			tabla = _BD.Consulta(sql);
			return tabla;
		}

		public string Insertar(Es_Cliente datos)
		{

			string sqlInsert = @"INSERT INTO Cliente(TipoDoc, NroDoc, Nombre, Apellido, Calle, NroCalle, Barrio
                                , Localidad, Telefono, Email, Estado) VALUES (";
			sqlInsert += " '" + datos.TipoDoc + "'";
            sqlInsert += ", '" + datos.NroDoc + "'";
			sqlInsert += ", '" + datos.Nombre + "'"; 
			sqlInsert += ", '" + datos.Apellido + "'";
			sqlInsert += ", '" + datos.Calle + "'";
			sqlInsert += ", '" + datos.NroCalle + "'";
			sqlInsert += ", '" + datos.Barrio + "'";
			sqlInsert += ", '" + datos.Localidad + "'";
			sqlInsert += ", '" + datos.Telefono + "'";
			sqlInsert += ", '" + datos.Email + "'";
			sqlInsert += ", '" + datos.Estado + "')";

			return _BD.Insertar(sqlInsert);
		}

		public void Modificar(Es_Cliente datos)
		{
			string sqlUpdate = "UPDATE Cliente SET ";
			sqlUpdate += "TipoDoc = " + _BD.FormatearDato(datos.TipoDoc, "String");
			sqlUpdate += ", NroDoc = " + _BD.FormatearDato(datos.NroDoc, "String");
			sqlUpdate += ", Nombre = " + _BD.FormatearDato(datos.Nombre, "String");
			sqlUpdate += ", Apellido = " + _BD.FormatearDato(datos.Apellido, "String");
			sqlUpdate += ", Calle = " + _BD.FormatearDato(datos.Calle, "String");
			sqlUpdate += ", NroCalle = " + _BD.FormatearDato(datos.NroCalle, "String");
			sqlUpdate += ", Barrio = " + _BD.FormatearDato(datos.Barrio, "String");
			sqlUpdate += ", Localidad = " + _BD.FormatearDato(datos.Localidad, "String");
			sqlUpdate += ", Telefono = " + _BD.FormatearDato(datos.Telefono, "String");
			sqlUpdate += ", Email = " + _BD.FormatearDato(datos.Email, "String");
			sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
			sqlUpdate += " WHERE NroDoc = " + datos.NroDoc;

			_BD.Modificar(sqlUpdate);
		}

        public DataTable RecuperarTipoDoc(string nombre)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM TipoDoc WHERE Descripcion = '" + nombre + "'");
        }

       
		public void Eliminar(string DNI)
		{
			string sqlEliminar = "UPDATE Cliente SET Estado = 2 WHERE NroDoc = " + DNI;
			_BD.Modificar(sqlEliminar);

		}
	}
}