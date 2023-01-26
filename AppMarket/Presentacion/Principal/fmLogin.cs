using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Principal
{
    public partial class fmLogin : Form
    {
        private void AbrirVentana()
        {
            //  --- abrir venta index
            fmIndex fmIndex = new fmIndex();
            fmIndex.ShowDialog();
            //  --- cerrar ventana login
            this.Close();
            this.Dispose();
        }
        private void ValidarUsuario()
        {
            string Usuario = tbUsuario.Text;
            string Password = tbPassword.Text;

        }
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
            AbrirVentana();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
