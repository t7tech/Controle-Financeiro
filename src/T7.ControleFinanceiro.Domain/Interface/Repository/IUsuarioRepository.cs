using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Domain.Interface.Repository
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
    }
}