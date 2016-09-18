using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DatabaseModels;
using EntityProvider;

namespace BusinessLogic
{
    public partial class Logic
    {
        public bool AddTest(TestViewModel test)
        {

            DataAccess DA = new DataAccess(new Guid());
            test.Id = Guid.NewGuid();
            test.CreatedBy = CurrentUserId;
            test.UpdatedBy = CurrentUserId;
            test.CreatedDate = DateTime.Now;
            test.UpdatedDate = DateTime.Now;
            test.IsDeleted = false;
            return DA.AddTest(test);
        }
        public List<TestViewModel> DisplayTest()
        {

            DataAccess DA = new DataAccess();
            return DA.DisplayTest();
        }
    }
}
