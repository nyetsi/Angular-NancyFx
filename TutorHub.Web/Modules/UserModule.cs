using System.Linq;
using Nancy;
using TutorHub.Data.DatabaseConnection;
using TutorHub.Data.Repository;
using TutorHub.Data.Resources;
using TutorHub.Web.Models;

namespace TutorHub.Web.Modules
{
    public class UserModule : NancyModule
    {
        private DataAccess dataAccess;
        private UserRepository repo;

        public UserModule()
        {
            dataAccess = new DataAccess();

            repo = new UserRepository(dataAccess);

            Get["/"] = _ => "Hello Nancy";

            Get["/user"] = parameters =>
            {
                var usersList = repo.GetList((int) UserType.Learner).Select(x => new UserViewModel(x)).ToList();
                return View["User.cshtml", usersList];
            };
        }
    }
}