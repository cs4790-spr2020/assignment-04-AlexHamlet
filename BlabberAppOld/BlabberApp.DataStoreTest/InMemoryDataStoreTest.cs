using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemoryDataStoreTest
    {
        InMemoryDataStore imd;
        [TestMethod]
        public void CreateandRead()
        {
            imd = new InMemoryDataStore();
            Blab b = new Blab("Generic Saying", "Fake User",System.DateTime.Now);
            InMemorySpecimen s = new InMemorySpecimen(b.getsysid());
            imd.Create(b);
            Assert.AreEqual(b, imd.Read(s));
        }

        [TestMethod]
        public void DeleteAndRead(){
            imd = new InMemoryDataStore();
            Blab b = new Blab("Generic Saying", "Fake User",System.DateTime.Now);
            InMemorySpecimen s = new InMemorySpecimen(b.getsysid());
            imd.Create(b);
            imd.Delete(s);
            Assert.IsNull(imd.Read(s));
        }

        [TestMethod]
        public void ModifyAndRead(){
            imd = new InMemoryDataStore();
            Blab b = new Blab("Generic Saying", "Fake User",System.DateTime.Now);
            InMemorySpecimen s = new InMemorySpecimen(b.getsysid());
            imd.Create(b);
            b.Message = "Specific Saying";
            imd.Update(b);
            Assert.AreEqual(b.Message, ((Blab)imd.Read(s)).Message);
        }
    }
}
