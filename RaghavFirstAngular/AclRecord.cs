//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaghavFirstAngular
{
    using System;
    using System.Collections.Generic;
    
    public partial class AclRecord
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int CustomerRoleId { get; set; }
    
        public virtual CustomerRole CustomerRole { get; set; }
    }
}
