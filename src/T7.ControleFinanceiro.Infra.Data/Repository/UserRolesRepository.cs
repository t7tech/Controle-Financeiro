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
    public class UserRolesRepository : IUserRolesRepository
    {
        #region Attributes

        private readonly IdentityIsolationContext _db;

        #endregion

        #region Ctor

        public UserRolesRepository()
        {
            _db = new IdentityIsolationContext();
        }

        #endregion

        public IEnumerable<UserEntity> UsersInRole(string idRole)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}