﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDLWeb.Models.BUS;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Controllers
{
    public class EducationspecializeController : Controller
    {
        // GET: Educationspecialize
        IsSession ses = new IsSession();
        public ActionResult Index()
        {
            List<Educationspecialize> list = EducationspecializeBUS.Instance.GetList();

            return View(list);
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
                return RedirectToAction("MangagerEducationspecialize", "Educationspecialize");
            }
            return RedirectToAction("Login", "Educationspecialize");
        }

        public ActionResult MangagerEducationspecialize()
        {
            if (ses.isLogin() == -1)
            {
                return RedirectToAction("Login", "Educationspecialize");
            }
            List<Educationspecialize> listEducationspecialize = EducationspecializeBUS.Instance.GetList();
            return View(listEducationspecialize);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Educationspecialize edu)
        {
            EducationspecializeBUS.Instance.Add(edu.code, edu.codeview, edu.name, edu.educationfieldcode);
            return RedirectToAction("MangagerEducationspecialize", "Educationspecialize");
        }


        public ActionResult Edit(string code)
        {
            List<Educationspecialize> listEducationspecialize = EducationspecializeBUS.Instance.GetList();
            var subject = listEducationspecialize.Where(x => x.code == code).FirstOrDefault();
            return View(subject);
        }

        [HttpPost]
        public ActionResult Edit(Educationspecialize edu)
        {
            EducationspecializeBUS.Instance.Edit(edu.code, edu.codeview, edu.name, edu.educationfieldcode);
            return RedirectToAction("MangagerEducationspecialize", "Educationspecialize");
        }

        public ActionResult Delete(string code)
        {
            EducationspecializeBUS.Instance.Delete(code);
            return RedirectToAction("MangagerEducationspecialize", "Educationspecialize");
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}