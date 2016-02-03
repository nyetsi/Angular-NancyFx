using System;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using TutorHub.Data.DatabaseConnection;
using TutorHub.Data.Models;
using TutorHub.Data.Repository;
using TutorHub.Data.Resources;

namespace TutorHub.Test.UserTests
{
    [TestFixture]
    public class UserQueryingTests
    {
        [Test]
        public void For_Users_Given_AnyType_ResultsIs_ListOfUsers()
        {
            int type = 2;
            var access = new DataAccess();
            var db = new UserRepository(access);

            var result = db.GetList(type);

            Assert.AreEqual(3, result.Count());
        }
        
        [Test]
        public void For_UserCreation_Given_UserModel_ResultsIs_Success()
        {
            Int32 type = 1;
            var access = Substitute.For<IDataAccess>();
            var db = Substitute.For<IBaseRepository<User>>();

            var user = new User() {Username = "John",Password = "JJ23",UserTypeId = type};

            var result = db.Create(user);

            db.Received();

        }
    }
}