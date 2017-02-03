using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Domain.Interface.Repository;
using T7.ControleFinanceiro.Domain.Interface.Service;

namespace T7.ControleFinanceiro.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public UserEntity ObterPorId(string id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<UserEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void DesativarLock(string id)
        {
            _repository.DesativarLock(id);
        }
    }
}