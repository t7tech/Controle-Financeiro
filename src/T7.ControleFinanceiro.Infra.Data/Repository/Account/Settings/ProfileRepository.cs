using System;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account.Settings;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account.Settings
{
    public class ProfileRepository : IProfileRepository
    {
        public void Update(UpdateProfileEntity entity)
        {
            using (var context = new IdentityDbContext())
            {
                
            }
        }
    }
}