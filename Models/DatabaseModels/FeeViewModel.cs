using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels
{
    public class FeeViewModel
    {
        public Guid Id { get; set; }
        public string FirstSemesterFee { get; set; }
        public string SecondSemesterOnward { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
