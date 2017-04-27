using System.Web.Mvc;
using T7.ControleFinanceiro.Core.Web;
using T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings;

namespace T7.ControleFinanceiro.UI.Areas.Account.Controllers
{
    public class SettingsController : BaseController
    {
        #region Attibutes

        private IProfileService _profileService;

        #endregion

        #region Ctor

        public SettingsController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var profile = _profileService.GetById(UserId);

            return View(profile);
        }

        #endregion
    }
}