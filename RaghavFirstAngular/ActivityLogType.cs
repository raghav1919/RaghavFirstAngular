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
    
    public partial class ActivityLogType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityLogType()
        {
            this.ActivityLogs = new HashSet<ActivityLog>();
        }
    
        public int Id { get; set; }
        public string SystemKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}
