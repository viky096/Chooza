using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels
{
    public class ProgramViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SkillsNeeded { get; set; }
        public string EducationScope { get; set; }
        public string EmploymentScope { get; set; }
        public string ProgramOverview { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
