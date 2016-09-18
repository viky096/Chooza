using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DatabaseModels
{
    public class BookingViewModel
    {
        public Guid Booking_ID { get; set; }
        public string Description { get; set; }
        public string Date_Time { get; set; }
        public string Status { get; set; }
        public Guid Student_ID { get; set; }
        public Guid Counsellor_ID { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid CurrentApplicationId { get; set; }
    }
}
