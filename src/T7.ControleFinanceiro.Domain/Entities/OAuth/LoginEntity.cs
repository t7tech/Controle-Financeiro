
namespace T7.ControleFinanceiro.Domain.Entities.OAuth
{
    public class LoginEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}