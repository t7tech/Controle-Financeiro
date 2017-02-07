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

        /// <summary>
        /// 
        /// </summary>
        public UserRepository()
        {
            _db = new IdentityIsolationContext();
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEntity GetById(string id)
        {
            return _db.User.Find(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetByRole(string role)
        {
            return _db.UserRoles
                      .Join(_db.User, userRole => userRole.UserId, user => user.Id, (a, b) => new { Role = a, User = b })
                      .Where(w => w.Role.RoleId == role)
                      .Select(s => s.User)
                      .ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetAll()
        {
            return _db.User.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DisableLock(string id)
        {
            _db.User.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
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