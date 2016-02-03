using System.Data.SqlClient;

namespace TutorHub.Data.DatabaseConnection
{
    public interface IDataAccess
    {
        SqlConnection Connect();
    }
}