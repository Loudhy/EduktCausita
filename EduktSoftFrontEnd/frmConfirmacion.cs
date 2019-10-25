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
    public partial class frmConfirmacion : Form
    {
        public frmConfirmacion(string correo)
        {
            InitializeComponent();
            lblCorreo.Text = correo;            
        }

        private void frmConfirmacion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            pnlConfirmar.Dock = DockStyle.Fill;
            lblCorreo.Visible = true;
            pbCheck.Visible = true;
        }
        

        private void pbCheck_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlConfirmar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
