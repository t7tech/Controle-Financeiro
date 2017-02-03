using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Domain.Interface.Repository;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository
{
    public class RoleRepository : IRoleRepository
    {
        #region Attributes

        private readonly IdentityIsolationContext _db;

        #endregion

        #region Ctor

        public RoleRepository()
        {
            _db = new IdentityIsolationContext();
        }

        #endregion

        #region Methods

        public RoleEntity ObterPorId(string id)
        {
            return _db.Role.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<RoleEntity> ObterTodos()
        {
            return _db.Role.ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}