using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVI;

namespace AVI
{
    internal class Cliente : Conectordb
    {
        public DataTable Clientelist()
        {
            this.SQLcomando = "SELECT * FROM Cliente";
            return this.Consultar();
        }
        public bool EliminarCliente(int id)
        {
            this.SQLcomando = $"DELETE FROM Cliente WHERE Idcliente = {id}";
            return this.Ejecutar();
        }
        public bool EditarCliente(int id, string nuevoNombre, string nuevoApellido, string nuevoTelefono, string nuevaDireccion, string nuevoDui)
        {
            this.SQLcomando = $@"
            UPDATE Cliente
            SET Nombre = '{nuevoNombre}',
            Apellido = '{nuevoApellido}',
            Telefono = '{nuevoTelefono}',
            Direccion = '{nuevaDireccion}',
            Dui = '{nuevoDui}'
            WHERE Idcliente = {id}";

            return this.Ejecutar();
        }
        public bool AgregarCliente(int idCliente, string nombre, string apellido, string telefono, string direccion, string dui)
        {
            this.SQLcomando = $@"
            INSERT INTO Cliente (Idcliente, Nombre, Apellido, Telefono, Direccion, Dui)
            VALUES ({idCliente}, '{nombre}', '{apellido}', '{telefono}', '{direccion}', '{dui}')";

            return this.Ejecutar();
        }
        //obtener el ultimo id de la tabla
        public DataTable UltimoId()
        {
            this.SQLcomando = "SELECT MAX(Idcliente) FROM Cliente";
            return this.Consultar();
        }
    }
}

