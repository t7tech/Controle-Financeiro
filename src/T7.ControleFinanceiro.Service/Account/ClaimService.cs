using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;

namespace T7.ControleFinanceiro.Service.Account
{
    public class ClaimService : IClaimService
    {
        #region Attributes

        private IClaimRepository _repository;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public ClaimService(IClaimRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(ClaimsEntity entity)
        {
            _repository.Add(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void Update(string id, string name)
        {
            _repository.Update(id, name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClaimsEntity GetById(string id)
        {
            return _repository.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClaimsEntity> GetAll()
        {
            return _repository.GetAll();
        }

        #endregion
    }
}