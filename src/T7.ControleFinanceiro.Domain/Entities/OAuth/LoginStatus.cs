
namespace T7.ControleFinanceiro.Domain.Entities.OAuth
{
    public enum LoginStatus
    {
        Success = 0,
        LockedOut = 1,
        RequiresVerification = 2,
        Failure = 3,
    }
}