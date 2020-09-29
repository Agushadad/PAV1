using PAV1_TP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Formularios.Puntos;
using System.Data;

namespace PAV1_TP.Negocios
{
    class Ng_Factura
    {

        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable RecuperarCliente(string dni)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'");
        }
        public DataTable RecuperarTipoDoc(string dni)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'");
        }

        public DataTable RecuperarEmp(string ID)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Empleado WHERE ID = " + ID);
        }

        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Factura";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id;
            return NuevaId.ToString();
        }
        public DataTable Buscar_Factura(string NroDoc)
        {
            string sql = "SELECT * FROM Factura WHERE NroDoc LIKE '%" + NroDoc + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Detalle_Factura(string NroFac)
        {
            string sql = "SELECT * FROM DetalleFactura WHERE Nro_Factura = " + NroFac;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Todas_Facturas()
        {
            string sql = "SELECT * FROM Factura WHERE Tipo_Factura > 0";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        // metodo para cargar la transaccion
        public void insertar(string Tipo_Factura, string Nro_Factura, string TipoDoc, string NroDoc,
                             string fecha, string Id_Empleado, string monto, Grid01 plantas, Grid01 productos)
        {
            _BD.IniciarTransaccion();

            string insert_factura = "INSERT INTO Factura (Tipo_Factura, Nro_Factura, TipoDoc, NroDoc, fecha, Id_Empleado,monto) VALUES (";
            insert_factura += Tipo_Factura + ", " + Nro_Factura + ", " + TipoDoc + ", " + NroDoc + ", "
                            + _BD.FormatearDato(fecha, "DateTime") + ", " + Id_Empleado + ", " + monto + ")";
            _BD.Insertar(insert_factura);

            string insert_Detalle_factura = "INSERT INTO DetalleFactura (Tipo_Factura, Nro_Factura, Id_Planta," +
                " Id_Producto, Cantidad, Precio ) VALUES (";

            for (int i = 0; i < plantas.Rows.Count; i++)
            {
                string datos_plantas = Tipo_Factura + ", " + Nro_Factura;
                datos_plantas += ", " + plantas.Rows[i].Cells[0].Value.ToString();
                datos_plantas += ", " + 0;
                datos_plantas += ", " + plantas.Rows[i].Cells[2].Value.ToString();
                datos_plantas += ", " + plantas.Rows[i].Cells[3].Value.ToString() + ")";

                string insert_final = insert_Detalle_factura + datos_plantas;
                _BD.Insertar(insert_final);
            }
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                string datos_productos = Tipo_Factura + ", " + Nro_Factura;
                datos_productos += ", " + 0;
                datos_productos += ", " + productos.Rows[i].Cells[0].Value.ToString();
                datos_productos += ", " + productos.Rows[i].Cells[2].Value.ToString();
                datos_productos += ", " + productos.Rows[i].Cells[3].Value.ToString() + ")";

                string insert_final = insert_Detalle_factura + datos_productos;
                _BD.Insertar(insert_final);
            }
            if (_BD.CerrarTransaccion() == Be_BaseDeDatos.EstadoTransaccion.correcta)
            {
                MessageBox.Show("La factura se generó correctamente");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }
        }
    }
}
