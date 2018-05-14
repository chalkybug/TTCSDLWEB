using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTCSDLWeb.Models.BUS;
using TTCSDLWeb.Models.DTO;

namespace TTCSDLWeb.Controllers
{
    public class TrainingdetailsController : Controller
    {
        // GET: Trainingdetails
        IsSession ses = new IsSession();

        public ActionResult Index()
        {

            List<Trainingdetails> listTrainingdetails = TrainingdetailsBUS.Instance.GetList();
            return View(listTrainingdetails);
        }

        public ActionResult MangagerTrainingdetails()
        {
            if (ses.isLogin() == -1)
            {
                return RedirectToAction("Login", "Home");
            }
            List<Trainingdetails> listTrainingdetails = TrainingdetailsBUS.Instance.GetList();
            return View(listTrainingdetails);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trainingdetails trainingdetails)
        {
            TrainingdetailsBUS.Instance.Add(trainingdetails.subjectcode, trainingdetails.educationspecializecode, trainingdetails.fomality, trainingdetails.semester, trainingdetails.groupsubjectcode);
            return RedirectToAction("MangagerTrainingdetails", "Trainingdetails");
        }


        public ActionResult Edit(string subjectcode)
        {
            List<Trainingdetails> listTrainingdetails = TrainingdetailsBUS.Instance.GetList();
            var trainingdetails = listTrainingdetails.Where(x => x.subjectcode == subjectcode).FirstOrDefault();
            return View(trainingdetails);
        }

        [HttpPost]
        public ActionResult Edit(Trainingdetails trainingdetails)
        {
            TrainingdetailsBUS.Instance.Edit(trainingdetails.subjectcode, trainingdetails.educationspecializecode, trainingdetails.fomality, trainingdetails.semester, trainingdetails.groupsubjectcode);
            return RedirectToAction("MangagerTrainingdetails", "Trainingdetails");
        }

        public ActionResult Delete(string subjectcode)
        {
            TrainingdetailsBUS.Instance.Delete(subjectcode);
            return RedirectToAction("MangagerTrainingdetails", "Trainingdetails");
        }

        [CustomAuthentication]
        public ActionResult TrainingdetailsReact()
        {
            return View();
        }
    }
}