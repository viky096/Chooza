using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using Models.DatabaseModels;

namespace Chooza.Controllers
{
    public class OfferingController : Controller
    {
        //
        // GET: /Offering/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            OfferingViewModel model = new OfferingViewModel();
            Logic BL = new Logic();
            var UniversitiesList = BL.ShowUniversity();
            SelectList UniList = new SelectList(UniversitiesList,"Id", "Name");
            ViewBag.UniversityList = UniList;
            var ProgramsList = BL.showProgarm();
            SelectList ProgList = new SelectList(ProgramsList, "Id", "Name");
            ViewBag.ProgramList = ProgList;
            return View(model);
        }

    }
}
