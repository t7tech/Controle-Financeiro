using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace T7.ControleFinanceiro.Core.Web
{
    public abstract class BaseApiController : ApiController
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