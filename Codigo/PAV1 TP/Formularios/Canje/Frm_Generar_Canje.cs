using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Clases;
using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Canje
{
	public partial class Frm_Generar_Canje : Form
	{


		Be_BaseDeDatos _BD = new Be_BaseDeDatos();
		Ng_Canje canje = new Ng_Canje();

		public Frm_Generar_Canje()
		{
			InitializeComponent();
		}

		private void Frm_Generar_Canje_Load(object sender, EventArgs e)
		{
			cmb_id_catalogo.Cargar();
			cmb_cod_planta.Cargar();

		}

		private void canjear_Click(object sender, EventArgs e)
		{
			if (txt_nro_dni.Text.ToString() == "")
			{
				MessageBox.Show("No se ha cargado número de documento");
				txt_nro_dni.Focus();
			}
			else
			{
				if (cmb_cod_planta.SelectedIndex == -1)
				{
					MessageBox.Show("No se ha seleccionado una planta.");
					cmb_cod_planta.Focus();
				}
				else
				{
					DataTable tabla = new DataTable();
					tabla = canje.RecuperarCliente(txt_nro_dni.Text.ToString());
					string tipoDoc = "";
					tipoDoc = tabla.Rows[0][0].ToString();

					DataTable tabla2 = new DataTable();
					tabla2 = canje.RecuperarPuntosCliente(txt_nro_dni.Text.ToString());

					string cantPuntosCliente = "";
					cantPuntosCliente = tabla2.Rows[0][4].ToString();

					DataTable tabla3 = new DataTable();
					tabla3 = canje.RecuperarPuntosPlanta(cmb_cod_planta.SelectedIndex.ToString());
					string cantPuntosPlanta = "";
					cantPuntosPlanta = tabla3.Rows[0][0].ToString();

					if (tabla.Rows.Count > 0)
					{
						if (tabla2.Rows.Count > 0)
						{
							if (double.Parse(cantPuntosCliente) >= double.Parse(cantPuntosPlanta))
							{
								double puntos_restantes = double.Parse(cantPuntosCliente) - double.Parse(cantPuntosPlanta);
								canje.insertar(canje.NuevoId(), tipoDoc, txt_nro_dni.Text, cmb_id_catalogo.SelectedIndex.ToString(), cmb_cod_planta.SelectedIndex.ToString(), DateTime.Now.ToShortDateString(), puntos_restantes.ToString());
							
							}
						}
						else
						{
							MessageBox.Show("No tiene puntos para canjear.");
						}
					}
					else
					{
						MessageBox.Show("El cliente no está ingresado.");
					}
				}

			}
		}

		private void checkBoxList011_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
