//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL_business_object_layer_
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_user
    {
        public int User_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Csharp { get; set; }
        public Nullable<bool> Java { get; set; }
        public Nullable<bool> Python { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<System.DateTime> DBO { get; set; }
        public string ImagePath { get; set; }
        public string Role { get; set; }
    
        public virtual tbl_city tbl_city { get; set; }
    }
}
