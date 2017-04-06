using System.Web.Mvc;
using T7.ControleFinanceiro.Core.Web;

namespace T7.ControleFinanceiro.UI.Areas.OAuth.Controllers
{
    public class LoginController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}