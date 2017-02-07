using System;
using System.Linq;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account
{
    public class RoleRepository : IRoleRepository
    {
        #region Attributes

        private readonly IdentityDbContext _db;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        public RoleRepository()
        {
            _db = new IdentityDbContext();
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
            return _db.Role.FirstOrDefault(f => f.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleEntity> GetAll()
        {
            return _db.Role.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(RoleEntity entity)
        {
            _db.Role.Add(entity);
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void UpdateName(string id, string name)
        {
            _db.Role.Find(id).Name = name;
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            var role = _db.Role.Find(id);
            _db.Role.Remove(role);
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if (_db.Database.Connection.State != System.Data.ConnectionState.Closed)
                _db.Database.Connection.Close();

            _db.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}