using System;
using System.Linq;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Infra.Data.Context;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account
{
    public class ClaimRepository : IClaimRepository
    {
        #region Attributes

        private readonly IdentityIsolationContext _db;

        #endregion

        #region Ctor

        public ClaimRepository()
        {
            _db = new IdentityIsolationContext();
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(ClaimsEntity entity)
        {
            _db.Claims.Add(entity);
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            var claim = _db.Claims.FirstOrDefault(f => f.Id == id);
            if (claim != null)
            {
                _db.Claims.Remove(claim);
                _db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void Update(string id, string name)
        {
            var claim = _db.Claims.FirstOrDefault(f => f.Id == id);
            if (claim != null)
            {
                claim.Name = name;

                _db.Entry<ClaimsEntity>(claim).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClaimsEntity GetById(string id)
        {
            return _db.Claims.FirstOrDefault(f => f.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClaimsEntity> GetAll()
        {
            return _db.Claims.ToList();
        }

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