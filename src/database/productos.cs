﻿using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

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
        public void ProductoDelete(int id)
        {
            this.SQLcomando = "DELETE FROM Productos WHERE IdProducto = " + id;
            this.Ejecutar();
        }
        public bool ProductoAdd(string nombre,string descripcion, int marca, int categoria, decimal precio, string imagen, string codigobarra)
        {
            int stock = 0;
            nombre = nombre.Replace("'", "''");
            descripcion = descripcion.Replace("'", "''");
            this.SQLcomando = $"INSERT INTO Productos ( Marca, Categoria, Detalles, Precioventa, Existencias, Imagen, Codigobarra, Nombre) VALUES ({marca}, {categoria}, '{descripcion}', {precio}, {stock}, '{imagen}', '{codigobarra}', '{nombre}')";
            return this.Ejecutar();
        }
        public int Lastid()
        {
            this.SQLcomando = "SELECT MAX(IdProducto) FROM Productos";
            DataTable id = this.Consultar();
            string idproducto = id.Rows[0][0].ToString();

            // Check if the string is null or empty
            if (string.IsNullOrEmpty(idproducto))
            {
                idproducto = "0";
            }

            // Convert to integer
            return int.Parse(idproducto);
        }
        public void ProductoEdit(int id, string nombre, string descripcion, int marca, int categoria, decimal precio, string imagen)
        {
            nombre = nombre.Replace("'", "''");
            descripcion = descripcion.Replace("'", "''");
            this.SQLcomando = $"UPDATE Productos SET Marca = {marca}, Categoria = {categoria}, Detalles = '{descripcion}', Precioventa = {precio}, Imagen = '{imagen}', Nombre = '{nombre}' WHERE IdProducto = {id}";
            this.Ejecutar();
        }
        public DataTable listimages()
        {
            this.SQLcomando = "SELECT Imagen FROM Productos";
            return this.Consultar();
        }
        public void Existencias(int id, bool accion, int valor)
        {
            if (accion)
            {
                //INSERT INTO [dbo].[Movimientos] (Fecha, Tipo, Producto, Cantidad) VALUES('2024-09-26 10:00:00', 1, 1, 100);
               
                this.SQLcomando = $"INSERT INTO [dbo].[Movimientos] (Fecha, Tipo, Producto, Cantidad) VALUES(GETDATE(), 1, {id}, {valor})";
                this.Ejecutar();

                this.SQLcomando = $"UPDATE Productos SET Existencias = Existencias + {valor} WHERE IdProducto = {id}";
            }
            else
            {
                this.SQLcomando = $"INSERT INTO [dbo].[Movimientos] (Fecha, Tipo, Producto, Cantidad) VALUES(GETDATE(), 0, {id}, {valor})";
                this.Ejecutar();
                this.SQLcomando = $"UPDATE Productos SET Existencias = Existencias - {valor} WHERE IdProducto = {id}";

            }
            this.Ejecutar();
        }
        public DataTable Movimientos()
        {
            this.SQLcomando = "SELECT Movimientos.Fecha AS Fecha, Movimientos.Tipo AS Tipo, Productos.Nombre, Movimientos.Cantidad FROM dbo.Movimientos INNER JOIN dbo.Productos ON Movimientos.Producto = Productos.IdProducto";
            return this.Consultar();

        }
    }

}