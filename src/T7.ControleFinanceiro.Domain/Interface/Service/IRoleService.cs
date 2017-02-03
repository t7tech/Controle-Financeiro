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
        RoleEntity ObterPorId(string id);
        IEnumerable<RoleEntity> ObterTodos();
        void UpdateName(string id, string name);
        void Delete(string id);
    }
}