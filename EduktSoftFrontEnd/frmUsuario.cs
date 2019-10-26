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
        int aux = 0;
        Service.ServicioClient jajajajaj = new Service.ServicioClient();
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
            pbOjo.Image = Properties.Resources.ojitoSinRaya;
            pbOjo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOjo.BackColor = Color.Transparent;
            lblErrorInicioSesion.BackColor = Color.Transparent;
            txtNombreUsuario.Text = "Ingrese su nombre de usuario o DNI";
            txtNombreUsuario.ForeColor = Color.LightGray;
            txtContrasena.Text = "Ingrese su contraseña";
            txtContrasena.ForeColor = Color.LightGray;
            txtNombreUsuario.Select(txtNombreUsuario.TextLength, 0);
            txtContrasena.Select(txtContrasena.TextLength, 0);
            bordesRedondeados.BorderRedondoButton(btnIngresar);
            lblErrorInicioSesion.Visible = false;
        }

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Ingrese su nombre de usuario o DNI")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.Black;
            }
        }

        private void txtNombreUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                txtContrasena.UseSystemPasswordChar = true;
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "Ingrese su contraseña")
            {
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        private void btnIngresar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        private void pbOjo_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                pbOjo.Image = Properties.Resources.ojitoConRaya;
                txtContrasena.UseSystemPasswordChar = false;
                aux = 1;
            }
            else
            {
                pbOjo.Image = Properties.Resources.ojitoSinRaya;
                txtContrasena.UseSystemPasswordChar = true;
                aux = 0;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int aux=jajajajaj.validarLogin(txtNombreUsuario.Text, txtContrasena.Text);
            if (aux==0)
            {
                MessageBox.Show("MAAAAAAAL");
            }
            else
            {
                MessageBox.Show("BIEEEEEEEEEN");            }
        }
    }
}
