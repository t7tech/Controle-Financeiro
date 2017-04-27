using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;

namespace T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings
{
    public interface IProfileService
    {
        UpdateProfileEntity GetById(string id);
        void Update(UpdateProfileEntity entity);
    }
}