using System.Collections.Generic;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Service.Account
{
    public class UserService : IUserService
    {
        #region Attributes

        private IUserRepository _repository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        public UserService(IUserRepository repository)
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
        public UserEntity GetById(string id)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(id, "Código de usuário inválido");

            return _repository.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetByRole(string role)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(role, "Código de regra inválido");

            return _repository.GetByRole(role);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetAll()
        {
            return _repository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DisableLock(string id)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(id, "Código de usuário inválido");

            _repository.DisableLock(id);
        }

        #endregion
    }
}