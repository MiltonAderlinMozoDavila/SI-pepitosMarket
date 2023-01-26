using Entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Principal
{
    public partial class fmAgregarCliente : Form
    {
        public fmAgregarCliente()
        {
            InitializeComponent();
            cCliente Cliente = new cCliente(); 
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }
        //  --- genrar codigo cliente
        private string GetCodigo()
        {
            return "C001";
        }
        //  --- click al boton guardad
        private void guardarDatos(string pDNI, string pAP, string pAM, string pNombres, string pSexo, string pCodCliente, string pEstado)
        {
            //  --- instanciar una objeto cliente
            cCliente Cliente = new cCliente("C001", pDNI, pAP, pAM, pNombres, pSexo, pEstado);
            string Mensaje = "C001 " + " " +pDNI + " " + pAP + " " + pAM + " " + pNombres + " " + pSexo + " " + pEstado;
            labelMensaje.ForeColor = Color.Red;
            labelMensaje.Text = Mensaje;
            this.Close();

        }
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string DNI, AP, AM, Nombres, Sexo, CodCliente, Estado;
            //  --- get text of form
            DNI = textBoxDNI.Text;
            AP = textBoxAP.Text;    
            AM = textBoxAM.Text;
            Nombres = textBoxNombres.Text;
            Sexo = comboBoxSexo.Text;
            Estado = "Activo";
            CodCliente = GetCodigo();

            //  --- guardar
            guardarDatos(DNI, AP, AM, Nombres, Sexo, CodCliente, Estado);

            //  --- mostrar mensaje de respuesta

            

          
        }
    }
}
