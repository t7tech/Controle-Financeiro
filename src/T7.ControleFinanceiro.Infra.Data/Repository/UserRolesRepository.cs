﻿using System;
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

        #region Methods

        public IEnumerable<UserEntity> UsersInRole(string idRole)
        {
            return _db.UserRoles
                      .Join(_db.User, role => role.UserId, user => user.Id, (a, b) => new { Roles = a, Users = b })
                      .Where(w => w.Roles.RoleId == idRole)
                      .Select(s => s.Users)
                      .ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}