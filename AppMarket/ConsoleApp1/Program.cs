using Entidades;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {


            cCliente cliente = new cCliente("1", "1", "1", "1", "1", "1", "1");
            cliente.Mostrar();
        }
    }
}