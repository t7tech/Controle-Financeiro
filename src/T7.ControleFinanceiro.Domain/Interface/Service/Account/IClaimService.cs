using System.Collections.Generic;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Service.Account
{
    public interface IClaimService
    {
        void Add(ClaimsEntity entity);
        void Delete(string id);
        void Update(string id, string name);
        ClaimsEntity GetById(string id);
        IEnumerable<ClaimsEntity> GetAll();
    }
}