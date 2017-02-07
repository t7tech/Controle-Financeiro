using System;
using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Service.Account
{
    public class UserClaimsService : IUserClaimsService
    {
        #region Attributes

        private IUserClaimsRepository _repository;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public UserClaimsService(IUserClaimsRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(UserClaimsEntity entity)
        {
            _repository.Add(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserClaimsEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserClaimsEntity> GetAll()
        {
            return _repository.GetAll();
        }

        #endregion
    }
}