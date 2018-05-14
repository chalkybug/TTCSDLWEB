using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDLWeb.Models.BUS;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        IsSession ses = new IsSession();

        public ActionResult Index()
        {

            List<Subject> listSubject = SubjectBUS.Instance.GetList();
            return View(listSubject);
        }
        
        public ActionResult MangagerSubject()
        {
            if (ses.isLogin() == -1)
            {
                return RedirectToAction("Login", "Home");
            }
            List<Subject> listSubject = SubjectBUS.Instance.GetList();
            return View(listSubject);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            SubjectBUS.Instance.Add(subject.code, subject.codeview, subject.name, subject.numberofcredit, subject.numberoflesson, subject.numberoftheory, subject.numberofexercise, subject.numberofdiscussion, subject.numberofpractive, subject.examform);
            return RedirectToAction("MangagerSubject", "Subject");
        }


        public ActionResult Edit(string code)
        {
            List<Subject> listSubject = SubjectBUS.Instance.GetList();
            var subject = listSubject.Where(x => x.code == code).FirstOrDefault();
            return View(subject);
        }

        [HttpPost]
        public ActionResult Edit(Subject subject)
        {
            SubjectBUS.Instance.Edit(subject.code, subject.codeview, subject.name, subject.numberofcredit, subject.numberoflesson, subject.numberoftheory, subject.numberofexercise, subject.numberofdiscussion, subject.numberofpractive, subject.examform);
            return RedirectToAction("MangagerSubject", "Subject");
        }

        public ActionResult Delete(string code)
        {
            SubjectBUS.Instance.Delete(code);
            return RedirectToAction("MangagerSubject", "Subject");
        }

        [CustomAuthentication]
        public ActionResult SubjectReact()
        {
            return View();
        }
        public ActionResult Search(string name)
        {

            List<Subject> list = SubjectBUS.Instance.Search(name);
            return Json(list, JsonRequestBehavior.AllowGet);
        }


    }
}