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
        public bool AddFee(FeeViewModel model)
        {
            Fee_Structure fee = new Fee_Structure();
            fee.Fee_ID = model.Id;
            fee.First_Sem_Fee = model.FirstSemesterFee;
            fee.Second_Onwards_Fee = model.SecondSemesterOnward;
            fee.CreatedBy = model.CreatedBy;
            fee.UpdatedBy = model.UpdatedBy;
            fee.CreatedDate = model.CreatedDate;
            fee.UpdatedDate = model.UpdatedDate;
            fee.IsDeleted = model.IsDeleted;
            Fee_Structure.Add(fee);
            return SaveChanges() > 0;

        }
    }
}
