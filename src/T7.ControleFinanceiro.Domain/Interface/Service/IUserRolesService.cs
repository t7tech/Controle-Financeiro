using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Domain.Interface.Service
{
    public interface IUserRolesService
    {
        IEnumerable<UserEntity> UsersInRole(string idRole);
    }
}