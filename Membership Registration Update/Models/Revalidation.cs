//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Membership_Registration_Update.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Revalidation
    {
        public int ID { get; set; }
        public string RegID { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Grade { get; set; }
        public Nullable<System.DateTime> Date_Printed { get; set; }
        public Nullable<System.DateTime> Date_Approved { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
    
        public virtual Grade Grade1 { get; set; }
        public virtual RevalStatu RevalStatu { get; set; }
    }
}
