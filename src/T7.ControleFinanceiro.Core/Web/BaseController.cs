using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace T7.ControleFinanceiro.Core.Web
{
    public abstract class BaseController : Controller
    {
        #region Attributes

        protected string UserId
        {
            get
            {
                return User.Identity.GetUserId();
            }
        }

        #endregion
    }
}