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
        public DataTable MarcasList()
        {
            this.SQLcomando = "SELECT * FROM Marca";
            return this.Consultar();
        }
        public bool EliminarMarca(int id)
        {
            this.SQLcomando = $"DELETE FROM Marca WHERE Idmarca = {id}";
            return this.Ejecutar();
        }

        public bool EditarMarca(int idmarca, string nuevoNombre)
        {
            this.SQLcomando = $"UPDATE Marca SET Nombre = '{nuevoNombre}' WHERE Idmarca = {idmarca}";
            return this.Ejecutar();
        }
        public bool AgregarMarca(string nombre)
        {
            this.SQLcomando = $"INSERT INTO Marca (Nombre) VALUES ('{nombre}')";
            return this.Ejecutar();
        }
        //
        public int Lastid()
        {
            this.SQLcomando = "SELECT MAX(Idmarca) FROM Marca";
            DataTable id = this.Consultar();
            string idmarca = id.Rows[0][0].ToString();

            // Check if the string is null or empty
            if (string.IsNullOrEmpty(idmarca))
            {
                idmarca = "0";
            }

            // Convert to integer
            return int.Parse(idmarca);

        }
    }
}

