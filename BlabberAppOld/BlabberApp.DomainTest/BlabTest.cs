using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabTest
    {

        [TestMethod]
        public void TestBlabGetSysId()
        {
            Blab b = new Blab("Hello", "12345", new System.DateTime());
            string expect = b.getsysid();
            Assert.IsInstanceOfType(b.getsysid(), typeof(string));
        }

        [TestMethod]
        public void TestBlabMessage()
        {
            Blab b = new Blab("Hello", "12345", new System.DateTime());
            string expect = "Hello";
            Assert.AreEqual(b.Message, expect);
        }

        [TestMethod]
        public void TestBlabUserID()
        {
            Blab b = new Blab("Hello", "12345", new System.DateTime());
            b.UserId = "12345";
            string expect = "12345";
            Assert.AreEqual(expect, b.UserId);
        }
    }
}
