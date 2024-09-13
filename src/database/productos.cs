using System.Data;

namespace AVI
{
    public class Productos : Conectordb
    {
        public DataTable ProductosList()
        {
            this.SQLcomando = "SELECT * FROM Productos";
            return this.Consultar();
        }
    }
}