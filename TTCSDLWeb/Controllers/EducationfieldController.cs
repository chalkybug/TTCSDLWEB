using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDLWeb.Models.BUS;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Controllers
{
    public class EducationfieldController : Controller
    {
        // GET: Educationfield
        IsSession ses = new IsSession();

        public ActionResult Index()
        {

            List<Educationfield> listEducationfield = EducationfieldBUS.Instance.GetList();
            return View(listEducationfield);
        }

        public ActionResult MangagerEducationfield()
        {
            if (ses.isLogin() == -1)
            {
                return RedirectToAction("Login", "Home");
            }
            List<Educationfield> listEducationfield = EducationfieldBUS.Instance.GetList();
            return View(listEducationfield);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Educationfield educationfield)
        {
            EducationfieldBUS.Instance.Add(educationfield.code, educationfield.name, educationfield.facultycode);
            return RedirectToAction("MangagerEducationfield", "Educationfield");
        }


        public ActionResult Edit(string code)
        {
            List<Educationfield> listEducationfield = EducationfieldBUS.Instance.GetList();
            var educationfield = listEducationfield.Where(x => x.code == code).FirstOrDefault();
            return View(educationfield);
        }

        [HttpPost]
        public ActionResult Edit(Educationfield educationfield)
        {
            EducationfieldBUS.Instance.Edit(educationfield.code, educationfield.name, educationfield.facultycode);
            return RedirectToAction("MangagerEducationfield", "Educationfield");
        }

        public ActionResult Delete(string code)
        {
            EducationfieldBUS.Instance.Delete(code);
            return RedirectToAction("MangagerEducationfield", "Educationfield");
        }

        [CustomAuthentication]
        public ActionResult EducationfieldReact()
        {
            return View();
        }
    }
}