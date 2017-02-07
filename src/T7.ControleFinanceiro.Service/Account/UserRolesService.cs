using System.Collections.Generic;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Service.Account
{
    public class UserRolesService : IUserRolesService
    {
        #region Attributes

        private IUserRolesRepository _repository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        public UserRolesService(IUserRolesRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRole"></param>
        /// <returns></returns>
        public IEnumerable<UserEntity> UsersInRole(string idRole)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(idRole, "Código de regra inválido");

            return _repository.UsersInRole(idRole);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRole"></param>
        /// <param name="idUser"></param>
        public void AddUserInRole(string idRole, string idUser)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(idRole, "Código de regra inválido");
            AssertionConcern.AssertArgumentNotEmpty(idUser, "Código de usuário inválido");

            _repository.AddUserInRole(idRole, idUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRole"></param>
        /// <param name="idUser"></param>
        public void RemoveUserInRole(string idRole, string idUser)
        {
            /* Validações */
            AssertionConcern.AssertArgumentNotEmpty(idRole, "Código de regra inválido");
            AssertionConcern.AssertArgumentNotEmpty(idUser, "Código de usuário inválido");

            _repository.RemoveUserInRole(idRole, idUser);
        }

        #endregion
    }
}