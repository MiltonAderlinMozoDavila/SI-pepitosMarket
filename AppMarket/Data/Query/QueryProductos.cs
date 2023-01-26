using Data.AccesoDB;
using Entidades;
using System.Data.SqlClient;

namespace Data.Query
{
    
    public class QueryProductos
    {
        public bool CrearConexion()
        {
            //  --- Crear una nueva instancia de la clase cDataBase
            cDataBase db = new cDataBase();

            //  --- Crear una conexión llamando al método CrearConexion()
            return db.CrearConexion();
        }
        public cProducto GetProductobyCode(string Code)
        {
            //  --- abrir conexion con al base dedatos
            cDataBase db = new cDataBase();

            //  --- Crear una conexión llamando al método CrearConexion()
            db.CrearConexion();
            cProducto producto = new cProducto();
            //  --- Realizar consulta
            string Consulta = "SELECT * FROM Productos";
            SqlDataReader DatosProducto = db.EjecutarConsulta(Consulta);
            db.CrearConexion();
            
            while (DatosProducto.Read())
            {
                producto.Codigo = DatosProducto.GetString(0);
                producto.Nombre = DatosProducto.GetString(1);
                producto.Descripcion = DatosProducto.GetString(2);
                producto.UnidadMedida = DatosProducto.GetString(3);
                producto.Precio = DatosProducto.GetFloat(4);
                producto.Stock = DatosProducto.GetInt32(5);
                producto.FechaCaducidad = DatosProducto.GetDateTime(6);
                // hacer algo con los datos obtenidos

            }
            DatosProducto.Close();

            return producto;
            
        }

    }
}
