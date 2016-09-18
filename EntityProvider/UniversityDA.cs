using Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProvider
{
    public partial class DataAccess
    {
        public bool AddUniversity(UniversityViewModel model)
        {
            University university = new University();
            
            university.Name = model.Name;
            university.City = model.City;
            university.Introduction = model.Introduction;
            university.Admission_Details = model.Admission_details;
            //university.ImageData = model.ImageData;
            university.Website = model.Website;
            university.Address = model.Address;
            university.Sector = model.Sector;
            university.CreatedBy = model.CreatedBy;
            university.UpdatedBy = model.UpdatedBy;
            university.IsDeleted = model.IsDeleted;
            university.CreatedDate = model.CreatedDate;
            university.UpdatedDate = model.UpdatedDate;
            university.CurrentApplicationId = model.CurrentApplicationId;
            if (model.IsLogoUploaded && (!string.IsNullOrEmpty(model.ServerProductLogoPath)))
            {
                 university.FileName = model.ServerProductLogoPath;
                //university.LogoType = model.LogoType;
                System.IO.FileInfo file = new System.IO.FileInfo(model.ServerProductLogoPath);
                file.Directory.Create(); // If the directory already exists, this method does nothing.
                if (File.Exists(model.ServerProductLogoPath))
                {
                    File.Delete(model.ServerProductLogoPath);
                }
                MemoryStream ms = new MemoryStream(model.ImageData);
                Image universityLogo = Image.FromStream(ms);
                universityLogo.Save(model.ServerProductLogoPath);
            }
            Universities.Add(university);
            return SaveChanges() > 0;

        }
        public List<UniversityViewModel> DisplayUniversity()
        {
            List<UniversityViewModel> UniversitiesList = (from u in Universities
                                                          where (u.IsDeleted == null || u.IsDeleted == false)
                                                          
                                                          select new UniversityViewModel
                                                          
                                                          //
                                                          {
                                                              Id=u.University_ID,
                                                              Name=u.Name,
                                                              City=u.City,
                                                              Introduction=u.Introduction,
                                                              Admission_details=u.Admission_Details,
                                                              ImageData=u.ImageData

                                                          }).ToList();
            
                return UniversitiesList;
           
            

        }

        public bool DeleteUniversity(int uid)
        {
            University university = Universities.Find(uid);
            university.IsDeleted = true;
            return SaveChanges() > 0;
            
        }

        public UniversityViewModel EditUniversity(int uid)
        {
            UniversityViewModel university = (from u in Universities
                                              where u.University_ID == uid
                                              select new UniversityViewModel
                                              {
                                                  Id = u.University_ID,
                                                  Name = u.Name,
                                                  City = u.City,
                                                  Introduction = u.Introduction,
                                                  Admission_details = u.Admission_Details,
                                                  ImageData = u.ImageData,
                                                  Website=u.Website,
                                                  Address=u.Address,
                                                  Sector=u.Sector

                                              }).SingleOrDefault();

            return university;
        }
        public bool EditUniversity(UniversityViewModel uni)
        {
           

            University university = new University();
            university = Universities.Find(uni.Id);
            university.University_ID = uni.Id;
            university.Name = uni.Name;
            university.City = uni.City;
            university.Introduction = uni.Introduction;
            university.Admission_Details = uni.Admission_details;
            university.ImageData = uni.ImageData;
            university.Website = uni.Website;
            university.Address = uni.Address;
            university.Sector = uni.Sector;
            
            return SaveChanges() > 0; 
        }
        public UniversityViewModel UniversityDetails(int uid)
        {
            UniversityViewModel university = (from u in Universities
                                              where u.University_ID == uid
                                              select new UniversityViewModel
                                              {
                                                  Id = u.University_ID,
                                                  Name = u.Name,
                                                  City = u.City,
                                                  Introduction = u.Introduction,
                                                  Admission_details = u.Admission_Details,
                                                  ImageData = u.ImageData,
                                                  Website=u.Website,
                                                  Address=u.Address,
                                                  Sector=u.Sector

                                              }).SingleOrDefault();
            return university;

        
        }
    }
}
