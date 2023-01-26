using Entidades;
using Logica;
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
    public partial class fmVentas : Form
    {
        public fmVentas()
        {
            InitializeComponent();
        }
        

       
        //  --- metodo para configurar el data grid view
        private void ConfigurarDataGridView()
        {
            //Asigna el DataGridView a la variable dgv
            DataGridView dgv = dgvListaProductos;

            //Establece el numero de columnas en el DataGridView
            dgv.ColumnCount = 6;
            int AnchoPanelDgv = panelDataGrid.Width;
            dgv.Dock = DockStyle.Fill;
            //Establece el color y el estilo de las cabeceras de las columnas
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.YellowGreen;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            //Establece el nombre del DataGridView
            dgv.Name = "Lista de Productos";

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
            dgv.Columns[2].Width = 400;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[3].Name = "Precio Unidad";
            dgv.Columns[3].Width = 50;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[4].Name = "Cantidad";
            dgv.Columns[4].Width = 50;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Name = "Total";
            dgv.Columns[5].Width = 50;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void fmVentas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }

        //  --- Agregar fila
        private void AgregarDatos(int item, string Codigo, string Nombre, float PrecioUni,float Cantidad,float Total)
        {
            
            DataGridView dgv = dgvListaProductos;
            dgv.Rows.Add(item, Codigo, Nombre, PrecioUni, Cantidad, Total);

        }
        private void GetProductobyCode()
        {
            string CodigoProducto = tbLeerCodigo.Text;
            cLogicaProducto logProducto = new cLogicaProducto();
            cProducto producto = logProducto.GetProducto(CodigoProducto);

            //  --- mostrar en el grid
            int item = 1;
            string Codigo = producto.Codigo;
            string Nombre = producto.Nombre;
            float PrecioUni = producto.Precio;
            float Cantidad = 1;
            float Total = Cantidad *PrecioUni;
            AgregarDatos(item, Codigo, Nombre, PrecioUni, Cantidad, Total);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //GetProductobyCode();
            fmBusquedaProductos fmBuscar = new fmBusquedaProductos();
            fmBuscar.Show();

        }
    }
}
