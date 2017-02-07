using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Service.Account
{
    public interface IUserClaimsService
    {
        void Add(UserClaimsEntity entity);
        UserClaimsEntity GetById(int id);
        IEnumerable<UserClaimsEntity> GetAll();
    }
}