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
    
    public partial class Recommendation
    {
        public System.Guid Recommendation_ID { get; set; }
        public Nullable<System.Guid> Result_ID { get; set; }
        public Nullable<int> Program_ID { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.Guid> CurrentApplicationId { get; set; }
    
        public virtual Program Program { get; set; }
        public virtual Result Result { get; set; }
    }
}
