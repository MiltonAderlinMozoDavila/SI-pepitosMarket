

namespace Entidades
{
    public class cCliente : cPersona
    {

        #region *********************** ATRIBUTOS ************************
        private string aID;
        private string aEstado;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************
        #region ==================== CONSTRUCTORES =======================
        // ----------------------------------------------------------------
        public cCliente()
            :base()
        {
            aID = "";
            aEstado = "";
        }

        // ----------------------------------------------------------------
        public cCliente(string pID,string pDNI, string pAP, string pAM, string pNombres, string pSexo, string pEstado)
            :base(pDNI, pAP,  pAM,  pNombres,  pSexo)
        {
            aID = pID;
            aEstado = pEstado;
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        // ----------------------------------------------------------------
        public string ID
        {
            get { return aID; ; }
            
            set { aID = value; }

        }
        // ----------------------------------------------------------------
        public string Estado
        {
            get { return aEstado; }
            set { aEstado = value; }
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
        */
        public override void Leer()
        {
            base.Leer();
            Console.Write("INGRESAR DATOS DE ");
            Console.Write("==================");
            Console.Write("Ingrese ID: ");
            ID = Console.ReadLine();
            Console.Write("Ingrese Estado: ");
            Estado = Console.ReadLine();

        }
        // ----------------------------------------------------------------
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("ID = "+ ID);
            Console.WriteLine("Estado = "+ Estado);

        }
        // ----------------------------------------------------------------
        public override void Escribir()
        {
            Console.WriteLine(ID.PadRight(12) + Estado.PadRight(5));

        }
        #endregion ==================== MÉTODOS PROCESO =======================

        #endregion *********************** METODOS ************************
    }


}
