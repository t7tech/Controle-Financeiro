using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7.ControleFinanceiro.Core.Error
{
    public class CustomException:Exception
    {
        public CustomException(string message) : base(message) { }
    }
}