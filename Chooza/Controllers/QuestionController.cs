using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DatabaseModels;
using BusinessLogic;

namespace Chooza.Controllers
{
    public class QuestionController : Controller
    {
        //
        // GET: /Question/

        public ActionResult Index()
        {
            try
            {
                Logic BL = new Logic();
                ViewBag.QuestionList = BL.DisplayQuestion();
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            QuestionViewModel model = new QuestionViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(QuestionViewModel model)
        {
            try
            {
                Logic BL = new Logic(new Guid());
                bool result = BL.AddQuestion(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }

        }

    }
}
