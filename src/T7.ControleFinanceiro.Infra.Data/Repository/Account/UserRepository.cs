using System;
using System.Linq;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account
{
    public class UserRepository : IUserRepository
    {
        #region Attributes

        private readonly IdentityIsolationContext _db;

        #endregion

        #region Ctor

        public UserRepository()
        {
            _db = new IdentityIsolationContext();
        }

        #endregion

        #region Methods

        public UserEntity GetById(string id)
        {
            return _db.User.Find(id);
        }

        public IEnumerable<UserEntity> GetAll()
        {
            return _db.User.ToList();
        }

        public void DisableLock(string id)
        {
            _db.User.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db.Database.Connection.State != System.Data.ConnectionState.Closed)
                _db.Database.Connection.Close();

            _db.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}