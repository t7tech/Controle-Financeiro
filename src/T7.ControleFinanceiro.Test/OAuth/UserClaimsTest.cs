using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Test.OAuth
{
    [TestClass]
    public class UserClaimsTest : TestBase
    {
        /*
        ----------------------------------------------------------
        |                         Claims                         |
        ----------------------------------------------------------
        |                 ID                  |      NAME        |
        |b6f7d109-e08f-4341-ae29-84e9b63708cb |Claim1            |
        |d328b6af-6399-4fe0-992e-fa52965b21fd |RoleTest2         |
        ----------------------------------------------------------
        */

        [TestMethod]
        public void TestAdd()
        {
            // b6f7d109-e08f-4341-ae29-84e9b63708cb - Claim
            // 305c5c47-1b83-4ccb-8c51-21a04e8cde98 - User
            var service = GetService<IUserClaimsService>();
            service.Add(new UserClaimsEntity
            {
                UserId = "305c5c47-1b83-4ccb-8c51-21a04e8cde98",
                ClaimType = "Admin",
                ClaimValue = "True"
            });
        }

        [TestMethod]
        public void TestGetAll()
        {
            var service = GetService<IUserClaimsService>();
            var result = service.GetAll();

            Assert.IsTrue(result.Count() > 0);
        }
    }
}