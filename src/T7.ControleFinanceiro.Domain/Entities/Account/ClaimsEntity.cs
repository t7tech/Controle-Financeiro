using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7.ControleFinanceiro.Domain.Entities.Account
{
    public class ClaimsEntity
    {
        public ClaimsEntity()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}