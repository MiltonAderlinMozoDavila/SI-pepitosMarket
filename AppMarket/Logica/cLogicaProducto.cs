

using Data.AccesoDB;
using Data.Query;
using Entidades;

namespace Logica
{
    
    public class cLogicaProducto
    {

        public cProducto GetProducto(string Codigo)
        {
            QueryProductos queryProductos = new QueryProductos();
            return queryProductos.GetProductobyCode(Codigo);

        }


    }
}
