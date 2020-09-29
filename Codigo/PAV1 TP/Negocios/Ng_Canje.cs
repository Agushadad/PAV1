using PAV1_TP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PAV1_TP.Negocios
{
	class Ng_Canje
	{

		Be_BaseDeDatos _BD = new Be_BaseDeDatos(); 
		public DataTable RecuperarCliente(string dni)
		{
			DataTable tabla = new DataTable();
			return tabla = _BD.Consulta("SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'");

		}

		public DataTable RecuperarPuntosCliente(string dni)
		{
			DataTable tabla = new DataTable();
			return tabla = _BD.Consulta("SELECT * FROM Puntos WHERE NroDoc = '" + dni + "'");

		}

		public DataTable RecuperarPuntosPlanta(string Id_Planta)
		{
			DataTable tabla = new DataTable();
			return tabla = _BD.Consulta("SELECT C.Puntos_Necesarios FROM Catalogo C WHERE Id_Planta = '" + Id_Planta + "'");
		}

		public string NuevoId()
		{
			DataTable tabla = new DataTable();
			string sql = "SELECT * FROM Canje";
			tabla = _BD.Consulta(sql);
			int id = tabla.Rows.Count;
			int NuevaId = id + 1;
			return NuevaId.ToString();
		}

		public void insertar(string ID, string TipoDoc, string NroDoc, string Id_Catalogo,
							string Id_Planta, string Fecha, string Puntos_a_Restar)
		{
			_BD.IniciarTransaccion();

			string canjear_puntos = "INSERT INTO Canje (ID, TipoDoc, NroDoc, Id_Catalogo, Id_Planta, Fecha, Puntos_a_Restar) VALUES (";
			canjear_puntos += ID + ", " + TipoDoc + ", " + NroDoc + ", " + Id_Catalogo + ", " + Id_Planta + " , "
							+ _BD.FormatearDato(Fecha, "DateTime") + ", " + Puntos_a_Restar + ")";
			_BD.Insertar(canjear_puntos);

			if (_BD.CerrarTransaccion() == Be_BaseDeDatos.EstadoTransaccion.correcta)
			{
				MessageBox.Show("Se canjearon los puntos correctamente");
			}
			else
			{
				MessageBox.Show("No fue posible realizar el canje");
			}

		}
	}
}