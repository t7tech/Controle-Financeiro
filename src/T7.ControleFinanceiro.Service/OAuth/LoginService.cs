using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Domain.Entities.OAuth;
using T7.ControleFinanceiro.Domain.Interface.Service.OAuth;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;

namespace T7.ControleFinanceiro.Service.OAuth
{
    public class LoginService : ILoginService
    {
        #region Attributes

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public LoginService(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #endregion

        public async Task<LoginStatus> Validate(LoginEntity entity)
        {
            /*
             * Validation
             */
            AssertionConcern.AssertArgumentNotNull(entity, "Login ou Senha incorretos.");
            AssertionConcern.AssertArgumentNotEmpty(entity.Email, "Login ou Senha incorretos.");
            AssertionConcern.AssertArgumentNotEmpty(entity.Password, "Login ou Senha incorretos.");

            ///*
            // * Validate Login
            // */
            //return (LoginStatus)await _signInManager.PasswordSignInAsync(entity.Email, entity.Password, entity.RememberMe, shouldLockout: true);

            return LoginStatus.Success;
        }
    }
}