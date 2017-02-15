using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using T7.ControleFinanceiro.Core.Validation;
using T7.ControleFinanceiro.Core.Formatter;

namespace T7.ControleFinanceiro.Service.Account
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
            /***** Validation *****/
            AssertionConcern.AssertArgumentNotNull(entity, "As informações inseridas são inválidas");
            AssertionConcern.AssertArgumentNotEmpty(entity.Email, "Informe seu e-mail");
            AssertionConcern.AssertArgumentNotEmpty(entity.Name, "Informe seu nome");
            AssertionConcern.AssertArgumentNotEmpty(entity.LastName, "Informe seu sobrenome");
            AssertionConcern.AssertArgumentNotNull(entity.DateBirth, "Informe sua data de nascimento");
            AssertionConcern.AssertArgumentNotNull(entity.Password, "Informe sua senha");

            var user = new ApplicationUser
            {
                UserName = entity.Email,
                Email = entity.Email,
                Name = entity.Name,
                LastName = entity.LastName,
                DateBirth = entity.DateBirth
            };

            var result = await _userManager.CreateAsync(user, entity.Password);
            if (result.Succeeded)
            {
                // await _signInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user.Id);
                await _userManager.SendEmailAsync(user.Id, "Confirme sua Conta", EmailFormatter.GetEmailConfirm(code));
            }
        }

        #endregion
    }
}