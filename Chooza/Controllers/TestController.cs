using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DatabaseModels;
using BusinessLogic;

namespace Chooza.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            try
            {
                Logic BL = new Logic();
                ViewBag.TestList = BL.DisplayTest();
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
            TestViewModel model = new TestViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(TestViewModel model)
        {
            try
            {
                Logic BL = new Logic(new Guid());
                bool result = BL.AddTest(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }

        }

    }
}
