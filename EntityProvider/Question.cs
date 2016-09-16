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
    
    public partial class Question
    {
        public Question()
        {
            this.Options = new HashSet<Option>();
        }
    
        public System.Guid Question_ID { get; set; }
        public string Statement { get; set; }
        public Nullable<System.Guid> Test_ID { get; set; }
        public string Result { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.Guid> CurrentApplicationId { get; set; }
    
        public virtual ICollection<Option> Options { get; set; }
        public virtual Test Test { get; set; }
    }
}
