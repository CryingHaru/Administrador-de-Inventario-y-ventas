using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace AVI
{
    public class Ventas : Conectordb
    {
      public DataTable VentasList()
        {
            DataTable Ventas;
            this.SQLcomando = "SELECT VentaCabecera.Idventa AS ID, VentaCabecera.Fecha AS Fecha, Cliente.Nombre AS Nombre, Cliente.Apellido AS Apellido FROM dbo.VentaCabecera INNER JOIN dbo.Cliente ON VentaCabecera.Idcliente = Cliente.Idcliente";
            Ventas = this.Consultar();
            return Ventas;
        }
        public DataTable cantotal(int id)
        {
            this.SQLcomando = "SELECT SUM(Ventaprodutos.Cantidad) AS Cantidad, SUM(Ventaprodutos.Preciounitario *Ventaprodutos.Cantidad) AS Total FROM dbo.Ventaprodutos INNER JOIN dbo.VentaCabecera ON Ventaprodutos.Idventa = VentaCabecera.Idventa WHERE VentaCabecera.Idventa =" + id; 
            return this.Consultar();
        }
        public DataTable DetallesVenta(int id)
        {
            this.SQLcomando = "SELECT VentaCabecera.Idventa AS ID, VentaCabecera.Fecha AS Fecha, Cliente.Nombre AS Nombre, Cliente.Apellido AS Apellido FROM dbo.VentaCabecera INNER JOIN dbo.Cliente ON VentaCabecera.Idcliente = Cliente.Idcliente WHERE VentaCabecera.Idventa =" + id;
            return this.Consultar();
        }
        public void Anular(int id)
        {
            //restaurar existencias
            this.SQLcomando = "SELECT Idproducto, Cantidad FROM Ventaprodutos WHERE Idventa =" + id;
            DataTable productos = this.Consultar();
            foreach (DataRow row in productos.Rows)
            {
                new Productos().Existencias(Convert.ToInt32(row["Idproducto"]), true, Convert.ToInt32(row["Cantidad"]));
            }
            this.SQLcomando = "UPDATE Ventaprodutos SET Cantidad = 0 WHERE Idventa =" + id;
            this.Ejecutar();

        }
        public DataTable Productosventas(int id)
        {
            this.SQLcomando = "SELECT Ventaprodutos.Idproducto AS ID, Productos.Nombre AS Nombre,Productos.Imagen AS Imagen, Ventaprodutos.Cantidad AS Cantidad, Ventaprodutos.Preciounitario AS Precio FROM dbo.Ventaprodutos INNER JOIN dbo.Productos ON Ventaprodutos.Idproducto = Productos.IdProducto WHERE Ventaprodutos.Idventa =" + id;
            return this.Consultar();
        }
        public string NuevaVenta(int idcliente)
        {
            this.SQLcomando = $"INSERT INTO VentaCabecera (Idcliente, Fecha) VALUES ({idcliente}, getdate())";
            this.Ejecutar();
            this.SQLcomando = "SELECT MAX(Idventa) FROM VentaCabecera";
            DataTable id = this.Consultar();
            string idventa = id.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(idventa))
            {
                idventa = "0";
            }
            return idventa;
        }
        //agregar prodductos a ventaproductos
        public void AgregarProducto(int idventa, int idproducto, int cantidad,double preciounit)
        {
            this.SQLcomando = $"INSERT INTO Ventaprodutos (Idventa, Idproducto, Cantidad, Preciounitario) VALUES ({idventa}, {idproducto}, {cantidad}, {preciounit})";
            this.Ejecutar();
            //quitar existencias
            new Productos().Existencias(idproducto, false, cantidad);
        }
    }

}