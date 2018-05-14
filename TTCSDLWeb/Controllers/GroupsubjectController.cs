using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDLWeb.Models.BUS;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Controllers
{
    public class GroupsubjectController : Controller
    {
        // GET: Groupsubject
        IsSession ses = new IsSession();

        public ActionResult Index()
        {

            List<Groupsubject> listGroupsubject = GroupsubjectBUS.Instance.GetList();
            return View(listGroupsubject);
        }

        public ActionResult MangagerGroupsubject()
        {
            if (ses.isLogin() == -1)
            {
                return RedirectToAction("Login", "Home");
            }
            List<Groupsubject> listGroupsubject = GroupsubjectBUS.Instance.GetList();
            return View(listGroupsubject);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Groupsubject groupsubject)
        {
            GroupsubjectBUS.Instance.Add(groupsubject.code, groupsubject.name);
            return RedirectToAction("MangagerGroupsubject", "Groupsubject");
        }


        public ActionResult Edit(string code)
        {
            List<Groupsubject> listGroupsubject = GroupsubjectBUS.Instance.GetList();
            var groupsubject = listGroupsubject.Where(x => x.code == code).FirstOrDefault();
            return View(groupsubject);
        }

        [HttpPost]
        public ActionResult Edit(Groupsubject groupsubject)
        {
            GroupsubjectBUS.Instance.Edit(groupsubject.code, groupsubject.name);
            return RedirectToAction("MangagerGroupsubject", "Groupsubject");
        }

        public ActionResult Delete(string code)
        {
            GroupsubjectBUS.Instance.Delete(code);
            return RedirectToAction("MangagerGroupsubject", "Groupsubject");
        }

        [CustomAuthentication]
        public ActionResult GroupsubjectReact()
        {
            return View();
        }
    }
}