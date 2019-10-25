using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EduktSoftFrontEnd
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = Properties.Resources.mounstrito1;
            this.MaximizeBox = false;
            lblErrorInicioSesion.BackColor = Color.Transparent;
            txtNombreUsuario.Text = "Ingrese su nombre de usuario";
            txtNombreUsuario.ForeColor = Color.LightGray;
            txtContrasena.Text = "Ingrese su contraseña";
            txtContrasena.ForeColor = Color.LightGray;
            bordesRedondeados.BorderRedondoButton(btnIngresar);
            lblErrorInicioSesion.Visible = false;
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
