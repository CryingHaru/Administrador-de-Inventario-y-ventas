//conector db
using Microsoft.Data.SqlClient;
namespace Administrador_de_Inventario_y_ventas { 
//import sql server library
    class Conectordb
    {
        protected string SQLcomando = "";
        SqlConnection ConnectSQL = new SqlConnection();
        SqlCommand Command = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        private void Conectar()
        {
            ConnectSQL = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TiendaOnline;Integrated Security=True");
            try
            {
                ConnectSQL.Open();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error de SQL: " + error.Message);
            }
        }

        protected DataTable Consultar()
        {
            DataTable Datos = new DataTable();
            Conectar();
            try
            {
                Adapter = new SqlDataAdapter(SQLcomando, ConnectSQL);
                Adapter.Fill(Datos);
                ConnectSQL.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error de SQL: " + error.Message);
            }
            return Datos;
        }
        protected bool Ejecutar()
        {
            Conectar();
            try
            {
                Command = new SqlCommand(SQLcomando, ConnectSQL);
                Command.ExecuteNonQuery();
                ConnectSQL.Close();
                return true;
            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error de SQL: " + error.Message);
                return false;
            }
        }
    }
}