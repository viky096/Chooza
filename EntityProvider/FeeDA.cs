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
        public List<FeeViewModel> DisplayFee()
        {
            List<FeeViewModel> FeeList = (from f in Fee_Structure
                                                          where (f.IsDeleted == null || f.IsDeleted == false)

                                                          select new FeeViewModel

                                                          //
                                                          {
                                                              Id = f.Fee_ID,
                                                              FirstSemesterFee = f.First_Sem_Fee,
                                                              SecondSemesterOnward = f.Second_Onwards_Fee,
                                                              

                                                          }).ToList();

            return FeeList;



        }
        public bool DeleteFee(int fid)
        {
            Fee_Structure fee = Fee_Structure.Find(fid);
            fee.IsDeleted = true;
            return SaveChanges() > 0;

        }
        public FeeViewModel EditFee(int fid)
        {
            FeeViewModel fee = (from f in Fee_Structure
                                        where f.Fee_ID == fid
                                        select new FeeViewModel
                                        {
                                            Id = f.Fee_ID,
                                            FirstSemesterFee = f.First_Sem_Fee,
                                            SecondSemesterOnward = f.Second_Onwards_Fee
                                            

                                        }).SingleOrDefault();

            return fee;
        }
        public bool EditFee(FeeViewModel fe)
        {


            Fee_Structure fee = new Fee_Structure();
            fee = Fee_Structure.Find(fe.Id);
            fee.Fee_ID = fe.Id;
            fee.First_Sem_Fee = fe.FirstSemesterFee;
            fee.Second_Onwards_Fee = fe.SecondSemesterOnward;
           

            return SaveChanges() > 0;
        }
        public FeeViewModel FeeDetails(int fid)
        {
            FeeViewModel fee = (from f in Fee_Structure
                                              where f.Fee_ID == fid
                                              select new FeeViewModel
                                              {
                                                  Id = f.Fee_ID,
                                                  FirstSemesterFee = f.First_Sem_Fee,
                                                  SecondSemesterOnward = f.Second_Onwards_Fee,
                                                  

                                              }).SingleOrDefault();
            return fee;


        }
    }
}
