//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class Program
    {
        public Program()
        {
            this.Program_University = new HashSet<Program_University>();
            this.Recommendations = new HashSet<Recommendation>();
        }
    
        public int Program_ID { get; set; }
        public string Name { get; set; }
        public string Skills_Needed { get; set; }
        public string Education_Scope { get; set; }
        public string Employment_Scope { get; set; }
        public string Program_Overview { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.Guid> CurrentApplicationId { get; set; }
    
        public virtual ICollection<Program_University> Program_University { get; set; }
        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
