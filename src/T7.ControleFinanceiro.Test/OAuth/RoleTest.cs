using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Test.OAuth
{
    [TestClass]
    public class RoleTest : TestBase
    {
        /*
        ----------------------------------------------------------
        |                         Roles                          |
        ----------------------------------------------------------
        |                 ID                  |      NAME        |
        |113ddf03-e273-4326-96b3-7b5e9528febb |Admin1            |
        |d328b6af-6399-4fe0-992e-fa52965b21fd |RoleTest2         |
        ----------------------------------------------------------
        */

        [TestMethod]
        public void TestAdd()
        {
            var service = GetService<IRoleService>();
            service.Add(new RoleEntity
            {
                Name = "RoleTest2"
            });
        }

        [TestMethod]
        public void TestGetAll()
        {
            var service = GetService<IRoleService>();
            var result = service.GetAll();

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void TestGetById()
        {
            var service = GetService<IRoleService>();
            var result = service.GetById("113ddf03-e273-4326-96b3-7b5e9528febb");

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void TestUpdateName()
        {
            var service = GetService<IRoleService>();
            service.UpdateName("113ddf03-e273-4326-96b3-7b5e9528febb", "Admin1");
        }
    }
}