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
            return View();
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

    }
}
