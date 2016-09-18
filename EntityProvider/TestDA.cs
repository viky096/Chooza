using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DatabaseModels;

namespace EntityProvider
{
    public partial class DataAccess
    {
        public bool AddTest(TestViewModel model)
        {
            Test test = new Test();
            test.Test_ID = model.Id;
            test.Type = model.Type;
            
            test.CreatedBy = model.CreatedBy;
            test.UpdatedBy = model.UpdatedBy;
            test.CreatedDate = model.CreatedDate;
            test.UpdatedDate = model.UpdatedDate;
            test.IsDeleted = model.IsDeleted;
            Tests.Add(test);
            return SaveChanges() > 0;

        }
        public List<TestViewModel> DisplayTest()
        {
            List<TestViewModel> TestList = (from t in Tests
                                          where (t.IsDeleted == null || t.IsDeleted == false)

                                          select new TestViewModel

                                          //
                                          {
                                              Id = t.Test_ID,
                                              Type = t.Type


                                          }).ToList();
            return TestList;



        }
    }
}
