using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chooza.Models;
using Models.DatabaseModels;
using BusinessLogic;

namespace Chooza.Controllers
{
    public class ProgramController : Controller
    {
        //
        // GET: /Program/

        public ActionResult Index()
        {

            Logic BL = new Logic();
            ViewBag.programList = BL.showProgarm();
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ProgramViewModel model = new ProgramViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ProgramViewModel model)
        {
            try
            {
                Logic BL = new Logic(new Guid());
                bool result = BL.AddProgram(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }

        }
        public ActionResult Delete(int id)
        {
            try
            {
                int pid = id;
                Logic BL = new Logic();
                BL.DeleteProgram(pid);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            try
            {
                int pid = id;
                Logic BL = new Logic();

                return View(BL.EditProgram(pid));
            }
            catch (Exception Ex)
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(ProgramViewModel prog)
        {

            try
            {

                Logic BL = new Logic();
                BL.EditProgram(prog);
                return RedirectToAction("Index");
            }
            catch (Exception Ex)
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            try
            {
                int pid = id;
                Logic BL = new Logic();

                return View(BL.ProgramDetails(pid));
            }
            catch (Exception Ex)
            {
                return View();
            }

        }

        

    }
}
