
namespace Data.AccesoDB
{
    public class cDBConfig
    {

        #region *********************** ATRIBUTOS ************************
        private string aServerName;
        private string aDataBaseName;
        private string aUserID;
        private string aPassword;
        private bool aSecurity;
        private bool aMultiple;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************
        #region ==================== CONSTRUCTORES =======================
        // ----------------------------------------------------------------
        public cDBConfig()
        {
            aServerName = "MILTON";
            aDataBaseName = "DBMarket";
            aUserID = "UsuarioAderlin";
            aPassword = "000000";
            aSecurity = true;
            aMultiple = true;
        }

        // ----------------------------------------------------------------
        public cDBConfig(string pServerName, string pDataBaseName, string pUserID, string pPassword, bool pSecurity, bool pMultiple)
        {
            aServerName = pServerName;
            aDataBaseName = pDataBaseName;
            aUserID = pUserID;
            aPassword = pPassword;
            aSecurity = pSecurity;
            aMultiple = pMultiple;
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        // ----------------------------------------------------------------
        private string ServerName
        {
            get { return aServerName; }
            set { aServerName = value; }
        }
        // ----------------------------------------------------------------
        private string DataBaseName
        {
            get { return aDataBaseName; }
            set { aDataBaseName = value; }
        }
        // ----------------------------------------------------------------
        private string UserID
        {
            get { return aUserID; }
            set { aUserID = value; }
        }
        // ----------------------------------------------------------------
        private string Password
        {
            get { return aPassword; }
            set { aPassword = value; }
        }
        // ----------------------------------------------------------------
        private bool Security
        {
            get { return aSecurity; }
            set { aSecurity = value; }
        }
        // ----------------------------------------------------------------
        private bool Multiple
        {
            get { return aMultiple; }
            set { aMultiple = value; }
        }
        // ----------------------------------------------------------------
        private string connectionString()
        {
            return "Data Source=" + ServerName + ";" + "Initial Catalog="+ DataBaseName+";" + "User ID="+ UserID + ";" + "Password="+ Password + ";" + "Integrated Security=" + Security.ToString() + ";" + "MultipleActiveResultSets="+Multiple.ToString();
        }

        // ----------------------------------------------------------------
        private string connectionString(bool opcion)
        {
            return "Data Source=" + ServerName + ";" + "Initial Catalog=" + DataBaseName + ";" + " Integrated Security=" + Security.ToString();
        }
        #endregion ==================== PROPIEDADES =======================

        #region ==================== MÉTODOS PROCESO =======================
        #endregion ==================== MÉTODOS PROCESO =======================

        public string GetConnectionString()
        {
            return connectionString();
        }
        #endregion *********************** METODOS ************************
    }

}
