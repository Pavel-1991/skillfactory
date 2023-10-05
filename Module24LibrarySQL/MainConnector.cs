using System.Data;
using Microsoft.Data.SqlClient;
using Module24LibrarySQL.Configurations;

namespace Module24LibrarySQL
{
    public class MainConnector
    {
        SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);
        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто!");
            }
        }
    }

    


}
