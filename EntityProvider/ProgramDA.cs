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
        public bool AddProgram(ProgramViewModel model)
        {
            Program program = new Program();
           
            program.Name = model.Name;
            program.Skills_Needed = model.SkillsNeeded;
            program.Education_Scope = model.EducationScope;
            program.Employment_Scope = model.EmploymentScope;
            program.Program_Overview = model.ProgramOverview;
            program.CreatedBy = model.CreatedBy;
            program.UpdatedBy = model.UpdatedBy;
            program.CreatedDate = model.CreatedDate;
            program.UpdatedDate = model.UpdatedDate;
            program.IsDeleted = model.IsDeleted;
            Programs.Add(program);
            return SaveChanges() > 0;

        }
        public List<ProgramViewModel> DisplayProgram()
        {
            List<ProgramViewModel> programList=(from p in Programs where (p.IsDeleted==null||p.IsDeleted==false) // && p.CurrentApplicationId==CurrentApplicationId 
                                                select new ProgramViewModel{
            Id=p.Program_ID,
            Name=p.Name,
            SkillsNeeded=p.Skills_Needed,
            EducationScope=p.Education_Scope,
            EmploymentScope=p.Employment_Scope,
            ProgramOverview=p.Program_Overview}).ToList();
            return programList;
        }
        public bool DeleteProgram(int uid)
        {
            Program program = Programs.Find(uid);
            program.IsDeleted = true;
            return SaveChanges() > 0;

        }
        public ProgramViewModel EditProgram(int uid)
        {
            ProgramViewModel program = (from p in Programs
                                              where p.Program_ID == uid
                                              select new ProgramViewModel
                                              {
                                                  Id = p.Program_ID,
                                                  Name = p.Name,
                                                  SkillsNeeded = p.Skills_Needed,
                                                  EducationScope = p.Education_Scope,
                                                  EmploymentScope = p.Employment_Scope,
                                                  ProgramOverview = p.Program_Overview

                                              }).SingleOrDefault();

            return program;
        }
        public bool EditProgram(ProgramViewModel prog)
        {


            Program program = new Program();
            program = Programs.Find(prog.Id);
            program.Program_ID = prog.Id;
            program.Name = prog.Name;
            program.Skills_Needed = prog.SkillsNeeded;
            program.Education_Scope = prog.EducationScope;
            program.Employment_Scope = prog.EmploymentScope;
            program.Program_Overview = prog.ProgramOverview;

            return SaveChanges() > 0;
        }
        public ProgramViewModel ProgramDetails(int pid)
        {
            ProgramViewModel program = (from p in Programs
                                              where p.Program_ID == pid
                                              select new ProgramViewModel
                                              {
                                                  Id = p.Program_ID,
                                                  Name = p.Name,
                                                  SkillsNeeded = p.Skills_Needed,
                                                  EducationScope = p.Education_Scope,
                                                  EmploymentScope = p.Employment_Scope,
                                                  ProgramOverview = p.Program_Overview

                                              }).SingleOrDefault();
            return program;


        }
    }
}
