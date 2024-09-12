//conector db
using Microsoft.Data.SqlClient;
namespace Administrador_de_Inventario_y_ventas { 
//import sql server library
    public class Conectordb
    {
        private string Server = "localhost";
        private string Database = "ferreteriadb";

        public SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("Server=" + Server + ";Database=" + Database + ";Trusted_Connection=True;");
            
        }
        //metodo para abrir la conexion
    }
}