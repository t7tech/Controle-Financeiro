using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Service.Account
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public UserEntity GetById(string id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<UserEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void DisableLock(string id)
        {
            _repository.DisableLock(id);
        }
    }
}