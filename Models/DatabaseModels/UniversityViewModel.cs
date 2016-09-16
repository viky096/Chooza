using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Models.DatabaseModels
{
    public class UniversityViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Introduction { get; set; }
        public string Admission_details { get; set; }
        public byte[] ImageData { get; set; }
        public string FileName { get; set; }
        public int ImageSize { get; set; }
       

        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CurrentApplicationId  { get; set; }
    }
}
