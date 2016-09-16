using Chooza.Models;
using Models.DatabaseModels;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chooza.Controllers
{
    public class UniversityController : Controller
    {
        //
        // GET: /University/

        public ActionResult Index()
        {
            try
            {
                Logic BL = new Logic();
                ViewBag.UniversitiesList = BL.ShowUniversity();
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
            UniversityViewModel model = new UniversityViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(UniversityViewModel model)
        {
            try
            {
                Logic BL = new Logic(new Guid());
                bool result = BL.AddUniversity(model);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(model);
            }

        }
        public ActionResult Test()
        {
            return View();
        }
        
        public ActionResult Delete(Guid id)
        {
            try
            {
                Guid uid = id;
                Logic BL = new Logic();
                BL.DeleteUniversity(uid);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public ActionResult Edit(Guid id)
        {
            try
            {
                Guid uid = id;
                Logic BL = new Logic();
               
               return View(BL.EditUniversity(uid));
            }
            catch(Exception Ex)

            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(UniversityViewModel uni)
        {

            try
            {
                
                Logic BL = new Logic();
                BL.EditUniversity(uni);
                return RedirectToAction("Index");
            }
            catch (Exception Ex)
            {
                return View();
            }    
        }
        public ActionResult Details(Guid id)
        {
            try
            {
                Guid uid = id;
                Logic BL = new Logic();
               
                return View(BL.UniversityDetails(uid));
            }
            catch (Exception Ex)
            {
                return View();
            }   
          
        }

    }
}
