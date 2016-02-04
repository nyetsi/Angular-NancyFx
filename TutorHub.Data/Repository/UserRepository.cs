using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using TutorHub.Data.DatabaseConnection;
using TutorHub.Data.Models;
using TutorHub.Data.Resources;

namespace TutorHub.Data.Repository
{
    public class UserRepository : IBaseRepository<LoginUser>
    {
        private readonly IDataAccess dataAccess;

        public UserRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public string Create(LoginUser user)
        {
            using (var conn = dataAccess.Connect())
            {
                var query = "INSERT INTO [User](UserName,[Password],TypeId)" +
                                     "VALUES(@Username,@Password,@UserTypeId)";
                conn.Execute(query, new {user.Username, user.Password, user.UserTypeId});

                return "Success";
            }
        }

        public IEnumerable<LoginUser> GetList(int type)
        {
            using (var conn = dataAccess.Connect())
            {
                var query = "Select * From [User] Where TypeId=" + type;
                var result = conn.Query<LoginUser>(query);
                return result;
            }
        }

        public LoginUser FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public string Update(LoginUser entity)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}