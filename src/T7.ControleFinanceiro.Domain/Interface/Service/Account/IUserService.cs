using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Domain.Interface.Service
{
    public interface IUserService
    {
        UserEntity ObterPorId(string id);
        IEnumerable<UserEntity> ObterTodos();
        void DesativarLock(string id);
    }
}