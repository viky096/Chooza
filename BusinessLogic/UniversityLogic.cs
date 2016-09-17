using EntityProvider;
using Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public partial class Logic
    {
        public bool AddUniversity(UniversityViewModel university)
        {
            
            DataAccess DA = new DataAccess();
            
            university.UpdatedBy = CurrentUserId;
            university.CreatedBy = CurrentUserId;
            university.CreatedDate = DateTime.Now;
            university.UpdatedDate = DateTime.Now;
            university.IsDeleted = false;
            return DA.AddUniversity(university);
        }
        public List<UniversityViewModel> ShowUniversity()
        {

            DataAccess DA = new DataAccess();
            return DA.DisplayUniversity();
        }
        public bool DeleteUniversity(int uid)
        { 
          DataAccess DA = new DataAccess();
          return DA.DeleteUniversity(uid);

        }
        public UniversityViewModel EditUniversity(int uid)
        {
            DataAccess DA = new DataAccess();
            return DA.EditUniversity(uid);
        }
        public bool EditUniversity(UniversityViewModel uni)
        {
            DataAccess DA = new DataAccess();
            return DA.EditUniversity(uni);
        }
        public UniversityViewModel UniversityDetails(int uid)
        {
            DataAccess DA = new DataAccess();
            return DA.UniversityDetails(uid);
        }
        
    }
}
