using System.Text;

namespace T7.ControleFinanceiro.Core.Formatter
{
    public static class EmailFormatter
    {
        public static string GetEmailAccountConfirm(string userId, string code)
        {
            return new StringBuilder()
                    .AppendFormat("Por favor confirme sua conta clicando neste link: <a href='http://localhost:18255/account/register/confirm/?u={0}&c={1}'>Confirmar</a>", userId, code)
                    .ToString();
        }
    }
}