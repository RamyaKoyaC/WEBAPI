//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        public int CUST_ID { get; set; }
        public string CUST_NAME { get; set; }
        public int CUST_AGE { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PhoneNo { get; set; }
        public bool ALIVE { get; set; }
    }
}
