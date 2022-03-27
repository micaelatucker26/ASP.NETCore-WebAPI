using System.Data;
using System.Data.SqlClient;

namespace MarketAPI.DataContext
{
    public class DataAccess: IDataAccess
    {
        private readonly IConfiguration _config;

        public DataAccess(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<T> LoadObjects<T>(string connectionId = "Default")
        {
            using IDbConnection connection = 
                new SqlConnection(_config.GetConnectionString(connectionId));
            // open connection
            // create sql query/ sql command
            // create sql adapter
            // gather list of items
            // return list of items
            return null; 
        }

        public T LoadObject<T>(int id, string connectionId = "Default")
        {
            using IDbConnection connection = 
                new SqlConnection(_config.GetConnectionString(connectionId));

            /*
             * SELECT * FROM Item WHERE ID = @id;
             * SELECT * FROM Category WHERE ID = @id;
             * */
            return default(T);
        }

        public void SaveObject<T>(int id, string connectionId = "Default")
        {
            using IDbConnection connection = 
                new SqlConnection(_config.GetConnectionString(connectionId));
        }

        public T SaveNewObject<T>(object newObject , string connectionId = "Default")
        {
            using IDbConnection connection = 
                new SqlConnection(_config.GetConnectionString(connectionId));
            return default(T);
        }

        public void DeleteObject<T> (int id, string connectionId = "Default")
        {
            using IDbConnection connection = 
                new SqlConnection(_config.GetConnectionString(connectionId));
        }
    }
}
