using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Repository.Account
{
    public interface IRoleRepository : IDisposable
    {
        RoleEntity GetById(string id);
        IEnumerable<RoleEntity> GetAll();
        void UpdateName(string id, string name);
        void Delete(string id);
        void Add(RoleEntity entity);
    }
}