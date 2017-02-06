using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7.ControleFinanceiro.Domain.Entities
{
    public class RoleEntity
    {
        public RoleEntity()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}