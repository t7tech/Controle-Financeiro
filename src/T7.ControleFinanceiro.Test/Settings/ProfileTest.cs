using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings;

namespace T7.ControleFinanceiro.Test.Settings
{
    [TestClass]
    public class ProfileTest : TestBase
    {
        [TestMethod]
        public void GetById()
        {
            var service = GetService<IProfileService>();
            var user = service.GetById("d4527607-23ef-4eb7-b428-4bcc933c22dd");

            Assert.AreNotEqual(user, null);
        }

        [TestMethod]
        public void Update()
        {
            var service = GetService<IProfileService>();
            var entity = new UpdateProfileEntity
            {
                Id = "d4527607-23ef-4eb7-b428-4bcc933c22dd",
                Name = "Julio Cesar",
                LastName = "Lima Tamogami",
                DateBirth = new DateTime(1987, 01, 23)
            };

            service.Update(entity);

            var user = service.GetById("d4527607-23ef-4eb7-b428-4bcc933c22dd");
        }
    }
}