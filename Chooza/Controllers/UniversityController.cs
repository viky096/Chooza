using Chooza.Models;
using Models.DatabaseModels;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Configuration;
using Helpers;

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
                if (HttpContext.Request.Files.AllKeys.Any())
                {
                    // Get the uploaded image from the Files collection
                    HttpPostedFileBase uploadedImage = HttpContext.Request.Files["FileName"];
                    if (uploadedImage != null)
                    {
                        // if (Image.FromStream(uploadedImage.InputStream).Width < 300 && Image.FromStream(uploadedImage.InputStream).Height < 300)
                        {
                            model.ImageData = Image.FromStream(uploadedImage.InputStream).ToByteArray();
                            model.ServerProductLogoPath = ConfigurationManager.AppSettings["UniversityPicturePath"] +
                            ConfigurationManager.AppSettings["ApplicationId"] +
                                "\\" + "abc";

                            model.IsLogoUploaded = true;
                        }
                        //else
                        //{
                        //    return Json(new { Success = false, Message = "Image width and height can not be greater than 300." });
                        //}
                    }
                }
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
        
        public ActionResult Delete(int id)
        {
            try
            {
                int uid = id;
                Logic BL = new Logic();
                BL.DeleteUniversity(uid);
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
                int uid = id;
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
        public ActionResult Details(int id)
        {
            try
            {
                int uid = id;
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
