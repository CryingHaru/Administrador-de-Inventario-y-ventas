//conector db
using Microsoft.Data.SqlClient;
using System.Data;
namespace AVI { 
//import sql server library
    public class Conectordb
    {
        protected string SQLcomando = "";
        SqlConnection ConnectSQL = new SqlConnection();
        SqlCommand Command = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        private void Conectar()
        {
            ConnectSQL = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ferreteriadb;Integrated Security=True; TrustServerCertificate=True;");
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