using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using TutorHub.Data.DatabaseConnection;
using TutorHub.Data.Models;
using TutorHub.Data.Repository;
using TutorHub.Data.Resources;

namespace TutorHub.BL.Api
{
    public class UserModule : NancyModule
    {
        public UserModule()
        {
        }

        public UserModule(IBaseRepository<User> userRepository) 
        {
            Get["/users"] =
            parameters => Negotiate.WithModel(userRepository.GetList((Int32) UserType.Learner));
        }
    }
}
