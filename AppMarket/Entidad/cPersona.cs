using System.IO;

namespace Entidades
{
    public class cPersona
    {

        #region *********************** ATRIBUTOS ************************
        private string aDNI;
        private string aAP;
        private string aAM;
        private string aNombres;
        private string aSexo;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************
        #region ==================== CONSTRUCTORES =======================
        // ----------------------------------------------------------------
        
        public cPersona()
        {
            aDNI = "";
            aAP = "";
            aAM = "";
            aNombres = "";
            aSexo = "";
        }
        
        // ----------------------------------------------------------------
        public cPersona(string pDNI, string pAP, string pAM, string pNombres, string pSexo)
        {
            aDNI = pDNI;
            aAP = pAP;
            aAM = pAM;
            aNombres = pNombres;
            aSexo = pSexo;
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        // ----------------------------------------------------------------
        public string DNI
        {
            get { return aDNI; }
            set { aDNI = value; }
        }
        // ----------------------------------------------------------------
        public string AP
        {
            get { return aAP; }
            set { aAP = value; }
        }
        // ----------------------------------------------------------------
        public string AM
        {
            get { return aAM; }
            set { aAM = value; }
        }
        // ----------------------------------------------------------------
        public string Nombres
        {
            get { return aNombres; }
            set { aNombres = value; }
        }
        // ----------------------------------------------------------------
        public string Sexo
        {
            get { return aSexo; }
            set { aSexo = value; }
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
        public virtual void Leer()
        {
            Console.Write("INGRESAR DATOS DE ");
            Console.Write("==================");
            Console.Write("Ingrese DNI: ");
            DNI = Console.ReadLine();
            Console.Write("Ingrese AP: ");
            AP = Console.ReadLine();
            Console.Write("Ingrese AM: ");
            AM = Console.ReadLine();
            Console.Write("Ingrese Nombres: ");
            Nombres = Console.ReadLine();
            Console.Write("Ingrese Sexo: ");
            Sexo = Console.ReadLine();

        }
        // ----------------------------------------------------------------
        public virtual void Mostrar()
        {
            Console.WriteLine("DATOS DE ");
            Console.WriteLine("=========");
            Console.WriteLine("DNI = "+ DNI);
            Console.WriteLine("AP = "+ AP);
            Console.WriteLine("AM = "+ AM);
            Console.WriteLine("Nombres = "+ Nombres);
            Console.WriteLine("Sexo = "+ Sexo);

        }
        // ----------------------------------------------------------------
        public virtual void Escribir()
        {
            Console.WriteLine(DNI.PadRight(3) + AP.PadRight(2) + AM.PadRight(2) + Nombres.PadRight(40) + Sexo.PadRight(4));

        }
        #endregion ==================== MÉTODOS PROCESO =======================

        #endregion *********************** METODOS ************************
    }


}
