using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutorHub.Data.Models;
using TutorHub.Data.Resources;

namespace TutorHub.Web.Models
{
    public class UserViewModel
    {
        private List<UserViewModel> users;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public UserViewModel()
        {
            users = new List<UserViewModel>();
        }

        public UserViewModel(IEnumerable<LoginUser> usersList)
        {
            foreach (var user in usersList)
            {
                MapToModel(user);
            }
        }

        private void MapToModel(LoginUser user)
        {
            Id = user.Id;
            Username = user.Username;
            Password = user.Password;
            UserType = user.UserType;
        }
    }
}