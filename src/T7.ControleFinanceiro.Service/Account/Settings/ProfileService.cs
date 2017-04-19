using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings;

namespace T7.ControleFinanceiro.Service.Account.Settings
{
    public class ProfileService : IProfileService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(UpdateProfileEntity entity)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotNull(entity, "As informações inseridas são inválidas");
            AssertionConcern.AssertArgumentNotEmpty(entity.Email, "Informe seu e-mail");
            AssertionConcern.AssertArgumentNotEmpty(entity.Name, "Informe seu nome");
            AssertionConcern.AssertArgumentNotEmpty(entity.LastName, "Informe seu sobrenome");
            AssertionConcern.AssertArgumentNotNull(entity.DateBirth, "Informe sua data de nascimento");
        }
    }
}