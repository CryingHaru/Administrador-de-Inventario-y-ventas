using AVI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVI
{
    class Categorias : Conectordb
    {
        public DataTable CategoriasList()
        {
            this.SQLcomando = "SELECT * FROM Categorias";
            return this.Consultar();
        }
        public bool EliminarCategoria(int id)
        {
            this.SQLcomando = $"DELETE FROM Categorias WHERE Idcategoria = {id}";
            return this.Ejecutar();
        }

        public bool EditarCategoria(int id,string nuevoNombre)
        {
            this.SQLcomando = $"UPDATE Categorias SET Nombre = '{nuevoNombre}' WHERE Idcategoria = {id}";
            return this.Ejecutar();
        }
        public bool AgregarCategoria( string nombre)
        {
            this.SQLcomando = $"INSERT INTO Categorias ( Nombre) VALUES ( '{nombre}')";
            return this.Ejecutar();
        }
        //obtener el ultimo id de la tabla
        public int Lastid()
        {
            this.SQLcomando = "SELECT MAX(Idcategoria) FROM Categorias";
            DataTable id = this.Consultar();
            string idcategoria = id.Rows[0][0].ToString();

            // Check if the string is null or empty
            if (string.IsNullOrEmpty(idcategoria))
            {
                idcategoria = "0";
            }

            // Convert to integer
            return int.Parse(idcategoria);
        }
        }
}
