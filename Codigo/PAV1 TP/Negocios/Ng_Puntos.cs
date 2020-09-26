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
    class Ng_Puntos
    {

        Be_BaseDeDatos _BD = new Be_BaseDeDatos();

        public string Insertar(Es_Puntos datos)
        {

            string sqlInsert = @"INSERT INTO Puntos(TipoDoc, NroDoc, Tipo_Factura, Nro_Factura, Cantidad, Fecha) VALUES (";
            sqlInsert += "'" + datos.Tpo_DNI + "'";
            sqlInsert += ",'" + datos.Nro_DNI + "'";
            sqlInsert += ", '" + datos.Tpo_Fact + "'";
            sqlInsert += ", '" + datos.Nro_Fact + "'";
            sqlInsert += ", '" + datos.Cant_Ptos + "'";
            sqlInsert += ", '" + datos.Fecha + "')";

            return _BD.Insertar(sqlInsert);

        }

        public DataTable Recuperar_DNI(string Nro_DNI)
        {
            return _BD.Consulta("SELECT * FROM Cliente WHERE NroDoc = " + Nro_DNI);
        }
        public DataTable Recuperar_Factura(string Nro_Fact)
        {
            return _BD.Consulta("SELECT * FROM Factura WHERE Nro_Factura = " + Nro_Fact);
        }
    }