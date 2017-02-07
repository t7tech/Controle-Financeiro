using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Repository.Account
{
    public interface IUserClaimsRepository : IDisposable
    {
        void Add(UserClaimsEntity entity);
        UserClaimsEntity GetById(int id);
        IEnumerable<UserClaimsEntity> GetAll();
    }
}