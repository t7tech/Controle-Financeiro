using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Test.OAuth
{
    [TestClass]
    public class ClaimsTest : TestBase
    {
        [TestMethod]
        public void TestAdd()
        {
            var service = GetService<IClaimService>();
            service.Add(new ClaimsEntity
            {
                Name = "Claim1"
            });
        }

        [TestMethod]
        public void TestGetAll()
        {
            var service = GetService<IClaimService>();
            var result = service.GetAll();

            Assert.IsTrue(result.Count() > 0);
        }
    }
}