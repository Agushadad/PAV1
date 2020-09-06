using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PAV1_TP.Clases
{
    class Be_BaseDeDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();

        private void Conectar()
        {
            //Acuerdense de cambiar el link de conexion y poner el de c/uno
            Conexion.ConnectionString = "Data Source=LAPTOP-C87F44FH\\MSSQLSERVER01;Integrated Security=SSPI;Initial Catalog=Vivero";
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
            return tabla;
        }
    }
}
