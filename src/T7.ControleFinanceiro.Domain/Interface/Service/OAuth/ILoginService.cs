using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.OAuth;

namespace T7.ControleFinanceiro.Domain.Interface.Service.OAuth
{
    public interface ILoginService
    {
        Task<LoginStatus> Validate(LoginEntity entity);
    }
}