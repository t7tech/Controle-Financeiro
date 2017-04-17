using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Test.OAuth
{
    [TestClass]
    public class UserTest : TestBase
    {
        /*
        ------------------------------------------------------------------
        |                         Users                                  |
        ------------------------------------------------------------------
        |                 ID                  |        NAME              |
        |305c5c47-1b83-4ccb-8c51-21a04e8cde98 |Julio	Cesar            |
        ------------------------------------------------------------------
        */
        [TestMethod]
        public void TestGetById()
        {
            var service = GetService<IUserService>();
            var result = service.GetById("305c5c47-1b83-4ccb-8c51-21a04e8cde98");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestGetAll()
        {
            var service = GetService<IUserService>();
            var result = service.GetAll();

            Assert.AreEqual(result.Count(), 0);
        }
    }
}