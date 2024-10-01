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

        //insertar nueva venta y devover el id de la venta
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