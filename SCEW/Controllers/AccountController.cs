using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCEW.Models;
using SCEW.Models.DB;
using SCEW.Util;

namespace SCEW.Controllers
{
    public class AccountController : Controller
    {
        private SCEWEntities DataContext = new SCEWEntities();

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        public ActionResult Login()
        {
            ViewData["Message"] = "Your Login page.";
            return View();
        }
        public ActionResult LoginUser(UserViewModel model)
        {
            JsonResponseData retObj = new JsonResponseData();
            SCEW_Utitlity erpUtil = new SCEW_Utitlity();
            var encryptPswd = erpUtil.Encrypt(model.Password);
            //var employee = _userData.GetUserByEmailPswd(model.Email, encryptPswd);
            var employee = DataContext.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
            if (employee != null)
            {
                HttpContext.Session[AppConstants.SessionKey.CURRENT_USER] = employee;
                //var listRolesAndRights = await _rolesandrightsMasterData.GetRolesAndRightsByRoleId(employee.RoleId);
                var listRolesAndRights = DataContext.RolesAndRightsMasters.Where(r => r.RoleId == employee.RoleId).ToList();

                HttpContext.Session[AppConstants.SessionKey.CURRENT_USER_RIGHTS] = listRolesAndRights;
                retObj.IsError = false;
            }
            else
            {
                retObj.IsError = true;
            }
            //return Json(retObj);
            return RedirectToAction("Dashboard", "Admin");
        }
    }
}