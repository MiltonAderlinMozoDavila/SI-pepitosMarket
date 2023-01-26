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
    public partial class fmIndex : Form
    {
        public fmIndex()
        {
            InitializeComponent();
        }

        //  --- funcion para mostrar y ocultar barra menu vertical
        private void imgIconMenu_Click(object sender, EventArgs e)
        {
            if(paMenuVertical.Width == 60)
            {
                paMenuVertical.Width = 250;
                
            }
            else
            {
                paMenuVertical.Width = 60;
            }
        }

        private void ImgIconClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            AbrirLogin();
        }
        //  --- abrir login
        private void AbrirLogin()
        {
            fmLogin Login = new fmLogin();
            Login.ShowDialog();
        }
        //  --- funcion para abrir un formulario dentro de otro

        private void AbrirFormInPanel(object pFormHijo)
        {
            if(this.paMain.Controls.Count > 0)
            {
                this.paMain.Controls.RemoveAt(0);
            }

            Form fmHijo = pFormHijo as Form;
            fmHijo.TopLevel = false;
            fmHijo.Dock = DockStyle.Fill;
            this.paMain.Controls.Add(fmHijo);
            this.paMain.Tag = fmHijo;
            fmHijo.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new fmClientes());
          

        }

        private void paHeaderCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            fmVentas Venta = new fmVentas();
            Venta.Show();
        }
    }
}
