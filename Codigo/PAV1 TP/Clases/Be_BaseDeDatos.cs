﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PAV1_TP.Clases
{
    class Be_BaseDeDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        String Cadena_conexion = "Data Source=DESKTOP-7MV1FIL;Initial Catalog=Vivero;Integrated Security=True";

        private void Conectar()
        {
            //Acuerdense de cambiar el link de conexion y poner el de c/uno
            Conexion.ConnectionString = Cadena_conexion;
            Conexion.Open();

            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }
        
        private void Desconectar()
        {
            Conexion.Close();
        }

        public DataTable Consulta (string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public string Insertar(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            Cmd.CommandText = "SELECT @@Identity";
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla.Rows[0][0].ToString();
        }
    }
}
