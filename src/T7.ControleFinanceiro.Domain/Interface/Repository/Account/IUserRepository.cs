using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Repository.Account
{
    public interface IUserRepository : IDisposable
    {
        UserEntity GetById(string id);
        IEnumerable<UserEntity> GetAll();
        void DisableLock(string id);
    }
}