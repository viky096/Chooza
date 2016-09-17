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
        public bool AddFee(FeeViewModel fee)
        {

            DataAccess DA = new DataAccess(new Guid());
            
            fee.CreatedBy = CurrentUserId;
            fee.UpdatedBy = CurrentUserId;
            fee.CreatedDate = DateTime.Now;
            fee.UpdatedDate = DateTime.Now;
            fee.IsDeleted = false;
            return DA.AddFee(fee);
        }
        public List<FeeViewModel> DisplayFee()
        {

            DataAccess DA = new DataAccess();
            return DA.DisplayFee();
        }
        public bool DeleteFee(int fid)
        {
            DataAccess DA = new DataAccess();
            return DA.DeleteFee(fid);

        }
        public FeeViewModel EditFee(int fid)
        {
            DataAccess DA = new DataAccess();
            return DA.EditFee(fid);
        }
        public bool EditFee(FeeViewModel fe)
        {
            DataAccess DA = new DataAccess();
            return DA.EditFee(fe);
        }
        public FeeViewModel FeeDetails(int fid)
        {
            DataAccess DA = new DataAccess();
            return DA.FeeDetails(fid);
        }

    }
}
