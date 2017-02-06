using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Service.Account
{
    public interface IRoleService
    {
        RoleEntity GetById(string id);
        IEnumerable<RoleEntity> GetAll();
        void UpdateName(string id, string name);
        void Delete(string id);
        void Add(RoleEntity entity);
    }
}