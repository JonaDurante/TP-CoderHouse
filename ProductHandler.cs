using System.Data.SqlClient;

namespace Lucas_Mata
{
    public class ProductHandler
    {
        public const string ConnectionString = "Data Source=NKO\\SQLEXPRESS;Initial Catalog=SistemaGestion; Integrated Security=True;";

        public void AbrirCerrarConexion()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Producto", sqlConnection))
                {
                    sqlConnection.Open();

                    using SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    sqlConnection.Close();
                }
            }
        }
    }
}
