//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialFly
{
    using System;
    using System.Collections.Generic;
    
    public partial class SocialUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SocialUser()
        {
            this.Brands = new HashSet<Brand>();
        }
    
        public int SociaLId { get; set; }
        public string Name { get; set; }
        public string SocailMName { get; set; }
        public int FollowerCountId { get; set; }
        public int RegionId { get; set; }
        public int CompId { get; set; }
        public string Email { get; set; }
        public byte[] Image_ { get; set; }
    
        public virtual Compensation Compensation { get; set; }
        public virtual Follower Follower { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
