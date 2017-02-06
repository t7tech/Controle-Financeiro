using System.Collections.Generic;
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

        public UserRolesService(IUserRolesRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        public IEnumerable<UserEntity> UsersInRole(string idRole)
        {
            return _repository.UsersInRole(idRole);
        }

        public void AddUserInRole(string idRole, string idUser)
        {
            _repository.AddUserInRole(idRole, idUser);
        }

        public void RemoveUserInRole(string idRole, string idUser)
        {
            _repository.RemoveUserInRole(idRole, idUser);
        }

        #endregion
    }
}