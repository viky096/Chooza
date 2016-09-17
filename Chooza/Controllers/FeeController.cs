using BusinessLogic;
using Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chooza.Controllers
{
    public class FeeController : Controller
    {
        
       public ActionResult Index()
        {
            try
            {
                Logic BL = new Logic();
                ViewBag.FeeList = BL.DisplayFee();
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
           FeeViewModel model = new FeeViewModel();
           return View(model);
       }
       [HttpPost]
       public ActionResult Create(FeeViewModel model)
       {
           try
           {
               Logic BL = new Logic(new Guid());
               bool result = BL.AddFee(model);

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
               int fid = id;
               Logic BL = new Logic();
               BL.DeleteFee(fid);
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
               int fid = id;
               Logic BL = new Logic();

               return View(BL.EditFee(fid));
           }
           catch (Exception Ex)
           {
               return View();
           }
       }
       [HttpPost]
       public ActionResult Edit(FeeViewModel fe)
       {

           try
           {

               Logic BL = new Logic();
               BL.EditFee(fe);
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
               int fid = id;
               Logic BL = new Logic();

               return View(BL.FeeDetails(fid));
           }
           catch (Exception Ex)
           {
               return View();
           }

       }

    }
}
