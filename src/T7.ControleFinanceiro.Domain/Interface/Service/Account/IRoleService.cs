using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Domain.Interface.Service
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