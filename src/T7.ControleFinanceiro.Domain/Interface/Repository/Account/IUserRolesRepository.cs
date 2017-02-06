using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Repository.Account
{
    public interface IUserRolesRepository : IDisposable
    {
        IEnumerable<UserEntity> UsersInRole(string idRole);
        void AddUserInRole(string idRole, string idUser);
        void RemoveUserInRole(string idRole, string idUser);
    }
}