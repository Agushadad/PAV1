using System;
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
        private DataTable EstructuraTabla(string NombreTabla)
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
            DataTable tabla = new DataTable();
            tabla = this.Consulta(sql);
            return tabla;
        }
        private string BuscarValorCampo(string campo, string NombreTabla, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Pp_nombre_campo is null)
                        continue;

                    if (((TextBox01)item).Pp_nombre_tabla.IndexOf(NombreTabla) != -1
                        && ((TextBox01)item).Pp_nombre_campo == campo)
                    {
                        return ((TextBox01)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_nombre_campo is null)
                        continue;

                    if (((ComboBox01)item).Pp_nombre_tabla.IndexOf(NombreTabla) != -1
                        && (((ComboBox01)item).Pp_nombre_campo == campo))
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();
                    }
                }
            }
            return "";
        }
        public string FormatearDato(string dato, string formato)
        {
            switch (formato)
            {
                case "String":
                    return "'" + dato + "'";
                case "Date":
                case "DateTime":
                    return "convert(date,'" + dato + "', 103)";
                default:
                    return dato;
            }
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
        public string InsertarAutomatizado(string NombreTabla, Control.ControlCollection controles)
        {
            string sqlInsertar = "INSERT INTO " + NombreTabla.Trim() + " (";
            string sqldatos = " VALUES (";
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
                if (ValorCampo != "")
                {
                    sqlInsertar += ", " + Estructura.Columns[i].Caption;
                    sqldatos += ", " + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
                }
            }
            sqlInsertar = sqlInsertar + ")" + sqldatos + ")";
            sqlInsertar = sqlInsertar.Replace("(,", "(");
            MessageBox.Show(sqlInsertar);
            return Insertar(sqlInsertar);
        }
    }
}
