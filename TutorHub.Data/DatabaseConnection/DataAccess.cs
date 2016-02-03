using System.Configuration;
using System.Data.SqlClient;

namespace TutorHub.Data.DatabaseConnection
{
    public class DataAccess : IDataAccess
    {
        string connectionString;
        public DataAccess()
        {
            connectionString = @"Data Source=kyoto\kyoto; Initial Catalog=TutorHub;Integrated Security=True";
                //ConfigurationManager.ConnectionStrings["DB_CONNECTION"].ToString();
        }
        
        public SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
