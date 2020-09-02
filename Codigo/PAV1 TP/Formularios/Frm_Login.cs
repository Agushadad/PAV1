using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios
{
    public partial class Frm_Login : Form
    {
        public string Usuario { get; set; }
        public string Password
        {
            get { return txt_contraseña.Text; }
            set { txt_contraseña.Text = value; }
        }

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("No está cargado el usuario", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Focus();
                return;
            }
            if (this.txt_contraseña.Text == "")
            {
                MessageBox.Show("No está cargada la contraseña", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_contraseña.Focus();
                return;
            }
        }
            

            private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
