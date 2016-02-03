using System;
using TutorHub.Data.Resources;

namespace TutorHub.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public Int32 UserTypeId { get; set; }
    }
}