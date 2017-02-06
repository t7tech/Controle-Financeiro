using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Domain.Interface.Repository
{
    public interface IUserRepository : IDisposable
    {
        UserEntity ObterPorId(string id);
        IEnumerable<UserEntity> ObterTodos();
        void DesativarLock(string id);
    }
}