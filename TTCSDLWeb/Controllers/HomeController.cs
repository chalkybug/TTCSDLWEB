using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Controllers
{
    public class HomeController : Controller
    {

        IsSession ses = new IsSession();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        public ActionResult doLogin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("123"))
            {
                ses.login();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "Home");
        }

        public JsonResult GetName()
        {
            return Json(new { name = "World from server side" }, JsonRequestBehavior.AllowGet);
        }

    }
}