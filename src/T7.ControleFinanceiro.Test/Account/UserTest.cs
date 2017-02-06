using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Test.Account
{
    [TestClass]
    public class UserTest : TestBase
    {
        [TestMethod]
        public void TestGetById()
        {
            var service = GetService<IUserService>();
            var result = service.GetById("");

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