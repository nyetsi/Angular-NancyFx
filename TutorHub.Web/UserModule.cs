using Nancy;

namespace TutorHub.Web
{
    public class UserModule : NancyModule
    {
        public UserModule()
        {
            Get["/"] =
            parameters =>
            {
                return "Test";
                // Negotiate.WithModel(userRepository.GetList((Int32) UserType.Learner));
            };
        }
    }
}
