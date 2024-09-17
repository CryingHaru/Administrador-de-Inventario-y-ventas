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
        public DataTable ProductosList()
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
        public bool AgregarCategoria(int idCategoria, string nombre)
        {
            this.SQLcomando = $"INSERT INTO Categorias (Idcategoria, Nombre) VALUES ({idCategoria}, '{nombre}')";
            return this.Ejecutar();
        }
        //obtener el ultimo id de la tabla
        public DataTable UltimoId()
        {
            this.SQLcomando = "SELECT MAX(Idcategoria) FROM Categorias";
            return this.Consultar();
        }
    }
}
