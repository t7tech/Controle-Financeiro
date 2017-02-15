using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7.ControleFinanceiro.Core.Formatter
{
    public static class EmailFormatter
    {
        public static string GetEmailConfirm(string code)
        {
            var content = new StringBuilder();

            content.AppendFormat("Por favor confirme sua conta clicando neste link: <a href='http://www.site.com.br/account/confirm/?c={0}'></a>", code);

            return content.ToString();
        }
    }
}