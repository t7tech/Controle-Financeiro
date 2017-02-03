using System;
using System.Collections.Generic;
using System.Linq;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Domain.Interface.Repository;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IdentityIsolationContext _db;

        public UserRepository()
        {
            _db = new IdentityIsolationContext();
        }

        public UserEntity ObterPorId(string id)
        {
            return _db.User.Find(id);
        }

        public IEnumerable<UserEntity> ObterTodos()
        {
            return _db.User.ToList();
        }
        public void DesativarLock(string id)
        {
            _db.User.Find(id).LockoutEnabled = false;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}