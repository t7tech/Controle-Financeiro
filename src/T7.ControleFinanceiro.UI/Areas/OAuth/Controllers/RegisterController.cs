using System.Web.Mvc;
using T7.ControleFinanceiro.Domain.Entities.OAuth;

namespace T7.ControleFinanceiro.UI.Areas.OAuth.Controllers
{
    public class RegisterController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult Confirm(string u, string c)
        {
            var model = new ConfirmEmailEntity
            {
                UserId = u,
                Code = c
            };

            return View(model);
        }
    }
}