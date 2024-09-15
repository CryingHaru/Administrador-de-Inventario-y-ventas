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
        public DataTable GetMarcaCategoria(int id)
        {
            this.SQLcomando = "SELECT Marca.Nombre AS Marca, Categorias.Nombre AS Categoria FROM dbo.Productos INNER JOIN dbo.Marca ON Productos.Marca = Marca.Idmarca INNER JOIN dbo.Categorias ON Productos.Categoria = Categorias.Idcategoria WHERE Productos.IdProducto =" + id;
            return this.Consultar();
        }
        public void DeProducto(int id)
        {
            this.SQLcomando = "DELETE FROM Productos WHERE IdProducto = " + id;
            this.Ejecutar();
        }
    }
}