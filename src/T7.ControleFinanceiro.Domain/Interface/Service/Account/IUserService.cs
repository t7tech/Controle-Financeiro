using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Service.Account
{
    public interface IUserService
    {
        UserEntity GetById(string id);
        IEnumerable<UserEntity> GetAll();
        void DisableLock(string id);
    }
}