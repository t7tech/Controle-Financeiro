using T7.ControleFinanceiro.Domain.Entities.Account.Settings;

namespace T7.ControleFinanceiro.Domain.Interface.Repository.Account.Settings
{
    public interface IProfileRepository
    {
        void Update(UpdateProfileEntity entity);
    }
}