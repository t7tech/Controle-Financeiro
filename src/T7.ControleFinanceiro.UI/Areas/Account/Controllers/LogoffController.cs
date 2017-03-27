using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace T7.ControleFinanceiro.UI.Areas.Account.Controllers
{
    public class LogoffController : Controller
    {
        [HttpGet]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("index", "home");
        }

        #region Helpers

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        #endregion
    }
}