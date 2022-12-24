using System.Data;
using System.Data.SqlClient;

namespace Data.DataBase
{
    public class cDataBase
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlAdapter;   // permite lectura de datos
        private SqlCommand sqlCommand;       // permite enviar, actualizar la base de datos
        private DataSet DataSet; // resultados
        private DataTable Parametros; 

    }
}
