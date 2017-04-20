using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;

namespace T7.ControleFinanceiro.Domain.Interface.Repository.Account.Settings
{
    public interface IProfileRepository
    {
        UserEntity GetById(string id);
        void Update(UpdateProfileEntity entity);
    }
}