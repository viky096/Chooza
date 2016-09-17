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
        public bool AddProgram(ProgramViewModel program)
        {

            DataAccess DA = new DataAccess();
          
            program.CreatedBy = CurrentUserId;
            program.UpdatedBy = CurrentUserId;
            program.CreatedDate = DateTime.Now;
            program.UpdatedDate = DateTime.Now;
            program.IsDeleted = false;
            return DA.AddProgram(program);
        }
        public List<ProgramViewModel> showProgarm()
        {


            DataAccess DA = new DataAccess();
            return DA.DisplayProgram();
        
        }
        public bool DeleteProgram(int uid)
        {
            DataAccess DA = new DataAccess();
            return DA.DeleteProgram(uid);

        }
        public ProgramViewModel EditProgram(int uid)
        {
            DataAccess DA = new DataAccess();
            return DA.EditProgram(uid);
        }
        public bool EditProgram(ProgramViewModel prog)
        {
            DataAccess DA = new DataAccess();
            return DA.EditProgram(prog);
        }
        public ProgramViewModel ProgramDetails(int pid)
        {
            DataAccess DA = new DataAccess();
            return DA.ProgramDetails(pid);
        }
    }
}
