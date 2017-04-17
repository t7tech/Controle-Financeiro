using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace T7.ControleFinanceiro.UI.Areas.OAuth.Controllers
{
    public class LogoffController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            AuthenticationManager.SignOut();
            return Redirect("/home");
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