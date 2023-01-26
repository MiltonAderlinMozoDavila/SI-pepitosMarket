using System;

namespace Entidades
{
    public class cProducto
    {

        #region *********************** ATRIBUTOS ************************
        private string aCodigo;
        private string aNombre;
        private string aDescripcion;
        private string aUnidadMedida;
        private float aPrecio;
        private int aStock;
        private DateTime aFechaCaducidad;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************
        #region ==================== CONSTRUCTORES =======================
        // ----------------------------------------------------------------
        public cProducto()
        {
            aCodigo = "";
            aNombre = "";
            aDescripcion = "";
            aUnidadMedida = "";
            aPrecio = 0;
            aStock = 0;
            aFechaCaducidad = DateTime.Now;
        }

        // ----------------------------------------------------------------
        public cProducto(string pCodigo, string pNombre, string pDescripcion, string pUnidadMedida, float pPrecio, int pStock, DateTime pFechaCaducidad)
        {
            aCodigo = pCodigo;
            aNombre = pNombre;
            aDescripcion = pDescripcion;
            aUnidadMedida = pUnidadMedida;
            aPrecio = pPrecio;
            aStock = pStock;
            aFechaCaducidad = pFechaCaducidad;
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        // ----------------------------------------------------------------
        public string Codigo
        {
            get { return aCodigo; }
            set { aCodigo = value; }
        }
        // ----------------------------------------------------------------
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }
        // ----------------------------------------------------------------
        public string Descripcion
        {
            get { return aDescripcion; }
            set { aDescripcion = value; }
        }
        // ----------------------------------------------------------------
        public string UnidadMedida
        {
            get { return aUnidadMedida; }
            set { aUnidadMedida = value; }
        }
        // ----------------------------------------------------------------
        public float Precio
        {
            get { return aPrecio; }
            set { aPrecio = value; }
        }
        // ----------------------------------------------------------------
        public int Stock
        {
            get { return aStock; }
            set { aStock = value; }
        }
        // ----------------------------------------------------------------
        public DateTime FechaCaducidad
        {
            get { return aFechaCaducidad; }
            set { aFechaCaducidad = value; }
        }
        #endregion ==================== PROPIEDADES =======================

        #region ==================== MÉTODOS PROCESO =======================
        /*
        // ----------------------------------------------------------------
        public string ToString()
        {

        }
        // ----------------------------------------------------------------
        public bool Equals()
        {

        }
        // ----------------------------------------------------------------
        public void Leer()
        {
            Console.Write("INGRESAR DATOS DE PRODUCTO");
            Console.Write("==========================");
            Console.Write("Ingrese Codigo: ");
            Codigo = Console.ReadLine();
            Console.Write("Ingrese Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese Descripcion: ");
            Descripcion = Console.ReadLine();
            Console.Write("Ingrese UnidadMedida: ");
            UnidadMedida = Console.ReadLine();
            Console.Write("Ingrese Precio: ");
            Precio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Stock: ");
            Stock = int.Parse(Console.ReadLine());
            Console.Write("Ingrese FechaCaducidad: ");
            FechaCaducidad = DateTime.Parse(Console.ReadLine());

        }
        // ----------------------------------------------------------------
        public void Mostrar()
        {
            Console.Write("DATOS DE PRODUCTO");
            Console.Write("=================");
            Console.WriteLine("Codigo = ", Codigo);
            Console.WriteLine("Nombre = ", Nombre);
            Console.WriteLine("Descripcion = ", Descripcion);
            Console.WriteLine("UnidadMedida = ", UnidadMedida);
            Console.WriteLine("Precio = ", Precio.ToString());
            Console.WriteLine("Stock = ", Stock.ToString());
            Console.WriteLine("FechaCaducidad = ", FechaCaducidad.ToString());

        }
        // ----------------------------------------------------------------
        public void Escribir()
        {
            Console.WriteLine(Codigo.PadRight(12) + Nombre.PadRight(40) + Descripcion.PadRight(40) + UnidadMedida.PadRight(12) + Precio.PadLeft(12) + Stock.PadLeft(5) + FechaCaducidad.PadRight(12));

        }
        */
        #endregion ==================== MÉTODOS PROCESO =======================

        #endregion *********************** METODOS ************************

    }

}
