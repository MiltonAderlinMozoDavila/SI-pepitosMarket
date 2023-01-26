using System.Data;
using System.Data.SqlClient;
using System.IO;
using System;

namespace Data.AccesoDB
{
    public class cDataBase
    {
        //  --- ATRIBUTOS 
        public SqlConnection sqlConnection;    // permite la conexion a la base de datos
        private SqlCommand sqlCommand;       // permite enviar, actualizar la base de datos
        private SqlDataReader reader;
        //private SqlDataAdapter sqlAdapter;   // permite lectura de datos


        private string ConnectionString;

        //  --- CONSTRUCCTORES
        public cDataBase()
        {
            GetConnectionString();
            sqlConnection = new SqlConnection(ConnectionString);
        }
        //  --- METODOS


        //  --- Obtener la cadena de conexion
        private void GetConnectionString()
        {
            cDBConfig DBConfig = new cDBConfig();
            ConnectionString = DBConfig.GetConnectionString();
        }
        //  --- Crear conexion
        public bool CrearConexion()
        {
            try
            {
                sqlConnection.Open();
                Console.WriteLine("abrir la conexion exito");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion" + ex.Message);
                return false;
            }
        }

        //  --- Cerrar conexion
        public void CerrarConexion()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        
        //  --- ejecutar consulta
        public SqlDataReader EjecutarConsulta(string consulta)
        {
            sqlCommand = new SqlCommand(consulta, sqlConnection);
            reader = sqlCommand.ExecuteReader();
            return reader;
        }
        /*
        //  --- Ejecutar Acccin
        public int EjecutarAccion(string accion)
        {
            sqlCommand = new SqlCommand(accion, sqlConnection);
            return sqlCommand.ExecuteNonQuery();
        }
        */


    }
}
