using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Domain.Interface.Repository;
using T7.ControleFinanceiro.Domain.Interface.Service;

namespace T7.ControleFinanceiro.Service
{
    public class RoleService : IRoleService
    {
        #region Attributes

        private IRoleRepository _repository;

        #endregion

        #region Ctor

        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        public RoleEntity ObterPorId(string id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<RoleEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void UpdateName(string id, string name)
        {
            _repository.UpdateName(id, name);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        #endregion
    }
}