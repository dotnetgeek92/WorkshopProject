using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCEW.Models.DB;
using SCEW.Util;

namespace SCEW.Controllers
{
    public class AdminBaseController : Controller
    {
        protected SCEWEntities DataContext = new SCEWEntities();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            

            //var sessionEmployee = HttpContext.Session.GetObject<EmployeeMasterDto>(AppConstants.SessionKey.CURRENT_USER);
            Controller controller = filterContext.Controller as Controller;
            if (controller != null)
            {
                if (HttpContext.Session[AppConstants.SessionKey.CURRENT_USER] == null)
                {
                    filterContext.Result = new RedirectResult("/Account/Login");
                }
                if (HttpContext.Session[AppConstants.SessionKey.CURRENT_USER] != null)
                {
                    
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}