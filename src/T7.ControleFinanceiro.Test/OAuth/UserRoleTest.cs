using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Test.OAuth
{
    [TestClass]
    public class UserRoleTest : TestBase
    {
        [TestMethod]
        public void TestUsersInRole()
        {
            /*
                ----------------------------------------------------------
                |                       ROLES                            |
                ----------------------------------------------------------
                |                 ID                  |      NAME        |
                |113ddf03-e273-4326-96b3-7b5e9528febb |Admin1            |
                |d328b6af-6399-4fe0-992e-fa52965b21fd |RoleTest2         |
                ----------------------------------------------------------
             */

            var service = GetService<IUserRolesService>();
            var result = service.UsersInRole("113ddf03-e273-4326-96b3-7b5e9528febb");

            Assert.AreEqual(result.Count(), 0);
        }

        [TestMethod]
        public void AddUserInRole()
        {

        }

        [TestMethod]
        public void RemoveUserInRole()
        {

        }
    }
}