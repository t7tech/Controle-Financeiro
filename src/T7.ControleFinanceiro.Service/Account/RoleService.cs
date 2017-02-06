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

        public RoleEntity GetById(string id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<RoleEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void UpdateName(string id, string name)
        {
            _repository.UpdateName(id, name);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public void Add(RoleEntity entity)
        {
            _repository.Add(entity);
        }

        #endregion
    }
}