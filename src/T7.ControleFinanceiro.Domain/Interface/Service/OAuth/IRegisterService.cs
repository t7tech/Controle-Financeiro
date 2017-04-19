using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.OAuth;

namespace T7.ControleFinanceiro.Domain.Interface.Service.OAuth
{
    public interface IRegisterService
    {
        Task Add(RegisterEntity entity);
        Task ConfirmEmail(string userId, string code);
        Task<bool> CheckEmail(string email);
    }
}