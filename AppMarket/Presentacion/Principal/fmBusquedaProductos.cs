using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
namespace Presentacion.Principal
{
    public partial class fmBusquedaProductos : Form
    {
        public fmBusquedaProductos()
        {
        }

        private void MostraProductos()
        {

          

        }
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //  --- 
            


        }
        //  --- Configurar data grid
        private void ConfigurarDataGridView()
        {
            //Asigna el DataGridView a la variable dgv
            DataGridView dgv = dgvProductos;

            //Establece el numero de columnas en el DataGridView
            dgv.ColumnCount = 7;
            dgv.Dock = DockStyle.Fill;

            //Establece el modo de tamaño de las filas
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            //Establece el estilo de bordes de las cabeceras de las columnas
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            //Establece el estilo de bordes de las celdas
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            //Oculta las cabeceras de las filas
            dgv.RowHeadersVisible = false;

            //Establece el modo de seleccion
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Establece si se permite la multiseleccion
            dgv.MultiSelect = false;

            //  --- 
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            //Establece el nombre, el ancho y el alineamiento de la primera columna
            dgv.Columns[0].Name = "Item";
            dgv.Columns[0].Width = 50;
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].Name = "Codigo";
            dgv.Columns[1].Width = 100;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[2].Name = "Nombre";
            dgv.Columns[2].Width = 200;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[3].Name = "Descripcion";
            dgv.Columns[3].Width = 400;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[4].Name = "Unidad";
            dgv.Columns[4].Width = 50;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Name = "Cantidad";
            dgv.Columns[5].Width = 50;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Name = "Precio";
            dgv.Columns[5].Width = 50;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void fmBusquedaProductos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }
        private void AgregarDatos(int item, string Codigo, string Nombre,string Descripcion,string Unidad,  float Cantidad, float PrecioUni)
        {

            DataGridView dgv = dgvProductos;
            dgv.Rows.Add(item, Codigo, Nombre,Descripcion, Unidad, PrecioUni, Cantidad);

        }
        //  ---

        
    }
}
