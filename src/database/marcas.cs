using AVI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVI
{
    internal class Marca : Conectordb
    {
        public DataTable ProductosList()
        {
            this.SQLcomando = "SELECT * FROM Marca";
            return this.Consultar();
        }
        public bool EliminarCategoria(int id)
        {
            this.SQLcomando = $"DELETE FROM Marca WHERE Idmarca = {id}";
            return this.Ejecutar();
        }

        public bool EditarCategoria(int id, string nuevoNombre)
        {
            this.SQLcomando = $"UPDATE Marca SET Nombre = '{nuevoNombre}' WHERE Idmarca = {id}";
            return this.Ejecutar();
        }
        public bool AgregarCategoria(int Idmarca, string nombre)
        {
            this.SQLcomando = $"INSERT INTO Marca (Idmarca, Nombre) VALUES ({Idmarca}, '{nombre}')";
            return this.Ejecutar();
        }
    }
}

