using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace T7.ControleFinanceiro.Core.Security
{
    public class ClaimsAuthorizeAttribute : AuthorizeAttribute
    {
        string type;
        string value;

        public ClaimsAuthorizeAttribute(string type, string value)
        {
            this.type = type;
            this.value = value;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var user = filterContext.HttpContext.User as ClaimsPrincipal;
            if (user.HasClaim(type, value))
            {
                base.OnAuthorization(filterContext);
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}