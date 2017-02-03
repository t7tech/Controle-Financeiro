using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Domain.Interface.Repository;
using T7.ControleFinanceiro.Domain.Interface.Service;

namespace T7.ControleFinanceiro.Service
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

        #endregion
    }
}