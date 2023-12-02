//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Z_Hunger.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CollectionRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollectionRequest()
        {
            this.Collecteds = new HashSet<Collected>();
        }
    
        public int CollectionRequestID { get; set; }
        [Required]
        public string IteamName { get; set; }
        [Required]
        public string CreationTime { get; set; }
        [Required]
        public string ExpiredTime { get; set; }
      
        public int RestaurantID { get; set; }
        [Required]
        public string Status { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collected> Collecteds { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
