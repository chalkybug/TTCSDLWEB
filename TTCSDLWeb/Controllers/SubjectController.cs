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

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult doLogin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("123"))
            {
                ses.login();
                return RedirectToAction("MangagerSubject", "Subject");
            }
            return RedirectToAction("Login", "Subject");
        }

        public ActionResult MangagerSubject()
        {
            if (ses.isLogin() == -1)
            {
                return RedirectToAction("Login", "Subject");
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

    }
}