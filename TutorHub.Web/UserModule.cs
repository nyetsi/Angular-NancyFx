using System.Collections.Generic;
using Nancy;
using TutorHub.Data.DatabaseConnection;
using TutorHub.Data.Models;
using TutorHub.Data.Repository;
using TutorHub.Web.Models;

namespace TutorHub.Web
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
                var usersList = repo.GetList(2);
                return View["User.cshtml", usersList];
            };
        }
    }
}