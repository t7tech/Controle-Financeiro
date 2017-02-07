using System;
using System.Linq;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account
{
    public class UserRolesRepository : IUserRolesRepository
    {
        #region Attributes

        private readonly IdentityIsolationContext _db;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        public UserRolesRepository()
        {
            _db = new IdentityIsolationContext();
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRole"></param>
        /// <returns></returns>
        public IEnumerable<UserEntity> UsersInRole(string idRole)
        {
            return _db.UserRoles
                      .Join(_db.User, role => role.UserId, user => user.Id, (a, b) => new { Roles = a, Users = b })
                      .Where(w => w.Roles.RoleId == idRole)
                      .Select(s => s.Users)
                      .ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRole"></param>
        /// <param name="idUser"></param>
        public void AddUserInRole(string idRole, string idUser)
        {
            var userRole = new UserRolesEntity
            {
                RoleId = idRole,
                UserId = idUser
            };

            _db.UserRoles.Add(userRole);
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRole"></param>
        /// <param name="idUser"></param>
        public void RemoveUserInRole(string idRole, string idUser)
        {
            var userRole = _db.UserRoles.Find(idRole, idUser);
            if (userRole != null)
            {
                _db.UserRoles.Remove(userRole);
                _db.SaveChanges();
            }
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