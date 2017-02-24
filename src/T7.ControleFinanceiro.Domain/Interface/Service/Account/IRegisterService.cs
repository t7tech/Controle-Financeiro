using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Domain.Interface.Service.Account
{
    public interface IRegisterService
    {
        Task Add(RegisterEntity entity);
        Task ConfirmEmail(string userId, string code);
    }
}