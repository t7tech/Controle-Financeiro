using System.Security.Claims;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Core.Configuration;
using T7.ControleFinanceiro.Core.Error;
using T7.ControleFinanceiro.Core.Formatter;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.OAuth;
using T7.ControleFinanceiro.Domain.Interface.Service.OAuth;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;

namespace T7.ControleFinanceiro.Service.OAuth
{
    public class RegisterService : IRegisterService
    {
        #region Attributes

        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public RegisterService(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public async Task Add(RegisterEntity entity)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotNull(entity, "As informações inseridas são inválidas");
            AssertionConcern.AssertArgumentNotEmpty(entity.Email, "Informe seu e-mail");
            AssertionConcern.AssertArgumentNotEmpty(entity.Name, "Informe seu nome");
            AssertionConcern.AssertArgumentNotEmpty(entity.LastName, "Informe seu sobrenome");
            AssertionConcern.AssertArgumentNotNull(entity.DateBirth, "Informe sua data de nascimento");
            AssertionConcern.AssertArgumentNotNull(entity.Password, "Informe sua senha");

            var user = new ApplicationUser
            {
                UserName = entity.Email,
                //Email = entity.Email,
                Name = entity.Name,
                LastName = entity.LastName,
                DateBirth = entity.DateBirth
            };

            /*
             * Create Account
             */
            var result = await _userManager.CreateAsync(user, entity.Password);
            if (!result.Succeeded)
                throw new CustomException("Não foi possível finalizar seu cadastro");

            /*
             * Generate Confirm Code
             */
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user.Id);

            /*
             * Send E-mail Confirm
             */
            await _userManager.SendEmailAsync(user.Id, "Confirme sua Conta", EmailFormatter.GetEmailAccountConfirm(user.Id, code));

            /*
             * Add UserClaim
             */
            await _userManager.AddClaimAsync(user.Id, new Claim(AppConfig.Get().DefaultClaimType, AppConfig.Get().DefaultClaimValue));

            /*
             * Login on System
             */
            await _signInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task ConfirmEmail(string userId, string code)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotNull(userId, "Não foi possível confirmar seu cadastro");
            AssertionConcern.AssertArgumentNotNull(code, "Não foi possível confirmar seu cadastro");

            /*
             * Validate Account
             */
            await _userManager.ConfirmEmailAsync(userId, code);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> CheckEmail(string email)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotNull(email, "Não foi possível validar o e-mail");

            /*
             * Check E-mail
             */
            var result = await _userManager.FindByNameAsync(email);
            return result == null;
        }

        #endregion
    }
}