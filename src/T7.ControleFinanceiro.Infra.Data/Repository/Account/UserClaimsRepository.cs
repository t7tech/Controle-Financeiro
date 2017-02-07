using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Infra.Data.Context;

namespace T7.ControleFinanceiro.Infra.Data.Repository.Account
{
    public class UserClaimsRepository : IUserClaimsRepository
    {
        #region Attributes

        private readonly IdentityDbContext _db;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        public UserClaimsRepository()
        {
            _db = new IdentityDbContext();
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(UserClaimsEntity entity)
        {
            _db.UserClaims.Add(entity);
            _db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserClaimsEntity GetById(int id)
        {
            return _db.UserClaims.FirstOrDefault(f => f.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<UserClaimsEntity> GetAll()
        {
            return _db.UserClaims.ToList();
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