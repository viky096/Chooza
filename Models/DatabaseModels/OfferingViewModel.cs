using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels
{
    public class OfferingViewModel
    {
        public Guid Id { get; set; }
        public int Program_ID { get; set; }
        public int University_ID { get; set; }
        public int Fee_ID { get; set; }
        public int Duration { get; set; }
        public string HSSC_Criteria { get; set; }
        public string SSC_Criteria { get; set; }
        public string Reference { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
