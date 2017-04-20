using System;
using System.Data.Entity;
using System.Linq;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account.Settings;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account.Settings
{
    public class ProfileRepository : IProfileRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity GetById(string id)
        {
            using (var context = new IdentityDbContext())
            {
                return context.User.FirstOrDefault(f => f.Id == id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(UpdateProfileEntity entity)
        {
            using (var context = new IdentityDbContext())
            {
                var user = context.User.FirstOrDefault(f => f.Id == entity.Id);
                if (user != null)
                {
                    user.Name = entity.Name;
                    user.LastName = entity.LastName;
                    user.DateBirth = entity.DateBirth;
                    user.EmailOptional = entity.Email;

                    context.Entry<UserEntity>(user).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
    }
}