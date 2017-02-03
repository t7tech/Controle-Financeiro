using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Domain.Interface.Repository
{
    public interface IUserRolesRepository : IDisposable
    {
        IEnumerable<UserEntity> UsersInRole(string idRole);
    }
}