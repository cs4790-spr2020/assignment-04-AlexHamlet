using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class UserTest
    {

        [TestMethod]
        public void UserGetName()
        {
            User user = new User("John Kennedy", "S3cuR3", "UnkillableMan@hotmail.com");
            string expected = "John Kennedy";
            Assert.AreEqual(expected, user.UserName);
        }

        [TestMethod]
        public void UserSetName()
        {
            User user = new User("John Kennedy", "S3cuR3", "UnkillableMan@hotmail.com");
            string expected = "Recently Deceased";
            user.UserName = expected;
            Assert.AreEqual(expected, user.UserName);
        }

        [TestMethod]
        public void UserGetEmail()
        {
            User user = new User("John Kennedy", "S3cuR3", "UnkillableMan@hotmail.com");
            string expected = "UnkillableMan@hotmail.com";
            Assert.AreEqual(expected, user.Email);
        }

        [TestMethod]
        public void UserSetEmail()
        {
            User user = new User("John Kennedy", "S3cuR3", "UnkillableMan@hotmail.com");
            string expected = "RecentlyDeceased@hotmail.com";
            user.Email = expected;
            Assert.AreEqual(expected, user.Email);
        }

        [TestMethod]
        public void UserGetSysID()
        {
            User user = new User("John Kennedy", "S3cuR3", "UnkillableMan@hotmail.com");
            Assert.IsInstanceOfType(user.getsysid(), typeof(string));
        }

        
    }
}
