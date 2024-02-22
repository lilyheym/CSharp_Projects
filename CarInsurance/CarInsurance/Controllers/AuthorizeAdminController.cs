using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AuthorizeAdminController : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["AdminLoggedIn"] == null)
            {
                filterContext.Result = new RedirectResult("/Insuree/AdminLogin");
            }

            base.OnActionExecuted(filterContext);
        }
    }
}