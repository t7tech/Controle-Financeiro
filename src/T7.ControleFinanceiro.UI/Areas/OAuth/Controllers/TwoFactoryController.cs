using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;

namespace T7.ControleFinanceiro.UI.Areas.OAuth.Controllers
{
    public class TwoFactoryController : Controller
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
        public TwoFactoryController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public async Task<ActionResult> SendCode(string u, bool r)
        {
            try
            {
                /*
                 * Check if User Exists
                 */
                var userId = await _signInManager.GetVerifiedUserIdAsync();
                if (userId == null)
                    return View("Error");

                /*
                 * Generate TwoFactory Code
                 */
                var userFactors = await _userManager.GetValidTwoFactorProvidersAsync(userId);
                var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();

                return View(new SendCodeViewModel
                {
                    Providers = factorOptions,
                    ReturnUrl = u,
                    RememberMe = r
                });
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!await _signInManager.SendTwoFactorCodeAsync(model.SelectedProvider))
            {
                return View("Error");
            }

            return RedirectToAction("VerifyCode", new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        #endregion
    }
}