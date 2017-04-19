using System.Collections.Generic;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.OAuth;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Service.Account
{
    public class RoleService : IRoleService
    {
        #region Attributes

        private IRoleRepository _repository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RoleEntity GetById(string id)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(id, "Código de regra inválido");

            return _repository.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleEntity> GetAll()
        {
            return _repository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateName(string id, string name)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(id, "Código de regra inválido");
            AssertionConcern.AssertArgumentNotEmpty(name, "Nome da regra inválido");

            _repository.UpdateName(id, name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(id, "Código de regra inválido");

            _repository.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(RoleEntity entity)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotNull(entity, "Dados da regra inválido");
            AssertionConcern.AssertArgumentNotEmpty(entity.Id, "Código de regra inválido");
            AssertionConcern.AssertArgumentNotEmpty(entity.Name, "Nome da regra inválido");

            _repository.Add(entity);
        }

        #endregion
    }
}